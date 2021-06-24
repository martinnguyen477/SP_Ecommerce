using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class Coupon
    {
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Slug { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
        public int Uses { get; set; }
        public int MaxUses { get; set; }
        public int MaxUsesUser { get; set; }

        [Required]
        public string Type { get; set; }
        public double DiscountAmount { get; set; }
        public double MinPrice { get; set; }
        public int IsFixed { get; set; }

        [Required]
        public string Image { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public Coupon()
        {
            Orders = new HashSet<Order>();
        }
    }
}
