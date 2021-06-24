using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Team27_BookshopWeb.Entities
{
    public class Employee
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
        public DateTime Birthdate { get; set; }

        [Required]
        [MaxLength(11)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
        public string Email { get; set; }

        [Required]
        public string Position { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        //Hiển thị giới tính
        [NotMapped]
        public string DisplayGender
        {
            get
            {
                return (this.Gender == 1) ? "Nữ" : "Nam";
            }
            set {
                this._gender = value;
            }
        }

        public virtual EmployeeAuthorization EmployeeAuthorization { get; set; }
    }
}
