using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class EmployeeProfileEditModel
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập tên")]
        [DisplayName("Họ tên nhân viên")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập giới tính")]
        [DisplayName("Giới tính")]
        public int Gender { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập ngày sinh")]
        [DisplayName("Ngày sinh")]
        public DateTime Birthdate { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập số điện thoại")]
        [DisplayName("Số điện thoại")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập địa chỉ")]
        [DisplayName("Địa chỉ")]
        [StringLength(500)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [DisplayName("Chức vụ")]
        public string Position { get; set; }

        [DisplayName("Username")]
        public string Username { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Ngày tham gia")]
        public DateTime CreatedAt { get; set; }
        public MessagesViewModel MessagesView { get; set; }
    }
}
