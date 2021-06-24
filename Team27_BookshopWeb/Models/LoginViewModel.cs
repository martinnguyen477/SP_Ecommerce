using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Tên đăng nhập không được trống")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được trống")]
        public string Password { get; set; }

    }
}
