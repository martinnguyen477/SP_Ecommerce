using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface ICustomerService
    {
        MessagesViewModel CreateCustomer(CustomerEditModel khEM);

        IEnumerable<Customer> ListCustomer();

        MessagesViewModel EditCustomer(CustomerEditModel khEM);

        MessagesViewModel DeleteCustomerTmp(string id);

        IQueryable<Customer> WhereId(string id, IQueryable<Customer> customers);

        Customer GetCustomer(string id);

        IQueryable<Customer> FindCustomer(string name, IQueryable<Customer> customers);

        IEnumerable<Customer> FindCustomerName(string name);

        MessagesViewModel Delete(string id);

        IEnumerable<Customer> ListDeletedTmpCustomer();

        MessagesViewModel Restore(string id);

        IEnumerable<Customer> FindDeletedCustomerName(string name);

        IQueryable<Customer> GetCustomersNotDelete();

        bool UsernameValidation(string username, string customerId);
        bool EmailValidation(string email, string customerId);

        CustomerEditModel CustomerToEditModel(Customer cs);
        CustomerEditModel RegisterUserToCustomerEdit(RegisterViewModel registerUser);
        MessagesViewModel CustomerAuthentication(LoginViewModel loginUser);
        ClaimsPrincipal CreateCustomerPrincipal(Customer user);
        MessagesViewModel EditCustomerPassword(string id, string password);
        bool PasswordCheck(string id, string pass);
        IEnumerable<Wishlist> GetWishlists(string id);
        bool IsFavorited(string customerId, string bookId);
        MessagesViewModel HandleWishlist(string customerId, string bookId);
    }
}

