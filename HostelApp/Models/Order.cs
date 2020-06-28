using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Models
{
    public class Order
    {
        public int ID { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public int FreeBedCount { get; set; }

        [Required]
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }

        [Required]
        public string AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }

        public bool IsReserved { get; set; }

    }
}
