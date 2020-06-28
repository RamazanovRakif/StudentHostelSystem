using HostelApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        public Hostel Hostel { get; set; }
        public IEnumerable<RoomImage> RoomImages { get; set; }
        public IEnumerable<News> News { get; set; }
        public IEnumerable<Facilty> Facilties { get; set; }
        public IEnumerable<Partner> Partners { get; set; }
    }
}
