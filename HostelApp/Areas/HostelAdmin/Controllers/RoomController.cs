using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HostelApp.DAL;
using HostelApp.Models;
using HostelApp.Areas.HostelAdmin.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HostelApp.Areas.HostelAdmin.Controllers
{
    [Area("HostelAdmin")]
    public class RoomController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IHostingEnvironment _env;

        public RoomController(AppDbContext dbContext, IHostingEnvironment env)
        {
            _dbContext = dbContext;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Room> rooms = await _dbContext.Rooms.Include(x => x.Category).Include(x => x.RoomImages).ToListAsync();
            return View(rooms);
        }

        public async Task<IActionResult> Create()
        {
            RoomVM roomVM = new RoomVM
            {
                Categories = await _dbContext.Categories.ToListAsync()
            };

            return View(roomVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(RoomVM roomVM)
        {
           
            if (!ModelState.IsValid)
            {
                roomVM.Categories = await _dbContext.Categories.ToListAsync();
                return View(roomVM.Categories);
            }

            Room room = new Room
            {
                RoomNumber = roomVM.Room.RoomNumber,
                CategoryId = roomVM.SelectedCategory,
                BedCount = roomVM.Room.BedCount,
                Breakfast = roomVM.Room.Breakfast,
                Description = roomVM.Room.Description,
                IsReserved = roomVM.Room.IsReserved,
                Price = roomVM.Room.Price,
                WiFi = roomVM.Room.WiFi
            };

            await _dbContext.AddAsync(room);

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            Room room = await _dbContext.Rooms.Where(x => x.ID == id).Include(x => x.Category).Include(x => x.RoomImages).FirstOrDefaultAsync();
            if (room == null)
                return NotFound();

            return View(room);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            RoomVM roomVM = new RoomVM
            {
                Room = await _dbContext.Rooms.Where(x => x.ID == id).Include(x => x.Category).Include(x => x.RoomImages).FirstOrDefaultAsync(),
                Categories = await _dbContext.Categories.ToListAsync()
            };

            if (roomVM == null)
                return NotFound();

            return View(roomVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, RoomVM roomVM)
        {
            IEnumerable<Category> categories = await _dbContext.Categories.ToListAsync();

            if (id == null)
            {
                roomVM.Categories = categories;
            }

            if (!ModelState.IsValid)
            {
                roomVM.Categories = categories;
            }

            Room room = await _dbContext.Rooms.FindAsync(id);

            room.RoomNumber = roomVM.Room.RoomNumber;
            room.Price = roomVM.Room.Price;
            room.IsReserved = roomVM.Room.IsReserved;
            room.CategoryId = roomVM.SelectedCategory;
            room.Description = roomVM.Room.Description;
            room.Breakfast = roomVM.Room.Breakfast;
            room.WiFi = roomVM.Room.WiFi;
            room.BedCount = roomVM.Room.BedCount;

            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            Room room = await _dbContext.Rooms.FindAsync(id);
            if (room == null)
                return NotFound();

            _dbContext.Rooms.Remove(room);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}