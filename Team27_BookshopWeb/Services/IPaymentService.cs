using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface IPaymentService
    {
        IEnumerable<PaymentMethod> ListPaymentMethod();

        MessagesViewModel CreatePayment(PaymentMethodEditModel pm);

        MessagesViewModel EditPayment(PaymentMethodEditModel pmEM);

        PaymentMethod GetPayment(int id);

        PaymentMethodEditModel PaymentToEditModel(PaymentMethod p2);

        IQueryable<PaymentMethod> Fliter(string isSupport, IQueryable<PaymentMethod> p);
    }
}
