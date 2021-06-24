using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Areas.admin.Models;

namespace Team27_BookshopWeb.Services
{
    public interface ITKDoanhThuService
    {
        IQueryable<DoanhThuViewModel> ListRevenue(int days);

    }
}
