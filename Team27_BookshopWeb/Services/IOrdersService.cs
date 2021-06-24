using System;
using System.Collections.Generic;
using System.Linq;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface IOrdersService
    {
        IEnumerable<Order> GetAllOrders();
        Order GetOrder(string Id);
        IEnumerable<OrderDetail> GetOrderDetails(string OrderId);
        MessagesViewModel UpdateOrder(string orderId, int status);
        bool UpdatePaymentStatus(Order order, int status);
        IQueryable<Order> WhereId(string orderId, IQueryable<Order> orders);
        bool Valid(int statusId);
        IQueryable<OrderStatus> WhereStatusId(int statusId, IQueryable<OrderStatus> statuses);
        IQueryable<Order> WhereOrderStatus(int status, IQueryable<Order> orders);
        IQueryable<Order> WhereCustomerName(string name, IQueryable<Order> orders);
        IEnumerable<Object> GetFilter(string filterType);
        IQueryable<Order> WherePaymentMethod(int paymentMethod, IQueryable<Order> orders);
        IQueryable<Order> QueryAllOrders();
        IQueryable<Order> WhereBetweenDate(DateTime fromDate, DateTime toDate, IQueryable<Order> orders);
        IQueryable<Order> WhereCustomerId(string id, IQueryable<Order> orders);
        IEnumerable<Order> GetOrdersByCustomerId(string id);
        MessagesViewModel ApplyCoupon(string code);
        MessagesViewModel PlaceOrder(CheckoutViewModel checkoutView, string customerId, Cart cart);
        Order GetOrderWithDetail(string orderId);
    }
}