using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class Comment
    {
        private string _boughtStatus;
        public int Id { get; set; }
        public string CustomerId { get; set; }

        [Required]
        public string Name { get; set; }
        public string Email { get; set; }

        [Required]
        public string BookId { get; set; }
        public int Vote { get; set; }

        [Required]
        public string Content { get; set; }
        public int Bought { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [NotMapped]
        public string DisplayBoughtStatus
        {
            get
            {
                return (this.Bought == 1) ? "Đã mua" : "Chưa mua";
            }
            set
            {
                this._boughtStatus = value;
            }
        }

        public virtual Customer Customer { get; set; }
        public virtual Book Book { get; set; }
    }
}
