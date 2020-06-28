using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HostelApp.DAL;
using HostelApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static HostelApp.Extensions.IFormFileExtension;

namespace HostelApp.Areas.HostelAdmin.Controllers
{
    [Area("HostelAdmin")]
    public class SlidersController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IHostingEnvironment _env;
        public SlidersController(AppDbContext dbContext, IHostingEnvironment env)
        {
            _dbContext = dbContext;
            _env = env;
        }

        public IActionResult Index()
        {
            List<Slider> sliders = _dbContext.Sliders.ToList();
            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!slider.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "File type is not valid!!!");
                return View();
            }

            string fileName = await slider.Photo.SaveAsync(_env.WebRootPath, "images", "slider");
            slider.Image = fileName;

            await _dbContext.Sliders.AddAsync(slider);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();

            Slider slider = _dbContext.Sliders.Find(id);

            if (slider == null)
                return NotFound();

            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Slider slider)
        {
            if (!ModelState.IsValid)
            {
                return View(slider);
            }

            if (id == null)
            {
                return NotFound();
            }

            Slider sliderFromDb = await _dbContext.Sliders.FindAsync(id);

            if (slider.Photo != null)
            {
                if (!slider.Photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photo", "File type is not valid!!!");
                    return View(slider);
                }

                RemoveFile(_env.WebRootPath, "images", "slider", sliderFromDb.Image);

                string fileName = await slider.Photo.SaveAsync(_env.WebRootPath, "images", "slider");
                sliderFromDb.Image = fileName;
            }
            sliderFromDb.Title = slider.Title;
            sliderFromDb.Content = slider.Content;
            await _dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();

            Slider slider = _dbContext.Sliders.Find(id);

            if (slider == null)
                return NotFound();

            return View(slider);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null)
                return NotFound();
            Slider slider = await _dbContext.Sliders.FindAsync(id);

            if (slider == null)
                return NotFound();


            RemoveFile(_env.WebRootPath, "images", "slider", slider.Image);

            _dbContext.Sliders.Remove(slider);
            _dbContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}