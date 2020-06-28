using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Models
{
    public class AppUser:IdentityUser
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string FatherName { get; set; }

        [Required]
        public string IDCardNumber { get; set; }

        [Required]
        public int StudentTicketNumber { get; set; }

        public string Image { get; set; }

        [Required]
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }

        public virtual ICollection<Order> Orders { get; set; } 

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
