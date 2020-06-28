using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Models
{
    public class Slider
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(255)]
        public string Content { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
