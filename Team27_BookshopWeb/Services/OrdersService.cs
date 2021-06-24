using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public class OrdersService : IOrdersService
    {
        private readonly MyDbContext myDbContext;
        private readonly ICustomerService _customerService;
        private readonly ICartsService _cartsService;
        private readonly IBooksService _booksService;
        public OrdersService(MyDbContext myDbContext,
                                ICustomerService customerService,
                                ICartsService cartsService,
                                IBooksService booksService)
        {
            this.myDbContext = myDbContext;
            this._customerService = customerService;
            this._cartsService = cartsService;
            this._booksService = booksService;
        }

        //Lấy order và các thông tin liên quan
        public Order GetOrderWithDetail(string orderId)
        {
            Order order = WhereId(orderId, myDbContext.Orders)
                .Include(o => o.OrderStatus)
                .Include(o => o.PaymentMethod)
                .Include(o => o.Coupon)
                .Include(o => o.OrderDetails).FirstOrDefault();
            foreach (var detail in order.OrderDetails.ToList())
            {
                myDbContext.Entry(detail)
                    .Reference(d => d.Book).Load();
            }
            return order;
        }

        //Place order
        public MessagesViewModel PlaceOrder(CheckoutViewModel checkoutView, string customerId, Cart cart)
        {
            Coupon coupon = new Coupon();
            if (!string.IsNullOrEmpty(customerId))
            {
                Customer customer = _customerService.GetCustomer(customerId);
                if (customer == null)
                {
                    return new MessagesViewModel(false, "Khách hàng không tồn tại");
                }
            }

            if (!string.IsNullOrEmpty(checkoutView.Coupon))
            {
                MessagesViewModel messagesModel = ApplyCoupon(checkoutView.Coupon);
                if (!messagesModel.IsSuccess) return new MessagesViewModel(false, messagesModel.Messages.First());
                coupon = (Coupon)messagesModel.Data;
                if (checkoutView.SubTotal < coupon.MinPrice) return new MessagesViewModel(false, "Đơn hàng phải tối thiểu " + coupon.MinPrice.ToString("N0") + " VND");
            }

            if (cart == null) return new MessagesViewModel(false, "Giỏ hàng trống");
            IEnumerable<CartItems> cartItems = _cartsService.GetCheckoutItems(cart.Id);
            if (cartItems.Count() <= 0) return new MessagesViewModel(false, "Không có sản phẩm trong giỏ hàng");
            //Tạo đơn hàng
            Order order = new Order();
            try
            {
                order.Id = CreateOrderId();
                if (!string.IsNullOrEmpty(customerId))
                {
                    order.CustomerId = customerId;
                }
                order.Name = checkoutView.Name;
                if (!string.IsNullOrEmpty(checkoutView.Email))
                {
                    order.Email = checkoutView.Email;
                }
                order.Address = checkoutView.Address;
                order.Phone = checkoutView.Phone;
                if (!string.IsNullOrEmpty(checkoutView.Note))
                {
                    order.Note = checkoutView.Note;
                }
                if (cartItems.Count() > 0)
                {
                    order.SubTotal = cartItems.Sum(c => c.Total);
                }

                order.Total = order.SubTotal;

                if (!string.IsNullOrEmpty(checkoutView.Coupon))
                {
                    order.CouponId = coupon.Id;
                    if (coupon.IsFixed == 0)
                    {
                        order.Total = order.SubTotal * (100 - coupon.DiscountAmount) / 100;
                    }
                    else
                    {
                        order.Total = order.SubTotal - coupon.DiscountAmount;
                    }
                }

                order.PaymentMethodId = 1;
                order.StatusId = 1;
                order.PaymentStatus = 0;
                order.CreatedAt = DateTime.Now;
                order.UpdatedAt = DateTime.Now;

                myDbContext.Add(order);
                myDbContext.SaveChanges();
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Không thể tạo đơn hàng");
            }

            //Tạo chi tiết đơn hàng
            try
            {
                var count = 1;
                foreach (var item in cartItems)
                {
                    OrderDetail orderDetail = new OrderDetail();
                    orderDetail.OrderDetailId = count;
                    if (order != null)
                    {
                        orderDetail.OrderId = order.Id;
                    }
                    orderDetail.BookId = item.BookId;
                    orderDetail.Quantity = item.Quantity;
                    orderDetail.Price = item.Book.Price;
                    orderDetail.Total = item.Total;
                    orderDetail.CreatedAt = DateTime.Now;

                    myDbContext.Add(orderDetail);
                    myDbContext.SaveChanges();

                    count++;
                }
            }
            catch (Exception)
            {
                myDbContext.RemoveRange(myDbContext.OrderItems.Where(o => o.OrderId == order.Id));
                myDbContext.Remove(order);
                return new MessagesViewModel(false, "Tạo đơn hàng thất bại: Không thể thêm sản phẩm vào đơn hàng");
            }

            //Cập nhật coupon
            if (!string.IsNullOrEmpty(checkoutView.Coupon))
            {
                try
                {
                    coupon.Uses = coupon.Uses + 1;
                    coupon.UpdatedAt = DateTime.Now;
                    myDbContext.Update(coupon);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {
                    myDbContext.RemoveRange(myDbContext.OrderItems.Where(o => o.OrderId == order.Id));
                    myDbContext.Remove(order);
                    return new MessagesViewModel(false, "Tạo đơn hàng thất bại: Không thể áp dụng mã khuyến mãi");
                }
            }
            

            //Xóa giỏ hàng
            if (cartItems.Count() > 0)
            {
                try
                {
                    foreach (var item in cartItems)
                    {
                        myDbContext.Remove(item);
                    }
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {
                    myDbContext.RemoveRange(myDbContext.OrderItems.Where(o => o.OrderId == order.Id));
                    myDbContext.Remove(order);
                    return new MessagesViewModel(false, "Tạo đơn hàng thất bại");
                }
            }
            
            return new MessagesViewModel(true, "Tạo đơn hàng thành công", order.Id);
        }

        //Tạo Id mới
        public string CreateOrderId()
        {
            //Lấy tất cả các đơn hàng trong db và sắp xếp giảm dần theo Id
            var allOrders = this.GetAllOrders().OrderByDescending(b => b.Id).ToList();
            var lastId = "";
            //Nếu có đơn hàng thì lấy ra id cuối cùng
            if (allOrders.Count > 0)
            {
                lastId = allOrders.FirstOrDefault().Id;
            }
            //Tạo Id mới theo từng bảng
            return _booksService.CreateNewId("DH", allOrders.Count(), lastId);
        }

        //ApplyCoupon
        public MessagesViewModel ApplyCoupon(string code)
        {
            if (!string.IsNullOrEmpty(code))
            {
                Coupon coupon = myDbContext.Coupons.Where(c => c.Code == code &&
                                                            c.DeletedAt == null &&
                                                            c.ExpiresAt.Date > DateTime.Now.Date &&
                                                            c.StartsAt.Date <= DateTime.Now.Date &&
                                                            c.Uses <= c.MaxUses).FirstOrDefault();
                if (coupon != null)
                {
                    return new MessagesViewModel(true, "Thành công", coupon);
                }
                return new MessagesViewModel(false, "Coupon không tồn tại");
            }
            return new MessagesViewModel(false, "Code trống");
        }

        //Hiển thị filter
        public IEnumerable<Object> GetFilter(string filterType)
        {
            if (filterType == "OrderStatus")
            {
                return myDbContext.OrderStatuses.ToList();
            }
            return myDbContext.PaymentMethods.Where(p => p.IsSupported == 1).ToList();
        }

        //Lấy đơn hàng theo theo id khách hàng
        public IEnumerable<Order> GetOrdersByCustomerId(string id)
        {
            IQueryable<Order> queryAllOrders = QueryAllOrders()
                                                .Include(o => o.Customer)
                                                .Include(o => o.OrderDetails)
                                                .AsQueryable();
            return WhereCustomerId(id, queryAllOrders);
        }

        //Truy vấn đơn hàng theo khách hàng id
        public IQueryable<Order> WhereCustomerId(string id, IQueryable<Order> orders)
        {
            return orders.Where(o => o.CustomerId == id).AsQueryable();
        }

        //Truy vấn đơn hàng theo ngày
        public IQueryable<Order> WhereBetweenDate(DateTime fromDate, DateTime toDate, IQueryable<Order> orders)
        {
            var ordersQuery = orders;
            if (fromDate != null && toDate != null)
            {
                ordersQuery = orders.Where(o => o.CreatedAt.Date >= fromDate.Date
                                                && o.CreatedAt.Date <= toDate.Date)
                    .AsQueryable();
            }
            return ordersQuery.OrderBy(o => o.Id)
                .Include(o => o.PaymentMethod)
                .Include(o => o.OrderStatus)
                .AsQueryable();
        }

        //Truy vấn đơn hàng theo Phương thức thanh toán
        public IQueryable<Order> WherePaymentMethod(int paymentMethod, IQueryable<Order> orders)
        {
            var ordersQuery = orders;
            if (paymentMethod != 0)
            {
                ordersQuery = orders.Where(o => o.PaymentMethodId == paymentMethod)
                    .AsQueryable();
            }
            return ordersQuery.OrderBy(o => o.Id)
                .Include(o => o.PaymentMethod)
                .Include(o => o.OrderStatus)
                .AsQueryable();
        }

        //Truy vấn đơn hàng theo Tình trạng đơn hàng
        public IQueryable<Order> WhereOrderStatus(int status, IQueryable<Order> orders)
        {
            var ordersQuery = orders;
            if (status != 0)
            {
                ordersQuery = orders.Where(o => o.StatusId == status)
                   .AsQueryable();
            }
            return ordersQuery.OrderBy(o => o.Id)
                .Include(o => o.PaymentMethod)
                .Include(o => o.OrderStatus)
                .AsQueryable();
        }

        //Truy vấn đơn hàng theo Tên khách hàng
        public IQueryable<Order> WhereCustomerName(string name, IQueryable<Order> orders)
        {
            return orders.Where(o => EF.Functions.Like(o.Name, "%" + name + "%"))
                .OrderBy(o => o.Id)
                .AsQueryable();
        }

        //Cập nhật tình trạng đơn hàng
        public MessagesViewModel UpdateOrder(string orderId, int status)
        {
            MessagesViewModel messagesViewModel = new MessagesViewModel();
            messagesViewModel.Data = "";
            //Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(orderId) || status == null)
            {
                return new MessagesViewModel(false, "Cần nhập đủ dữ liệu mã và trạng thái đơn hàng");
            }

            //Tìm đơn hàng theo id
            var order = this.GetOrder(orderId);
            if (order != null)
            {
                //Lưu lại trạng thái cũ
                messagesViewModel.Data = order.StatusId;

                //Kiểm tra trạng thái hợp lệ hay không
                if (!this.Valid(status))
                {
                    return new MessagesViewModel(false, "Trạng thái đơn hàng không hợp lệ");
                }

                try
                {
                    order.StatusId = status;

                    myDbContext.Update(order);
                    myDbContext.SaveChanges();

                    //Nếu phương thức thanh toán là tiền mặt thì cập nhật trạng thái thanh toán
                    if (order.PaymentMethodId == 1)
                    {
                        //Nếu trạng thái đơn hàng đã giao thành công thì cập nhật đã thanh toán
                        //    ngược lại cập nhật chưa thanh toán
                        switch (order.StatusId)
                        {
                            case 4:
                                order.PaymentStatus = 1;
                                break;
                            default:
                                order.PaymentStatus = 0;
                                break;
                        }
                        myDbContext.Update(order);
                        myDbContext.SaveChanges();
                    }

                    return new MessagesViewModel(true, "Cập nhật trạng thái đơn hàng thành công");
                }
                catch (Exception)
                {
                    return new MessagesViewModel(false, "Cập nhật trạng thái đơn hàng thất bại");
                }
            }

            return new MessagesViewModel(false, "Đơn hàng không tồn tại");
        }

        //Cập nhật trạng thái thanh toán
        public bool UpdatePaymentStatus(Order order, int status)
        {
            if (order != null)
            {
                try
                {
                    order.PaymentStatus = status;
                    myDbContext.Update(order);
                    myDbContext.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }

            return false;
        }

        //Truy vấn đơn hàng theo Id
        public IQueryable<Order> WhereId(string orderId, IQueryable<Order> orders)
        {
            return orders.Where(o => o.Id == orderId).AsQueryable();
        }

        //Kiểm tra tình trạng đơn hàng có hợp lệ. Nếu hợp lệ trả về true, ngược lại trả về false
        public bool Valid(int statusId)
        {
            var check = this.WhereStatusId(statusId, myDbContext.OrderStatuses).FirstOrDefault();
            return (check != null) ? true : false;
        }

        //Where id tình trạng đơn hàng trong bảng OrderStatus
        public IQueryable<OrderStatus> WhereStatusId(int statusId, IQueryable<OrderStatus> statuses)
        {
            return statuses.Where(s => s.Id == statusId).OrderBy(s => s.Id).AsQueryable();
        }

        //Lấy chi tiết đơn hàng theo id đơn hàng
        public IEnumerable<OrderDetail> GetOrderDetails(string OrderId)
        {
            return myDbContext.OrderItems.Where(oi => oi.OrderId == OrderId)
                                        .Include(i => i.Book);
        }

        //Lấy thông tin đơn hàng
        public Order GetOrder(string Id)
        {
            return this.WhereId(Id, myDbContext.Orders)
                .Include(o => o.Coupon)
                .Include(o => o.OrderStatus)
                .Include(o => o.PaymentMethod)
                .FirstOrDefault();
        }

        //Lấy tất cả đơn hàng
        public IEnumerable<Order> GetAllOrders()
        {
            return myDbContext.Orders.OrderBy(o => o.Id)
                    .Include(o => o.PaymentMethod)
                    .Include(o => o.OrderStatus).ToList();
        }
        //Truy vấn tất cả đơn hàng
        public IQueryable<Order> QueryAllOrders()
        {
            return myDbContext.Orders.OrderBy(o => o.Id)
                    .Include(o => o.PaymentMethod)
                    .Include(o => o.OrderStatus).AsQueryable();
        }
    }
}
