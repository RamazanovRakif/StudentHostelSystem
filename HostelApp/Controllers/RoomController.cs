using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApp.DAL;
using HostelApp.Models;
using HostelApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HostelApp.Controllers
{
    public class RoomController : Controller
    {
        private readonly AppDbContext _dbContext;
        public RoomController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<IActionResult> Index(DateTime? startDate, DateTime? endDate, int? count)
        {
            if (startDate == null || endDate == null || count == null)
            {
                return RedirectToAction("Error", "Home");
            }

            RoomVM roomVM = new RoomVM();

            string selectedDates = "";

            for (DateTime day = Convert.ToDateTime(startDate); day <= endDate; day = day.AddDays(1))
            {
                selectedDates += "<" + day.ToShortDateString() + ">";
            }

            string orderId = "";
            IEnumerable<Order> orders = await _dbContext.Orders.ToListAsync();

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

            IEnumerable<Room> rooms = from room in _dbContext.Rooms
                                      join category in _dbContext.Categories
                                      on room.CategoryId equals category.Id
                                      join order in _dbContext.Orders
                                      on room.ID equals order.RoomId
                                      join roomImage in _dbContext.RoomImages
                                      on room.ID equals roomImage.RoomId
                                      where (orderId.Contains("/" + order.ID.ToString() + "/"))
                                      select new Room
                                      {
                                          ID = room.ID
                                      };

            string roomId = "";

            foreach (var room in rooms)
            {
                roomId += "/" + room.ID + "/";
            }

            roomVM.Rooms = await _dbContext.Rooms
                .Include(x => x.RoomImages)
                    .Include(x => x.Category)
                        .Where(x => !roomId.Contains("/" + x.ID.ToString() + "/")).ToListAsync();

            return View(roomVM);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Error", "Home");
            }

            Room room = await _dbContext.Rooms.Where(x => x.ID == id).Include(x => x.Category).Include(x => x.RoomImages).FirstOrDefaultAsync();
            if (room == null)
                return RedirectToAction("Error", "Home");

            return View(room);
        }

        public async Task<IActionResult> AllRooms()
        {
            IEnumerable<Room> Rooms = await _dbContext.Rooms
                                                        .Include(x=>x.RoomImages)
                                                            .Include(x=>x.Category).ToListAsync();
            return View(Rooms);
        }
    }
}