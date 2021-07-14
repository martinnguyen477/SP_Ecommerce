using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class PublisherEditModel
    {

        [Required(ErrorMessage = "ID không được trống")]
        [DisplayName("ID")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Tên nhà xuất bản không được trống")]
        [DisplayName("Tên nhà xuất bản")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Slug không được trống")]
        [DisplayName("Slug")]
        public string Slug { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Hình")]
        public string Image { get; set; }

        public MessagesViewModel MessagesView { get; set; }

    }
}
