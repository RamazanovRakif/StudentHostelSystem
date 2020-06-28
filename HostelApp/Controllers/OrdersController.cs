using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using HostelApp.DAL;
using HostelApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HostelApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<AppUser> _userManager;
        public OrdersController(AppDbContext dbContext, UserManager<AppUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(string startDate, string endDate, int? count, int? roomId)
        {
            if (startDate == null || endDate == null || count == null || roomId == null)
            {
                return RedirectToAction("Error", "Home");
            }
           
           
            Room room = await _dbContext.Rooms.FindAsync(roomId);

            var user = await _dbContext.Users.SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);

            if (user == null)
            {
                return RedirectToAction("Login", "Account");
            }

            Order order = new Order
            {
                RoomId = Convert.ToInt32(roomId),
                AppUserId = user.Id,
                StartDate = DateTime.ParseExact(startDate, "M/d/yyyy", CultureInfo.InvariantCulture),
                EndDate = DateTime.ParseExact(endDate, "M/d/yyyy", CultureInfo.InvariantCulture),
                IsReserved = true,
                FreeBedCount = 0
            };

            await _dbContext.Orders.AddAsync(order);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}