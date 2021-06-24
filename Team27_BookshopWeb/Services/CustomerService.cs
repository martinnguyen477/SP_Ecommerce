using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using BC = BCrypt.Net.BCrypt;
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using System.Globalization;

namespace Team27_BookshopWeb.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly MyDbContext myDbContext;
        private readonly IBooksService _booksService;
        public CustomerService(MyDbContext myDbContext, IBooksService booksService)
        {
            this.myDbContext = myDbContext;
            _booksService = booksService;
        }

        //Thêm/xóa sách vào danh sách yêu thích
        public MessagesViewModel HandleWishlist(string customerId, string bookId)
        {
            Wishlist wishlist = myDbContext.Wishlists.Where(w => w.CustomerId == customerId && w.BookId == bookId)
                                                .FirstOrDefault();
            //Không có trong danh sách yêu thích
            if (wishlist == null) {
                Wishlist newWishlist = new Wishlist();
                
                try
                {
                    newWishlist.BookId = bookId;
                    newWishlist.CustomerId = customerId;
                    newWishlist.CreatedAt = DateTime.Now;

                    myDbContext.Add(newWishlist);
                    myDbContext.SaveChanges();
                    return new MessagesViewModel(true, "Thêm sách vào danh sách yêu thích", "add");
                }
                catch (Exception)
                {
                    return new MessagesViewModel(false, "Không thể thêm sách vào danh sách yêu thích");
                }

            }
            else
            {
                //Có trong danh sách yêu thích
                try
                {
                    //Đã xóa -> Thêm lại
                    if (wishlist.DeletedAt != null)
                    {
                        wishlist.DeletedAt = null;
                        myDbContext.Update(wishlist);
                        myDbContext.SaveChanges();
                        return new MessagesViewModel(true, "Thêm sách yêu thích thành công", "add");
                    }
                    else
                    {
                        //Chưa xóa -> Xóa
                        wishlist.DeletedAt = DateTime.Now;
                        myDbContext.Update(wishlist);
                        myDbContext.SaveChanges();
                        return new MessagesViewModel(true, "Xóa sách yêu thích thành công", "remove");
                    }
                }
                catch (Exception)
                {
                    return new MessagesViewModel(false, "Thất bại");
                }
            }
        }

        //Kiểm tra sách có nằm trong danh sách yêu thích không
        public bool IsFavorited(string customerId, string bookId)
        {
            int wishlist = QueryWishlist(customerId).Where(w => w.BookId == bookId && w.DeletedAt == null).Count();
            return (wishlist > 0) ? true : false;
        }

        //Lấy danh sách yêu thích của khách hàng
        public IEnumerable<Wishlist> GetWishlists(string id)
        {
            return QueryWishlist(id).ToList();
        }

        public IQueryable<Wishlist> QueryWishlist(string id)
        {
            IQueryable<Wishlist> wishlists = null;
            if (!string.IsNullOrEmpty(id))
            {
                wishlists = myDbContext.Wishlists
                    .Include(w => w.Book)
                    .ThenInclude(b => b.BookImages)
                    .Where(w => w.DeletedAt == null && w.CustomerId == id && w.Book.DeletedAt == null).AsQueryable();
            }
            return wishlists;
        }
        
        //Kiểm tra password
        public bool PasswordCheck(string id, string pass)
        {
            var customer = GetCustomer(id);
            return BC.Verify(pass, customer.Password);
        }

        //edit mật khẩu khách hàng
        public MessagesViewModel EditCustomerPassword(string id, string password)
        {
            if (string.IsNullOrEmpty(id)) {
                return new MessagesViewModel(false, "Id không được trống");
            }
            var customer = GetCustomer(id);
            try
            {
                customer.Password = BC.HashPassword(password);
                customer.UpdatedAt = DateTime.Now;

                myDbContext.Update(customer);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Cập nhật thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Cập nhật thất bại");
            }
        }

        //Tạo customer principal
        public ClaimsPrincipal CreateCustomerPrincipal(Customer user)
        {
            //Tạo list claims
            var claims = new List<Claim>
                {
                    new Claim("Id", user.Id),
                    new Claim(ClaimTypes.Role, "Khách hàng")
                };
            //create identity
            var userIdentity = new ClaimsIdentity(claims, "login");
            //create principal
            var principal = new ClaimsPrincipal(userIdentity);
            return principal;
        }

        //Kiểm tra đăng nhập
        public MessagesViewModel CustomerAuthentication(LoginViewModel loginUser)
        {
            //Tìm khách hàng theo username
            Customer user = myDbContext.Customers.SingleOrDefault(u => u.Username == loginUser.Username);
            //Kiểm tra password
            if (user == null || !BC.Verify(loginUser.Password, user.Password))
            {
                return new MessagesViewModel(false, "Tài khoản hoặc mật khẩu không đúng");
            }
            return new MessagesViewModel(true, "", user);
        }

        //RegisterUser to CustomerEdit
        public CustomerEditModel RegisterUserToCustomerEdit(RegisterViewModel registerUser)
        {
            CustomerEditModel customerEdit = new CustomerEditModel();
            try
            {
                customerEdit.Name = registerUser.Name;
                customerEdit.Gender = registerUser.Gender;
                customerEdit.Phone = registerUser.Phone;
                customerEdit.Address = registerUser.Address;
                customerEdit.Email = registerUser.Email;
                customerEdit.Username = registerUser.Username;
                customerEdit.Password = registerUser.Password;
                return customerEdit;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Tạo Id mới
        public string CreateNewCustomerId()
        {
            //Lấy tất cả các khách hàng hiện có, bao gồm các sách tạm xóa và sắp xếp giảm dần theo Id
            var allCustomers = this.GetAllCustomers().OrderByDescending(b => b.Id).ToList();
            var lastId = "";
            //Nếu có khách hàng thì lấy ra id cuối cùng
            if (allCustomers.Count > 0)
            {
                lastId = allCustomers.FirstOrDefault().Id;
            }
            //Tạo Id mới theo từng bảng
            return _booksService.CreateNewId("KH", allCustomers.Count(), lastId);
        }

        //Lấy tất cả khách hàng, bao gồm các Khách hàng đã tạm xóa (chỉ lấy Khách hàng),không có các đối tượng liên quan
        private IQueryable<Customer> GetAllCustomers()
        {
            return myDbContext.Customers.OrderBy(b => b.Id).AsQueryable();
        }

        public IEnumerable<Customer> ListCustomer()
        {
            IEnumerable<Customer> customers = myDbContext.Customers
                                                  .Where(p => p.DeletedAt == null)
                                                  .OrderBy(p => p.Id)
                                                  .ToList();
            return customers;
        }

  
        public MessagesViewModel CreateCustomer(CustomerEditModel khEM)
        {
            var kh = new Customer();

            if(!EmailValidation(khEM.Email, ""))
            {
                return new MessagesViewModel(false, "Email đã tồn tại");
            }

            var checkUsername = myDbContext.Customers.Where(p => p.Username == khEM.Username).Count();

            if (checkUsername > 0)
            {
                return new MessagesViewModel(false, "Username này đã tồn tại");
            }

            try
            {
                kh.Id = CreateNewCustomerId();
                kh.CreatedAt = DateTime.Now;
                kh = EditModelToCustomer(khEM, kh);
                string passwordHash = BC.HashPassword(khEM.Password);
                kh.Password = passwordHash;

                myDbContext.Add(kh);
                myDbContext.SaveChanges(); 
                return new MessagesViewModel(true, "Đăng ký thành công");
            }
            catch (Exception)
            {

                return new MessagesViewModel(false, "Đăng ký thất bại");
            }
        }

        public CustomerEditModel CustomerToEditModel(Customer cs)
        {
            CustomerEditModel kh = new CustomerEditModel();          
            try
            {
                kh.Id = cs.Id;
                kh.Name = cs.DisplayName;
                kh.Phone = cs.Phone;
                kh.Gender = cs.Gender;
                kh.Email = cs.Email;
                kh.Address = cs.Address;
                kh.Username = cs.Username;
                kh.Password = cs.Password;
                
            }
            catch (Exception)
            {

                return null;
            }
            return kh;
        }

        public Customer EditModelToCustomer(CustomerEditModel cs, Customer kh)
        {
            TextInfo tI = new CultureInfo("en-US", false).TextInfo;
            try
            {
                kh.Name = tI.ToTitleCase(tI.ToLower(cs.Name));
                kh.Phone = cs.Phone;
                kh.Gender = cs.Gender;
                kh.Email = cs.Email;
                kh.Address = cs.Address;
                kh.Username = cs.Username;
                kh.UpdatedAt = DateTime.Now;

                return kh;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public MessagesViewModel EditCustomer(CustomerEditModel khEM)
        {
            if (String.IsNullOrEmpty(khEM.Id)){
                return new MessagesViewModel(false, "Id không được trống");
            }
            

            if (!EmailValidation(khEM.Email, khEM.Id))
            {
                return new MessagesViewModel(false, "Email đã tồn tại");
            }
            var checkUsername = myDbContext.Customers.Where(p => p.Username == khEM.Username && p.Id != khEM.Id).Count();
            if (checkUsername > 0)
            {
                return new MessagesViewModel(false, "Username này đã tồn tại");
            }
            //ktra khách hàng đã có trong database chưa
            var checkCus = WhereId(khEM.Id, GetAllCustomers()).FirstOrDefault(); //kiểu customer
            try
            {
                checkCus = EditModelToCustomer(khEM, checkCus);
                myDbContext.Update(checkCus);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Sửa thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Sửa thất bại");
            }
            
        }
        
        public MessagesViewModel DeleteCustomerTmp(string id)
        {
            //ktra khách hàng đã có trong database chưa
            var checkCus = WhereId(id, GetAllCustomers()).FirstOrDefault();
            try
            {
                checkCus.DeletedAt = DateTime.Now;

                myDbContext.Update(checkCus);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Đã xóa");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Không thể đưa vào danh sách");
            }
        }

        public IEnumerable<Customer> FindCustomerName(string name)
        {
            IEnumerable<Customer> list = FindCustomer(name, GetCustomersNotDelete()).ToList();
            return list;
        }

        public IEnumerable<Customer> FindDeletedCustomerName(string name)
        {
            IEnumerable<Customer> list = FindCustomer(name, GetCustomersDeleteTmp()).ToList();
            return list;
        }

        public IQueryable<Customer> FindCustomer(string name, IQueryable<Customer> customers)
        {
            return customers.Where(p => EF.Functions.Like(p.Name, "%" + name + "%")).AsQueryable();
        }

        public Customer GetCustomer(string id)
        {
            var customer = WhereId(id, GetCustomersNotDelete()).FirstOrDefault();
            return customer;
        }

        //lấy ds khách hàng chưa bị xóa 
        public IQueryable<Customer> GetCustomersNotDelete()
        {
            return myDbContext.Customers.Where(p => p.DeletedAt == null).OrderBy(p => p.Id).AsQueryable();
        }

        //lấy ds khách hàng bị xóa
        public IQueryable<Customer> GetCustomersDeleteTmp()
        {
            return myDbContext.Customers.Where(p => p.DeletedAt != null).OrderBy(p => p.Id).AsQueryable();
        }

        public IQueryable<Customer> WhereId(string id, IQueryable<Customer> customers)
        {
            return customers.Where(p => p.Id == id).AsQueryable();
        }

        public IEnumerable<Customer> ListDeletedTmpCustomer()
        {
            IEnumerable<Customer> customers = GetCustomersDeleteTmp().ToList();
            return customers;
        }

        public MessagesViewModel Delete(string id)
        {
            MessagesViewModel messagesViewModel = new MessagesViewModel();
            // ktra khách hàng đã có trong ds delete tạm chưa
            var checkCus = WhereId(id, GetCustomersDeleteTmp()).FirstOrDefault();
            try
            {
                myDbContext.Remove(checkCus);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Đã xóa vĩnh viễn");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Xóa vĩnh viễn không thành công");
            }

        }

        public MessagesViewModel Restore(string id)
        {  
            // ktra khách hàng đã có trong ds delete tạm chưa
            var checkCus = WhereId(id, GetCustomersDeleteTmp()).FirstOrDefault();
            try
            {
                checkCus.DeletedAt = null;
                myDbContext.Update(checkCus);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Khôi phục thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Không khôi phục thành công");
            }
        } 

        //Kiểm tra username, nếu không tồn tại username thì trả về true

        public bool UsernameValidation(string username, string customerId)
        {
            return (EmailOrUsernameExists(username, "username", customerId) != true) ? true : false;
        }

        //Kiểm tra email, nếu không tồn tại email thì trả về true
        public bool EmailValidation(string email, string customerId)
        {
            return (EmailOrUsernameExists(email, "email", customerId) != true) ? true : false;
        }

        //Kiểm tra username/email, nếu tồn tại username/email thì trả về true
        public bool EmailOrUsernameExists(string usernameOrEmail, string type, string customerId)
        {
            IQueryable<Customer> customer;
            if (type != "email")
            {
                customer = WhereUsername(usernameOrEmail, myDbContext.Customers);
            }
            else
            {
                customer = WhereEmail(usernameOrEmail, myDbContext.Customers);
            }
            
            //Nếu có Id customer thì không count id đó
            if (!string.IsNullOrEmpty(customerId))
            {
                customer = customer.Where(c => c.Id != customerId).AsQueryable();
            }
            if (customer.Count() > 0) return true;
            return false;
        }

        //Truy vấn theo username
        public IQueryable<Customer> WhereUsername(string username, IQueryable<Customer> customers)
        {
            return customers.Where(c => c.Username == username).AsQueryable();
        }

        //Truy vấn theo email
        public IQueryable<Customer> WhereEmail(string email, IQueryable<Customer> customers)
        {
            return customers.Where(c => c.Email == email).AsQueryable();
        }
    }
}
