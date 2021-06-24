using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public class CartsService : ICartsService
    {
        private readonly MyDbContext myDbContext;
        private readonly IBooksService _booksService;
        private readonly ICustomerService _customerService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CartsService(MyDbContext _myDbContext,
                                IBooksService booksService,
                                ICustomerService customerService,
                                IHttpContextAccessor httpContextAccessor)
        {
            this.myDbContext = _myDbContext;
            this._booksService = booksService;
            this._customerService = customerService;
            this._httpContextAccessor = httpContextAccessor;
        }

        //Lấy sản phẩm để thanh toán
        public IEnumerable<CartItems> GetCheckoutItems(int cartId)
        {
            Cart cart = GetCart(cartId);
            if (cart == null) return Enumerable.Empty<CartItems>();

            IEnumerable<CartItems> cartItems = QueryCartItems(cartId).Where(c => c.IsSelected == 1).ToList();
            if (cartItems.Count() <= 0)
            {
                cartItems = QueryCartItems(cartId).ToList();
            }
            return cartItems;
        }

        //Chọn để thanh toán
        public MessagesViewModel SelectCheckoutItem(int cartId, string bookId, int select)
        {
            Cart cart = GetCart(cartId);
            if (cart == null) return new MessagesViewModel(false, "Giỏ hàng không tồn tại");
            Book book = _booksService.WhereId(bookId, _booksService.GetNotDeletedBooks()).FirstOrDefault();
            if (book == null) return new MessagesViewModel(false, "Sách không tồn tại");
            CartItems cartItem = GetCartItem(cartId, bookId);
            try
            {
                cartItem.IsSelected = select;

                myDbContext.Update(cartItem);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Thất bại");
            }
        }

        //Tạo cookie
        public void CreateCookie(string key, string value, bool isPersistent)
        {
            CookieOptions options = new CookieOptions();
            if (isPersistent)
                options.Expires = DateTime.Now.AddDays(1);
            else
                options.Expires = DateTime.Now.AddDays(7);
            _httpContextAccessor.HttpContext.Response.Cookies.Append(key, value, options);
        }

        //Xóa sách trong giỏ hàng
        public MessagesViewModel RemoveCartItem(string bookId, string customerId)
        {
            int cartId;
            Cart cart;

            //Lấy sách theo id
            Book book = _booksService.WhereId(bookId, _booksService.GetNotDeletedBooks()).Include(b => b.BookImages).FirstOrDefault();

            //Kiểm tra sách
            if (book == null) return new MessagesViewModel(false, "Sách không tồn tại");

            //Kiểm tra khách hàng
            if (!string.IsNullOrEmpty(customerId))
            {
                //Có khách hàng
                Customer customer = _customerService.GetCustomer(customerId);
                if (customer == null) return new MessagesViewModel(false, "Khách hàng không tồn tại");
                //Lấy cart
                cart = WhereCustomerId(customerId, myDbContext.Carts).FirstOrDefault();
            }
            else
            {
                //Không có khách hàng
                cartId = int.Parse(_httpContextAccessor.HttpContext.Request.Cookies["cart"]);
                cart = WhereId(cartId, myDbContext.Carts).FirstOrDefault();
            }

            if (cart == null)
            {
                return new MessagesViewModel(false, "Không có giỏ hàng");
            }

            //Kiểm tra cart item
            CartItems cartItem = myDbContext.CartItems.Where(c => c.CartId == cart.Id
                                                            && c.BookId == bookId).FirstOrDefault();

            if (cartItem == null)
            {
                return new MessagesViewModel(false, "Sách không có trong giỏ hàng");
            }

            try
            {
                //Xóa cart item
                cartItem.DeletedAt = DateTime.Now;

                myDbContext.Update(cartItem);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Đã xóa sách trong giỏ hàng", bookId);
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Không thể xóa sách trong giỏ hàng");
            }

        }

        public MessagesViewModel HandleCart(string bookId, int quantity, string customerId)
        {
            int cartId = 0;
            Cart cart;

            //Kiểm tra id sách
            if (string.IsNullOrEmpty(bookId)) return new MessagesViewModel(false, "Mã sách không được trống");

            //Lấy sách theo id
            Book book = _booksService.WhereId(bookId, _booksService.GetNotDeletedBooks()).FirstOrDefault();

            //Kiểm tra sách
            if (book == null) return new MessagesViewModel(false, "Sách không tồn tại");

            //Kiểm tra khách hàng
            if (!string.IsNullOrEmpty(customerId))
            {
                //Có khách hàng
                Customer customer = _customerService.GetCustomer(customerId);
                if (customer == null) return new MessagesViewModel(false, "Khách hàng không tồn tại");
                //Lấy cart
                cart = WhereCustomerId(customerId, myDbContext.Carts).FirstOrDefault();
            }
            else
            {
                //Không có khách hàng
                if (_httpContextAccessor.HttpContext.Request.Cookies["cart"] != null)
                {
                    cartId = int.Parse(_httpContextAccessor.HttpContext.Request.Cookies["cart"]);
                }
                cart = myDbContext.Carts.Where(c => c.Id == cartId && c.DeletedAt.Date > DateTime.Now.Date).FirstOrDefault();
            }

            if (cart == null)
            {
                //Không có giỏ hàng
                //Tạo giỏ hàng
                cart = new Cart();
                try
                {
                    if (!string.IsNullOrEmpty(customerId))
                    {
                        cart.CustomerId = customerId;
                    }
                    cart.CreatedAt = DateTime.Now;
                    cart.DeletedAt = DateTime.Now.AddDays(7);

                    myDbContext.Add(cart);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {
                    return new MessagesViewModel(false, "Không thể tạo giỏ hàng");
                }

                //Thêm cart items
                try
                {
                    CartItems cartItem = new CartItems();
                    cartItem = CreateCartItems(bookId, quantity, cart);

                    myDbContext.Add(cartItem);
                    myDbContext.SaveChanges();
                }
                catch (Exception)
                {
                    return new MessagesViewModel(false, "Không thể thêm sách vào giỏ hàng");
                }

                if(string.IsNullOrEmpty(customerId)) CreateCookie("cart", cart.Id.ToString(), true);
                return new MessagesViewModel(true, "Add");
            }
            else
            {
                //Có giỏ hàng
                try
                {
                    //Cập nhật giỏ hàng
                    cart.DeletedAt = DateTime.Now.AddDays(7);

                    //Kiểm tra cart item
                    CartItems cartItem = myDbContext.CartItems.Where(c => c.CartId == cart.Id 
                                                                    && c.BookId == bookId).FirstOrDefault();
                    if (cartItem != null)
                    {
                        //Đã có sách trong giỏ hàng => Cập nhật sách
                        if (cartItem.DeletedAt.Date <= DateTime.Now.Date)
                        {
                            cartItem = UpdateCartItems(bookId, quantity, cartItem);
                        }
                        else cartItem = UpdateCartItems(bookId, cartItem.Quantity + quantity, cartItem);

                        myDbContext.Update(cartItem);
                        myDbContext.SaveChanges();
                    }
                    else
                    {
                        //Chưa có sách trong giỏ hàng => Thêm sách
                        cartItem = new CartItems();
                        cartItem = CreateCartItems(bookId, quantity, cart);

                        myDbContext.Add(cartItem);
                        myDbContext.SaveChanges();
                    }

                    myDbContext.Update(cart);
                    myDbContext.SaveChanges();

                    //Không đăng nhập sẽ lưu cookie
                    CreateCookie("cart", cart.Id.ToString(), true);
                }
                catch (Exception)
                {
                    return new MessagesViewModel(false, "Không thể cập nhật giỏ hàng");
                }
            }

            return new MessagesViewModel(true, "Cập nhật giỏ hàng thành công", book);
        }

        private CartItems UpdateCartItems(string bookId, int quantity, CartItems cartItem)
        {
            try
            {
                
                if (quantity > 0)
                {
                    //Sách đã bị xóa trong giỏ hàng
                    if (cartItem.DeletedAt.Date <= DateTime.Now.Date)
                    {
                        //Thêm lại sách => Cập nhật lại ngày thêm
                        cartItem.CreatedAt = DateTime.Now;
                    }

                    cartItem.Quantity = quantity;
                    cartItem.UpdatedAt = DateTime.Now;
                    cartItem.DeletedAt = DateTime.Now.AddDays(7);
                }
                return cartItem;
            }
            catch (Exception)
            {
                return cartItem;
            }
        }
        private CartItems CreateCartItems(string bookId, int quantity, Cart cart)
        {
            CartItems cartItem = new CartItems();
            try
            {
                cartItem.CartId = cart.Id;
                cartItem.BookId = bookId;
                cartItem.Quantity = quantity;
                cartItem.CreatedAt = DateTime.Now;
                cartItem.UpdatedAt = DateTime.Now;
                cartItem.DeletedAt = DateTime.Now.AddDays(7);

                return cartItem;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Tìm kiếm sách trong giỏ hàng
        public CartItems GetCartItem(int cartId, string bookId)
        {
            return QueryCartItems(cartId).Where(c => c.BookId == bookId).FirstOrDefault();
        }

        //Truy vấn cart items theo id giỏ hàng
        public IQueryable<CartItems> QueryCartItems(int cartId)
        {
            return myDbContext.CartItems
                            .Include(ci => ci.Book)
                            .Where(ci => ci.CartId == cartId
                                        && ci.DeletedAt.Date > DateTime.Now.Date
                                        && ci.Book.DeletedAt == null).AsQueryable();
        }

        //Lấy chi tiết giỏ hàng
        public IEnumerable<CartItems> GetCartItems(int cartId)
        {
            return myDbContext.CartItems
                                .Include(ci => ci.Book)
                                .ThenInclude(b => b.BookImages)
                                .Where(ci => ci.CartId == cartId && ci.DeletedAt.Date > DateTime.Now.Date && ci.Book.DeletedAt == null).ToList();
        }

        //Truy vấn giỏ hàng cùng chi tiết đơn hàng
        public IQueryable<Cart> CartIncludeCartItems(int cartId)
        {
            if (cartId > 0)
            {
                return WhereId(cartId, QueryNotDeletedCart())
                        .Include(c => c.CartItems)
                        .AsQueryable();
            }
            return null;
        }

        //Lấy giỏ hàng theo khách hàng
        public Cart GetCartByCustomer(string customerId)
        {
            if (!string.IsNullOrEmpty(customerId))
            {
                return WhereCustomerId(customerId, QueryNotDeletedCart()).FirstOrDefault();
            }
            return null;
        }

        //Lấy ra giỏ hàng theo id
        public Cart GetCart(int id)
        {
            if (id > 0)
            {
                return WhereId(id, QueryNotDeletedCart()).FirstOrDefault();
            }
            else return null;
        }

        //Truy vấn giỏ hàng theo id
        public IQueryable<Cart> WhereId(int id, IQueryable<Cart> carts)
        {
            if (id > 0)
            {
                return carts.Where(c => c.Id == id).AsQueryable();
            }
            return carts;
        }

        //Truy vấn giỏ hàng theo id của khách hàng
        public IQueryable<Cart> WhereCustomerId(string customerId, IQueryable<Cart> carts)
        {
            if (!string.IsNullOrEmpty(customerId))
            {
                return carts.Where(c => c.CustomerId == customerId).AsQueryable();
            }
            return carts;
        }

        //Truy vấn giỏ hàng chưa được xóa
        public IQueryable<Cart> QueryNotDeletedCart()
        {
            return myDbContext.Carts.Where(c => c.DeletedAt.Date > DateTime.Now.Date).AsQueryable();
        }
    }
}
