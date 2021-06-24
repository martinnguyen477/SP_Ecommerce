using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class BookImage
    {
        public int Id { get; set; }

        [Required]
        public string BookId { get; set; }

        [Required]
        public string Image { get; set; }
        public int Primary { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual Book Book { get; set; }
    }
}
