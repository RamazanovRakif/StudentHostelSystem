using HostelApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.ViewModels
{
    public class RoomVM
    {
        public Room Room { get; set; }

        public RoomImage RoomImage { get; set; }

        public IEnumerable<Room> Rooms { get; set; }

        public IEnumerable<RoomImage> RoomImages { get; set; }

        [Required]
        public int SelectedCategory { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
