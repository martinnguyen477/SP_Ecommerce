using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class BookView
    {
        public int Id { get; set; }

        [Required]
        public string BookId { get; set; }

        [Required]
        public string SessionId { get; set; }
        public string CustomerId { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Book Book { get; set; }
    }
}
