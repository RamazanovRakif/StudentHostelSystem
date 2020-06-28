using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Models
{
    public class Group
    {
        public int ID { get; set; }

        [Required]
        public string GroupName { get; set; }

        public virtual ICollection<AppUser> AppUsers { get; set; }

        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
