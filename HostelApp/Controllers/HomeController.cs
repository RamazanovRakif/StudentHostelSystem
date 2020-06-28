using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HostelApp.DAL;
using HostelApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HostelApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        public HomeController(AppDbContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _dbContext.Sliders.ToListAsync(),
                Rooms = await _dbContext.Rooms.Include(x => x.Category).Include(x => x.RoomImages).Take(3).ToListAsync(),
                Hostel = await _dbContext.Hostels.FirstOrDefaultAsync(),
                RoomImages = await _dbContext.RoomImages.Take(6).ToListAsync(),
                News = await _dbContext.News.Take(3).ToListAsync(),
                Facilties = await _dbContext.Facilties.Take(6).ToListAsync(),
                Partners = await _dbContext.Partners.ToListAsync()
            };
            return View(homeVM);
        }


        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Galery()
        {
            return View();
        }

        public IActionResult Error()
        {

            return View();
        }



        public async Task RolesAddedAction()
        {
            if (!await _roleManager.RoleExistsAsync("User"))
            {
                await _roleManager.CreateAsync(new IdentityRole("User"));
            }

            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }
        }
    }
}