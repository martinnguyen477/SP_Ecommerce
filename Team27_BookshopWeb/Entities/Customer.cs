using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class Customer
    {
        private string _name, _gender;

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
        public int Gender { get; set; }

        [Required]
        [MaxLength(11)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Hiển thị giới tính
        [NotMapped]
        public string DisplayGender
        {
            get
            {
                return (this.Gender == 1) ? "Nữ" : "Nam";
            }
            set
            {
                this._gender = value;
            }
        }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<BookView> BookViews { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }

        public Customer()
        {
            BookViews = new HashSet<BookView>();
            Orders = new HashSet<Order>();
            Comments = new HashSet<Comment>();
            Wishlists = new HashSet<Wishlist>();
        }
    }
}
