using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Entities;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class BookEditModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Tên sách không được trống")]
        [DisplayName("Tên sách")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Slug không được trống")]
        [DisplayName("Slug")]
        public string Slug { get; set; }

        [Required(ErrorMessage = "Giá không được trống")]
        [Range(0, double.PositiveInfinity, ErrorMessage = "Giá tiền phải lớn hơn {0}")]
        [DisplayName("Giá bán")]
        public double Price { get; set; }
        //[Range(1, 12, ErrorMessage = "Tháng xuất bản phải trong khoảng từ 1 đến 12")]
        [DisplayName("Tháng")]
        public int? PublicationMonth { get; set; }

        [Required(ErrorMessage = "Năm xuất bản không được trống")]
        [Range(1, int.MaxValue, ErrorMessage = "Năm xuất bản phải lớn hơn 0")]
        [DisplayName("Năm")]
        public int PublicationYear { get; set; }

        [Required(ErrorMessage = "Mô tả không được trống")]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Số trang phải lớn hơn hoặc bằng 1")]
        [DisplayName("Số trang")]
        public int? Pages { get; set; }

        [Required]
        [DisplayName("Loại sách")]
        public string CategoryId { get; set; }

        [Required]
        [DisplayName("Nhà xuất bản")]
        public string PublisherId { get; set; }

        [Required]
        [DisplayName("Tác giả")]
        public string AuthorId { get; set; }

        [DisplayName("Dịch giả")]
        public string TranslatorId { get; set; }

        [DisplayName("Ngày tạo")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("Ảnh đại diện")]
        public string PrimaryImage { get; set; }

        public List<string> RemmovedImages { get; set; }

        public IEnumerable<BookImage> OtherImages { get; set; }
        public IEnumerable<AuthorTranslator> Authors { get; set; }
        public IEnumerable<AuthorTranslator> Translators { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Publisher> Publishers { get; set; }
        public MessagesViewModel MessagesView { get; set; }

        public BookEditModel()
        {
            this.Authors = new HashSet<AuthorTranslator>();
            this.Translators = new HashSet<AuthorTranslator>();
            this.Categories = new HashSet<Category>();
            this.Publishers = new HashSet<Publisher>();
        }
    }
}
