using System.Collections.Generic;
using System.Linq;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface ICartsService
    {
        IQueryable<Cart> QueryNotDeletedCart();
        IQueryable<Cart> WhereCustomerId(string customerId, IQueryable<Cart> carts);
        IQueryable<Cart> WhereId(int id, IQueryable<Cart> carts);
        Cart GetCart(int id);
        IQueryable<Cart> CartIncludeCartItems(int cartId);
        IEnumerable<CartItems> GetCartItems(int cartId);
        Cart GetCartByCustomer(string customerId);
        MessagesViewModel HandleCart(string bookId, int quantity, string customerId);
        MessagesViewModel RemoveCartItem(string bookId, string customerId);
        MessagesViewModel SelectCheckoutItem(int cartId, string bookId, int select);
        IEnumerable<CartItems> GetCheckoutItems(int cartId);
    }
}