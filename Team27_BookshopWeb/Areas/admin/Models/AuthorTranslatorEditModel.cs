using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UoN.ExpressiveAnnotations.NetCore.Attributes;

namespace Team27_BookshopWeb.Areas.admin.Models
{
    public class AuthorTranslatorEditModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Tên tác giả/dịch giả không được trống")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Slug không được trống")]
        public string Slug { get; set; }
        public int Author { get; set; }
        public int Translator { get; set; }
    }
}
