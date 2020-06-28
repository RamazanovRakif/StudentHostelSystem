using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
