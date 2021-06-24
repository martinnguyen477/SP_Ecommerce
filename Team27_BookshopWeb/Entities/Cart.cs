using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<CartItems> CartItems { get; set; }
        public Cart()
        {
            CartItems = new HashSet<CartItems>();
        }
    }
}
