using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class EmployeeAuthorization
    {
        [Required]
        public string EmployeeId { get; set; }
        public int View { get; set; }
        public int Insert { get; set; }
        public int Update { get; set; }
        public int Delete { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
