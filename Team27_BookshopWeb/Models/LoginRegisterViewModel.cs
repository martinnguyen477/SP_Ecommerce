using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Models
{
    public class LoginRegisterViewModel
    {
        public RegisterViewModel Register { get; set; }
        public LoginViewModel Login { get; set; }
        public MessagesViewModel MessagesView { get; set; }
    }
}
