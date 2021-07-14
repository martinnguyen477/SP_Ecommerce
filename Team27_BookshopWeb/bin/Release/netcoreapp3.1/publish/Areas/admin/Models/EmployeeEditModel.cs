using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Team27_BookshopWeb.Models;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class EmployeeEditModel
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
        [StringLength(10)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập địa chỉ")]
        [DisplayName("Địa chỉ")]
        [StringLength(500)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập email")]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Email không đúng")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập vị trí")]
        [DisplayName("Chức vụ")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập username")]
        [DisplayName("Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Yêu cầu nhập password")]
        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Ngày tham gia")]
        public DateTime CreatedAt { get; set; }
        public MessagesViewModel MessagesView { get; set; }
    }
}
