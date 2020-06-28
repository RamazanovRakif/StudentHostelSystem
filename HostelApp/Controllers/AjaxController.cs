using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HostelApp.DAL;
using HostelApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HostelApp.Controllers
{
    public class AjaxController : Controller
    {
        private readonly AppDbContext _dbContext;
        public AjaxController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> LoadFaculties(int? universityId)
        {
            if (universityId == null)
                return NotFound();

            IEnumerable<Faculty> faculties = await _dbContext.Faculties.Include(x => x.Groups).ToListAsync();

            if (faculties == null)
                return NotFound();

            return PartialView("_LoadFacultiesPartialView", faculties);
        }

        public async Task<IActionResult> LoadGroups(int? facultyId)
        {
            if (facultyId == null)
                return NotFound();

            IEnumerable<Group> groups = await _dbContext.Groups.Where(x => x.FacultyId == facultyId).ToListAsync();

            if (groups == null)
                return NotFound();

            return PartialView("_LoadGroupsPartialView", groups);

        }

        public async Task<IActionResult> GetPrice(int? id, DateTime checkInDate, DateTime checkOutDate, int personCount)
        {
            if (id == null)
            {
                return NotFound();
            }

            string selectedDates = "";

            for (DateTime day = Convert.ToDateTime(checkInDate); day <= checkOutDate; day = day.AddDays(1))
            {
                selectedDates += "<" + day.ToShortDateString() + ">";
            }

            string orderId = "";

            IEnumerable<Order> orders = await _dbContext.Orders.Include(x=>x.Room).Where(x=>x.RoomId==id).ToListAsync();

            foreach (var order in orders)
            {
                for (DateTime orderDay = order.StartDate.Date; orderDay <= order.EndDate.Date; orderDay = orderDay.AddDays(1))
                {
                    if (selectedDates.Contains("<" + orderDay.ToShortDateString() + ">"))
                    {
                        orderId += "/" + order.ID + "/";
                    }
                }
            }

           

            Room roomFromDb = await _dbContext.Rooms.FindAsync(id);
            TimeSpan timeSpan = checkOutDate - checkInDate;
            int dayCount =Convert.ToInt32(timeSpan.TotalDays);
            decimal price = roomFromDb.Price / 30 * dayCount * personCount;

            Room room = new Room();

            if (orderId == "")
            {
                room.Price = price;
                room.IsReserved = false;
            }
            else
            {
                room.Price = 0;
                room.IsReserved = true;
            }
            return PartialView("_GetPricePartialView", room);
        }
    }
}