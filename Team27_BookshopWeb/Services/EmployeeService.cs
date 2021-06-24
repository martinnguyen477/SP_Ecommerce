using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;
using BC = BCrypt.Net.BCrypt;

namespace Team27_BookshopWeb.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly MyDbContext myDbContext;
        private readonly IBooksService _booksService;
        public EmployeeService(MyDbContext myDbContext, IBooksService booksService)
        {
            this.myDbContext = myDbContext;
            _booksService = booksService;
        }

        //Kiểm tra password
        public bool PasswordCheck(string id, string pass)
        {
            var employee = GetEmployee(id);
            return BC.Verify(pass, employee.Password);
        }

        //edit mật khẩu nhân viên
        public MessagesViewModel EditEmployeePassword(string id, string password)
        {
            if (string.IsNullOrEmpty(id))
            {
                return new MessagesViewModel(false, "Id không được trống");
            }
            var employee = GetEmployee(id);
            try
            {
                employee.Password = BC.HashPassword(password);
                employee.UpdatedAt = DateTime.Now;

                myDbContext.Update(employee);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Cập nhật thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Cập nhật thất bại");
            }
        }

        //Lấy các claims
        public string GetClaim(ClaimsPrincipal user, string claimName)
        {
            var claims = user.Claims.ToList();
            //Filter specific claim
            if (claimName == "Email")
            {
                return claims.Where(c => c.Type == ClaimTypes.Email).Select(c => c.Value).SingleOrDefault();
            }
            return claims.Where(c => c.Type == claimName).Select(c => c.Value).SingleOrDefault();
        }

        //Tạo employee principal
        public ClaimsPrincipal CreateEmployeePrincipal(Employee user)
        {
            //Tạo list claims
            var claims = new List<Claim>
                {
                    new Claim("Id", user.Id),
                    new Claim(ClaimTypes.Role, user.Position)
                };
            //create identity
            var userIdentity = new ClaimsIdentity(claims, "admin-login");
            //create principal
            var principal = new ClaimsPrincipal(userIdentity);
            return principal;
        }

        //Kiểm tra đăng nhập
        public MessagesViewModel EmployeeAuthentication(LoginViewModel loginUser)
        {
            //Tìm khách hàng theo username
            Employee user = myDbContext.Employees.SingleOrDefault(u => u.Username == loginUser.Username);
            //Kiểm tra password
            if (user == null || loginUser.Password != user.Password)
            {
                return new MessagesViewModel(false, "Tài khoản hoặc mật khẩu không đúng");
            }
            return new MessagesViewModel(true, "", user);
        }

        public IEnumerable<Employee> ListEmployee()
        {
            IEnumerable<Employee> employee = myDbContext.Employees
                                                  .OrderBy(p => p.Id)
                                                  .ToList();
            return employee;
        }

        //Lấy tất cả nhân viên
        private IQueryable<Employee> GetAllEmployees()
        {
            return myDbContext.Employees.OrderBy(b => b.Id).AsQueryable();
        }

        //Tạo Id mới
        public string CreateNewEmployeeId()
        {
            //Lấy tất cả các nhân viên hiện có
            var allEmployees = this.GetAllEmployees().OrderByDescending(b => b.Id).ToList();
            var lastId = "";
            //Nếu có nhân viên thì lấy ra id cuối cùng
            if (allEmployees.Count > 0)
            {
                lastId = allEmployees.FirstOrDefault().Id;
            }
            //Tạo Id mới theo từng bảng
            return _booksService.CreateNewId("NV", allEmployees.Count(), lastId);
        }

        public EmployeeEditModel ProfileModelToEditModel(EmployeeProfileEditModel nv2)
        {
            EmployeeEditModel nv1 = new EmployeeEditModel();

            try
            {
                nv1.Id = nv2.Id;
                nv1.Name = nv2.Name;
                nv1.Birthdate = nv2.Birthdate;
                nv1.Phone = nv2.Phone;
                nv1.Gender = nv2.Gender;
                nv1.Email = nv2.Email;
                nv1.Address = nv2.Address;
                nv1.Username = nv2.Username;
                nv1.Position = "";
            }
            catch (Exception)
            {
                return null;
            }
            return nv1;
        }

        public EmployeeProfileEditModel EmployeeToProfileModel(Employee nv2)
        {
            EmployeeProfileEditModel nv1 = new EmployeeProfileEditModel();

            try
            {
                nv1.Id = nv2.Id;
                nv1.Name = nv2.Name;
                nv1.Birthdate = nv2.Birthdate;
                nv1.Phone = nv2.Phone;
                nv1.Gender = nv2.Gender;
                nv1.Email = nv2.Email;
                nv1.Address = nv2.Address;
                nv1.Username = nv2.Username;
                nv1.Position = nv2.Position;
                nv1.CreatedAt = nv2.CreatedAt;
            }
            catch (Exception)
            {
                return null;
            }
            return nv1;
        }

        public EmployeeEditModel EmployeeToEditModel(Employee nv2)
        {
            EmployeeEditModel nv1 = new EmployeeEditModel();

            try
            {
                nv1.Id = nv2.Id;
                nv1.Name = nv2.Name;
                nv1.Birthdate = nv2.Birthdate;
                nv1.Phone = nv2.Phone;
                nv1.Gender = nv2.Gender;
                nv1.Email = nv2.Email;
                nv1.Address = nv2.Address;
                nv1.Username = nv2.Username;
                nv1.Password = nv2.Password;
                nv1.Position = nv2.Position;
                nv1.CreatedAt = nv2.CreatedAt;
            }
            catch (Exception)
            {
                return null;
            }
            return nv1;
        }

        public Employee EditModelToEmployee(EmployeeEditModel nv1, Employee nv2)
        {
            try
            {
                nv2.Name = nv1.Name;
                nv2.Birthdate = nv1.Birthdate;
                nv2.Phone = nv1.Phone;
                nv2.Gender = nv1.Gender;
                nv2.Email = nv1.Email;
                nv2.Address = nv1.Address;
                if (!string.IsNullOrEmpty(nv1.Username))
                {
                    nv2.Username = nv1.Username;
                }
                
                if (!string.IsNullOrEmpty(nv1.Position))
                {
                    nv2.Position = nv1.Position;
                }
                nv2.UpdatedAt = DateTime.Now;

                return nv2;
            }
            catch (Exception)
            {

                return null;
            }

        }

        public MessagesViewModel CreateEmployee(EmployeeEditModel nvEM)
        {
            var checkUsername = myDbContext.Employees.Where(p => p.Username == nvEM.Username).Count();
            if (checkUsername > 0)
            {
                return new MessagesViewModel(false, "Username này đã tồn tại");
            }

            if (!EmailValidation(nvEM.Email, ""))
            {
                return new MessagesViewModel(false, "Email đã tồn tại");
            }

            var nv = new Employee();
            try
            {
                nv.Id = CreateNewEmployeeId();
                nv.CreatedAt = DateTime.Now;
                nv = EditModelToEmployee(nvEM, nv);
                string passwordHash = BC.HashPassword(nvEM.Password);
                nv.Password = passwordHash;

                myDbContext.Add(nv);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Thêm thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Thêm thất bại");
            }

        }

        public MessagesViewModel EditEmployee(EmployeeEditModel nvEM)
        {
            if (String.IsNullOrEmpty(nvEM.Id))
            {
                return new MessagesViewModel(false, "Id không được trống");
            }


            if (!EmailValidation(nvEM.Email, nvEM.Id))
            {
                return new MessagesViewModel(false, "Email đã tồn tại");
            }
            var checkUsername = myDbContext.Employees.Where(p => p.Username == nvEM.Username && p.Id != nvEM.Id).Count();
            if (checkUsername > 0)
            {
                return new MessagesViewModel(false, "Username này đã tồn tại");
            }
            //ktra nhân viên đã có trong database chưa
            var checkCus = WhereId(nvEM.Id, GetAllEmployees()).FirstOrDefault(); //kiểu employee
            try
            {
                checkCus = EditModelToEmployee(nvEM, checkCus);

                myDbContext.Update(checkCus);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Sửa thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Sửa thất bại");
            }

        }

        
        public MessagesViewModel Delete(string id)
        {
            // ktra nhân viên có  trong ds chưa
            var checkCus = WhereId(id, GetAllEmployees()).FirstOrDefault();
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

        public IEnumerable<string> FilterByPosition()
        {
            IEnumerable<string> position = myDbContext.Employees.Select(p => p.Position).Distinct().ToList();
            return position;
        }

        public IQueryable<Employee> FindName(string name, IQueryable<Employee> employees)
        {
            return employees.Where(p => EF.Functions.Like(p.Name, "%" + name + "%")).AsQueryable();
        }

        public IQueryable<Employee> Fliter(string position, IQueryable<Employee> e)
        {
            IQueryable<Employee> res;
            if (position == null) position = "All";
            switch (position)
            {
                case "All":
                    res = e.OrderBy(b => b.Id).AsQueryable();
                    break;
                default:
                    res = e.Where(p => p.Position == position).AsQueryable();
                    break;
            }
            return res;
        }

        public Employee GetEmployee(string id)
        {
            var employee = WhereId(id, GetAllEmployees()).FirstOrDefault();
            return employee;
        }

        public IQueryable<Employee> WhereId(string id, IQueryable<Employee> employees)
        {
            return employees.Where(p => p.Id == id).AsQueryable();
        }

        //Kiểm tra email, nếu tồn tại email thì trả về true
        public bool EmailValidation(string email, string employeeId)
        {
            return !EmailOrUsernameExists(email, "email", employeeId) ? true : false;
        }

        public bool UsernameValidation(string username, string employeeId)
        {
            return !EmailOrUsernameExists(username, "username", employeeId) ? true : false;
        }

        //Kiểm tra username/email, nếu tồn tại username/email thì trả về true
        public bool EmailOrUsernameExists(string usernameOrEmail, string type, string employeeId)
        {
            IQueryable<Employee> employee;
            if (type != "email")
            {
                employee = WhereUsername(usernameOrEmail, myDbContext.Employees);
            }
            else
            {
                employee = WhereEmail(usernameOrEmail, myDbContext.Employees);
            }

            //Nếu có Id employee thì không count id đó
            if (!string.IsNullOrEmpty(employeeId))
            {
                employee = employee.Where(c => c.Id != employeeId).AsQueryable();
            }
            if (employee.Count() > 0) return true;
            return false;
        }

        //Truy vấn theo username
        public IQueryable<Employee> WhereUsername(string username, IQueryable<Employee> employees)
        {
            return employees.Where(c => c.Username == username).AsQueryable();
        }

        //Truy vấn theo email
        public IQueryable<Employee> WhereEmail(string email, IQueryable<Employee> employees)
        {
            return employees.Where(c => c.Email == email).AsQueryable();
        }
    }
}
