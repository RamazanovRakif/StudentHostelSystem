using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using HostelApp.DAL;
using HostelApp.Models;
using HostelApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using static HostelApp.Extensions.IFormFileExtension;

namespace HostelApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _dbContext;
        private readonly IHostingEnvironment _env;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(AppDbContext dbContext, IHostingEnvironment env, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _dbContext = dbContext;
            _env = env;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Register()
        {
            RegisterVM registerVM = new RegisterVM
            {
                Universities = await _dbContext.Universities.ToListAsync(),
                Faculties = await _dbContext.Faculties.ToListAsync(),
                Groups = await _dbContext.Groups.ToListAsync()
            };
            return View(registerVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                registerVM.Universities = await _dbContext.Universities.ToListAsync();
                registerVM.Faculties = await _dbContext.Faculties.ToListAsync();
                registerVM.Groups = await _dbContext.Groups.ToListAsync();
                return View(registerVM);
            }

            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                registerVM.Universities = await _dbContext.Universities.ToListAsync();
                registerVM.Faculties = await _dbContext.Faculties.ToListAsync();
                registerVM.Groups = await _dbContext.Groups.ToListAsync();
                return View(registerVM);
            }

            if (!registerVM.Photo.IsImage())
            {
                ModelState.AddModelError("Photo", "File type is not valid!!!");
                registerVM.Universities = await _dbContext.Universities.ToListAsync();
                registerVM.Faculties = await _dbContext.Faculties.ToListAsync();
                registerVM.Groups = await _dbContext.Groups.ToListAsync();
                return View(registerVM);
            }

            AppUser appUser = new AppUser();
            appUser.Email = registerVM.Email;
            appUser.Name = registerVM.Name;
            appUser.Surname = registerVM.Surname;
            appUser.FatherName = registerVM.FatherName;
            appUser.GroupId = registerVM.SelectedGroup;
            appUser.IDCardNumber = registerVM.IDCardNumber;
            appUser.StudentTicketNumber = registerVM.StudentTicketNumber;
            appUser.UserName = registerVM.Email;

            IdentityResult result = await _userManager.CreateAsync(appUser, registerVM.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                registerVM.Universities = await _dbContext.Universities.ToListAsync();
                registerVM.Faculties = await _dbContext.Faculties.ToListAsync();
                registerVM.Groups = await _dbContext.Groups.ToListAsync();
                return View(registerVM);
            }

            await _userManager.AddToRoleAsync(appUser, "User");
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            var user = await _userManager.FindByEmailAsync(loginVM.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Email or password is wrong");
                return View(loginVM);
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, loginVM.RememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email or password is wrong");
                return View(loginVM);
            }

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [Authorize]
        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordVM changePassword)
        {
            if (!ModelState.IsValid)
            {
                return View(changePassword);
            }

            var user = await _dbContext.Users.SingleOrDefaultAsync(x => _userManager.FindByNameAsync(User.Identity.Name).GetAwaiter().GetResult().Id == x.Id);
            var email = user.Email;

            IdentityResult result = await _userManager.ChangePasswordAsync(user, changePassword.OldPassword, changePassword.Password);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Old password is wrong!!");
                return View(changePassword);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}