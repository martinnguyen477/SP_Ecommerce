using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class Book
    {
        private string _name, _pubDate, _priImage, _price;

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
        public double Price { get; set; }

        //Hiển thị giá tiền
        [NotMapped]
        public string DisplayPrice
        {
            get
            {
                CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
                return this.Price.ToString("N0") + " VND";
            }
            set
            {
                this._price = value;
            }
        }
        public int? PublicationMonth { get; set; }

        public int PublicationYear { get; set; }

        [NotMapped] //Không tạo column trong db
        public string PublicationDate {
            get
            {
                if (this.PublicationMonth != null && this.PublicationMonth != 0)
                {
                    return "" + this.PublicationMonth + '/' + PublicationYear;
                }
                else return "" + PublicationYear;
            }
            set
            {
                this._pubDate = value;
            }
        }

        [Required]
        public string Description { get; set; }
        public int? Pages { get; set; }

        [Required]
        public string CategoryId { get; set; }

        [Required]
        public string PublisherId { get; set; }

        [Required]
        public string AuthorId { get; set; }
        public string TranslatorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        //Lấy hình ảnh đại diện cho sách
        [NotMapped] //Không tạo column trong db
        public string PrimaryImage
        {
            get
            {
                return this.BookImages.Where(bi => bi.Primary == 1).Select(bi => bi.Image).FirstOrDefault();
            }
            set
            {
                this._priImage = value;
            }
        }
        
        public virtual AuthorTranslator Author { get; set; }
        public virtual AuthorTranslator Translator { get; set; }
        public virtual Category Category { get; set; }
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<BookImage> BookImages { get; set; }
        public virtual ICollection<BookView> BookViews { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<CartItems> CartItems { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }
        public Book()
        {
            Comments = new HashSet<Comment>();
            BookImages = new HashSet<BookImage>();
            BookViews = new HashSet<BookView>();
            OrderDetails = new HashSet<OrderDetail>();
            CartItems = new HashSet<CartItems>();
            Wishlists = new HashSet<Wishlist>();
        }
    }
}
