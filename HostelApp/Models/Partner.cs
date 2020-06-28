using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Models
{
    public class Partner
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Logo { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
