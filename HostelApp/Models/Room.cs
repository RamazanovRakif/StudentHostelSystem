using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Models
{
    public class Room
    {
        public int ID { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        public bool IsReserved { get; set; }

        [Required]
        public int BedCount { get; set; }

        public bool WiFi { get; set; }

        public bool Breakfast { get; set; }

        public string Description { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RoomImage> RoomImages { get; set; }
    }
}
