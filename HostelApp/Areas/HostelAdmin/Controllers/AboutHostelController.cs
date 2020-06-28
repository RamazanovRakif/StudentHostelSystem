using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HostelApp.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace HostelApp.Areas.HostelAdmin.Controllers
{

    public class AboutHostelController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IHostingEnvironment _env;

        public AboutHostelController(AppDbContext dbContext, IHostingEnvironment env)
        {
            _dbContext = dbContext;
            _env = env;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}