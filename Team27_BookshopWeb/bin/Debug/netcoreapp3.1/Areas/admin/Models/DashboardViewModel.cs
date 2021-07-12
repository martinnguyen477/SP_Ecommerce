using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class DashboardViewModel
    {
        private string _total;
        public int SoLuongKH { get; set; }

        public int SoSachDaBan { get; set; }

        public float DTTrong1Tuan { get; set; }

        public string DisplayDTTrong1Tuan
        {
            get
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return this.DTTrong1Tuan.ToString("N0");
            }
            set
            {
                this._total = value;
            }
        }

        public float DT1Nam { get; set; }

        public string DisplayDT1Nam
        {
            get
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return this.DT1Nam.ToString("N0");
            }
            set
            {
                this._total = value;
            }
        }

        public int DHMoi { get; set; } //Đơn hàng trong ngày

        public IEnumerable<OrderTypeViewModel> listOrderType { get; set; }

        public int time { get; set; }

        public IEnumerable<Order> listNewOrder { get; set; }
    }
}
