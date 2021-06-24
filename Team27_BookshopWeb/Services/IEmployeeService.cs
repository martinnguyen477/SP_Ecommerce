using System.Collections.Generic;
using System.Linq;
using Team27_BookshopWeb.Areas.admin.Models;
using System.Security.Claims;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> ListEmployee();

        MessagesViewModel CreateEmployee(EmployeeEditModel nvEM);

        MessagesViewModel Delete(string id);

        MessagesViewModel EditEmployee(EmployeeEditModel nvEM);

        Employee GetEmployee(string id);

        EmployeeEditModel EmployeeToEditModel(Employee nv2);

        IQueryable<Employee> FindName(string name, IQueryable<Employee> employees);

        IQueryable<Employee> Fliter(string position, IQueryable<Employee> e);

        IEnumerable<string> FilterByPosition();
        MessagesViewModel EmployeeAuthentication(LoginViewModel loginUser);
        ClaimsPrincipal CreateEmployeePrincipal(Employee user);

        string GetClaim(ClaimsPrincipal user, string claimName);
        MessagesViewModel EditEmployeePassword(string id, string password);
        bool PasswordCheck(string id, string pass);
        bool EmailValidation(string email, string employeeId);
        bool UsernameValidation(string username, string employeeId);
        EmployeeEditModel ProfileModelToEditModel(EmployeeProfileEditModel nv2);
        EmployeeProfileEditModel EmployeeToProfileModel(Employee nv2);
    }
}