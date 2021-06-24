using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Models
{
    public class RegisterViewModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Họ tên không được trống")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Giới tính không được trống")]
        public int Gender { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được trống")]
        [MaxLength(11, ErrorMessage = "Số điện thoại không hợp lệ")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được trống")]
        public string Address { get; set; }
        [EmailAddress(ErrorMessage = "Email không hợp lệ")]
        //[Remote(action: "EmailVerify", controller: "User", AdditionalFields = nameof(Id))]
        public string Email { get; set; }

        [Required(ErrorMessage = "Tên đăng nhập không được trống")]
        //[Remote(action: "UsernameVerify", controller: "User", AdditionalFields = nameof(Id))]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được trống")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Yêu cầu xác nhận mật khẩu")]
        [Compare("Password", ErrorMessage = "Xác nhận mật khẩu không đúng")]
        public string PasswordConfirm { get; set; }
    }
}
