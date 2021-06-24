using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class CategoryEditModel
    {

        [Required(ErrorMessage = "ID không được trống")]
        [DisplayName("ID")]

        public string Id { get; set; }

        [Required(ErrorMessage = "Tên không được trống")]
        [DisplayName("Tên loại sách")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Slug không được trống")]
        [DisplayName("Slug")]
        public string Slug { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime CreatedAt { get; set; }

        
        [DisplayName("Hình dọc")]
        public string VerticalImage { get; set; }

        
        [DisplayName("Hình ngang")]
        public string HorizontalImage { get; set; }

        public MessagesViewModel MessagesView { get; set; }

    }
}
