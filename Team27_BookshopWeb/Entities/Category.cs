using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class Category
    {
        private string _name;

        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        //Hiển thị tên
        [NotMapped]
        public string DisplayName
        {
            get
            {
                TextInfo tI = new CultureInfo("en-US", false).TextInfo;
                return tI.ToTitleCase(tI.ToLower(this.Name));
            }
            set
            {
                this._name = value;
            }
        }

        [Required]
        public string Slug { get; set; }

        [Required]
        public string VerticalImage { get; set; }

        [Required]
        public string HorizontalImage { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public Category()
        {
            Books = new HashSet<Book>();
        }
    }
}
