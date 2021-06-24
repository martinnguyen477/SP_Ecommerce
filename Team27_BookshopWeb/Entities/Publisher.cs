using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Team27_BookshopWeb.Entities
{
    public class Publisher
    {
        private string _name;

        [Required]
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
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        public Publisher()
        {
            Books = new HashSet<Book>();
        }
    }
}
