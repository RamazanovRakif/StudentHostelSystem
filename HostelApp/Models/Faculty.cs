using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Models
{
    public class Faculty
    {
        public int ID { get; set; }

        [Required]
        public string FacultyName { get; set; }

        public virtual ICollection<Group> Groups { get; set; }

        [Required]
        public int UniversityId { get; set; }
        public virtual University University { get; set; }
    }
}
