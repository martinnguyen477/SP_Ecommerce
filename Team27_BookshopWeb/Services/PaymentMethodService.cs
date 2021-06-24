using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public class PaymentMethodService : IPaymentService
    {
        private readonly MyDbContext myDbContext;

        public PaymentMethodService(MyDbContext myDbContext)
        {
            this.myDbContext = myDbContext;
        }

        public IQueryable<PaymentMethod> GetPaymentMethod()
        {
            return myDbContext.PaymentMethods.OrderBy(p => p.Id).AsQueryable();
        }

        public IEnumerable<PaymentMethod> ListPaymentMethod()
        {
            IEnumerable<PaymentMethod> payments = myDbContext.PaymentMethods
                                                  .OrderBy(p => p.Id)
                                                  .ToList();
            return payments;
        }

        public MessagesViewModel CreatePayment(PaymentMethodEditModel pm)
        {
            var pay = new PaymentMethod();
            try
            {
                pay.Name = pm.Name;
                pay.IsSupported = pm.IsSupported;

                myDbContext.Add(pay);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Thêm thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Thêm thất bại");
            }

        }

        public MessagesViewModel EditPayment(PaymentMethodEditModel pmEM)
        {
            //ktra phương thức đã có trong database chưa
            var checkPay = WhereId(pmEM.Id, GetPaymentMethod()).FirstOrDefault(); //kiểu payment method
            try
            {
                checkPay.Name = pmEM.Name;
                checkPay.IsSupported = pmEM.IsSupported;

                myDbContext.Update(checkPay);
                myDbContext.SaveChanges();
                return new MessagesViewModel(true, "Sửa thành công");
            }
            catch (Exception)
            {
                return new MessagesViewModel(false, "Sửa thất bại");
            }

        }

        public IQueryable<PaymentMethod> WhereId(int id, IQueryable<PaymentMethod> payments)
        {
            return payments.Where(p => p.Id == id).AsQueryable();
        }

        public PaymentMethod GetPayment(int id)
        {
            var pm = WhereId(id, GetPaymentMethod()).FirstOrDefault();
            return pm;
        }

        public PaymentMethodEditModel PaymentToEditModel(PaymentMethod p2)
        {
            PaymentMethodEditModel p1 = new PaymentMethodEditModel();

            try
            {
                p1.Id = p2.Id;
                p1.Name = p2.Name;
                p1.IsSupported = p2.IsSupported;
            }
            catch (Exception)
            {
                return null;
            }
            return p1;
        }


        public IQueryable<PaymentMethod> Fliter(string isSupport, IQueryable<PaymentMethod> p)
        {
            IQueryable<PaymentMethod> res;
            if (isSupport == null || isSupport == "2") isSupport = "All";
            switch (isSupport)
            {
                case "All":
                    res = p.OrderBy(b => b.Id).AsQueryable();
                    break;
                default:
                    int isSupport1 = int.Parse(isSupport);
                    res = p.Where(p => p.IsSupported == isSupport1).AsQueryable();
                    break;
            }
            return res;
        }
    }
}
