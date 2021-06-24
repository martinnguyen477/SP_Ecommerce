using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Models
{
    public class CommentEditModel
    {
        public string CustomerId { get; set; }

        [Required(ErrorMessage = "Tên khách hàng không được trống")]
        public string Name { get; set; }
        public string Email { get; set; }

        public string BookId { get; set; }
        [Required(ErrorMessage = "Vui lòng đánh giá cho sách")]
        public int Vote { get; set; }

        [Required (ErrorMessage = "Nội dung nhận xét không được trống")]
        public string Content { get; set; }
    }
}
