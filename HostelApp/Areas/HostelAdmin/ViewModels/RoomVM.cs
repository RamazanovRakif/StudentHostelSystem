using HostelApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Areas.HostelAdmin.ViewModels
{
    public class RoomVM
    {
        public Room Room { get; set; }

        [Required]
        public int SelectedCategory { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public IEnumerable<Room> Rooms { get; set; }
    }
}
