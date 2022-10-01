using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyalHalls1.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace RoyalHalls1.Controllers
{
    public class AccountController : Controller
    {
        private readonly ModelContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AccountController(ModelContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Id,Fname,Lname,Username,Email,Userpassword,ImageFile,RoleId")] User user, string pass)
        {
            if (ModelState.IsValid)
            {
                if (user.ImageFile != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName = Guid.NewGuid().ToString() + "_" + user.ImageFile.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName); // wwwroot/image/filename

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await user.ImageFile.CopyToAsync(fileStream);
                    }
                    user.Photo = fileName;


                }
                user.RoleId = 6;

                if (await IsUserExist(user.Username))
                {

                    ModelState.AddModelError(String.Empty, "username is already in use");
                    return View();

                }

                if (await IsEmailExist(user.Email))
                {

                    ModelState.AddModelError(String.Empty, "Email is already in use");
                    return View();
                }
                if (user.Userpassword != pass)
                {
                    ModelState.AddModelError(String.Empty, "Password and Confirmation are not the same");
                    return View();

                }





                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View(user);
        }

        private async Task<bool> IsUserExist(string username)
        {
            return await _context.Users.AnyAsync(x => x.Username == username);
        }

        private async Task<bool> IsEmailExist(string email)
        {
            return await _context.Users.AnyAsync(x => x.Email == email);
        }



        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(string name, string pass)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == name && x.Userpassword == pass);
            if (user == null)
            {
                ModelState.AddModelError(String.Empty, "username or password incorrect");
            }

            else
            {
                switch (user.RoleId)
                {
                    case 5:
                        HttpContext.Session.SetInt32("AdminId", (int)user.Id);
                        return RedirectToAction("Dashboard", "Admin");


                    case 6:
                        HttpContext.Session.SetInt32("ClientId", (int)user.Id);
                        return RedirectToAction("Index", "Home");
                }

            }

            return View();
        }


    }
}
