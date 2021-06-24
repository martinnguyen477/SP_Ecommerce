using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Services
{
    public interface IThongKeService
    {
        IQueryable<TopViewModel> TopViewInclude(int day);

        IQueryable<BestSellerBooksViewModel> BestSellerStatistic(int day);

        IQueryable<CustomerStatisticViewModel> ListCustomer(int days);
    }
}
