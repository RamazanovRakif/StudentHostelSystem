using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HostelApp.DAL;
using HostelApp.Extensions;
using HostelApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using static HostelApp.Extensions.IFormFileExtension;

namespace HostelApp.Areas.HostelAdmin.Controllers
{
    [Area("HostelAdmin")]
    public class RoomImagesController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IHostingEnvironment _env;

        public RoomImagesController(AppDbContext dbContext, IHostingEnvironment env)
        {
            _dbContext = dbContext;
            _env = env;
        }


        public async Task<IActionResult> Index(int? id)
        {
            if (id == null)
                return NotFound();

            IEnumerable<RoomImage> roomImages = await _dbContext.RoomImages.Include(x => x.Room).Where(x => x.Room.ID == id).ToListAsync();

            if (roomImages == null)
                return NotFound();
            ViewBag.RoomId = id;

            return View(roomImages);
        }

        public IActionResult Create(int? id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, RoomImage roomImages)
        {
            if (id == null)
                return NotFound();
            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!roomImages.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "File type is not valid!!!");
                return View();
            }

            string fileName = await roomImages.Photo.SaveAsync(_env.WebRootPath, "images", "room");


            RoomImage images = new RoomImage
            {
                RoomId = id,
                Image = fileName
            };

            await _dbContext.RoomImages.AddAsync(images);
            await _dbContext.SaveChangesAsync();


            return Redirect("/HostelAdmin/RoomImages/Index/" + id.ToString());
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            RoomImage roomImages = await _dbContext.RoomImages.FindAsync(id);

            if (roomImages == null)
                return NotFound();

            return View(roomImages);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, RoomImage roomImages)
        {
            if (!ModelState.IsValid)
            {
                return View(roomImages);
            }

            if (id == null)
            {
                return NotFound();
            }

            RoomImage roomImagesFromDb = await _dbContext.RoomImages.Where(x => x.ID == id).Include(x => x.Room).FirstOrDefaultAsync();

            int roomId = roomImagesFromDb.Room.ID;

            if (roomImages.Photo != null)
            {
                if (!roomImages.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "File type is not valid!!!");
                    return View(roomImages);
                }

                RemoveFile(_env.WebRootPath, "images", "room", roomImagesFromDb.Image);

                string fileName = await roomImages.Photo.SaveAsync(_env.WebRootPath, "images", "room");
                roomImagesFromDb.Image = fileName;
            }

            await _dbContext.SaveChangesAsync();
            return Redirect("/HostelAdmin/RoomImages/Index/" + roomId.ToString());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id)
        {

            if (id == null)
                return NotFound();
            RoomImage roomImages = await _dbContext.RoomImages.Where(x=>x.ID==id).Include(x=>x.Room).FirstOrDefaultAsync();

            if (roomImages == null)
                return NotFound();

            int roomId = roomImages.Room.ID;

            RemoveFile(_env.WebRootPath, "images", "room", roomImages.Image);

            _dbContext.RoomImages.Remove(roomImages);
            _dbContext.SaveChanges();

            return Redirect("/HostelAdmin/RoomImages/Index/" + roomId.ToString());

        }
    }
}