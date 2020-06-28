using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Models
{
    public class Hostel
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }


        [Required]
        public string Context { get; set; }
    }
}
