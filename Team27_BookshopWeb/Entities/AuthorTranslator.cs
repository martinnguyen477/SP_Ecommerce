using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class AuthorTranslator
    {
        private string _name;

        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Slug { get; set; }
        public int Author { get; set; }
        public int Translator { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

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

        public virtual ICollection<Book> AuthorBooks { get; set; }
        public virtual ICollection<Book> TranslatorBooks { get; set; }

        public AuthorTranslator()
        {
            AuthorBooks = new HashSet<Book>();
            TranslatorBooks = new HashSet<Book>();
        }
    }
}
