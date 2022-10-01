using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RoyalHalls1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RoyalHalls1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ModelContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ModelContext context, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _context = context;
            _webHostEnvironment = webHostEnvironment;


        }

        public IActionResult Index()
        {

            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;


            var home = _context.Homes.SingleOrDefault();
            var halls = _context.Halls.OrderByDescending(x => x.HId).Take(3);
            var testimonials = _context.Testimonials.Include(x => x.User).OrderByDescending(x => x.Id).ToList().Take(3);
            var about = _context.Abouts.SingleOrDefault();




            var model = Tuple.Create<Home, About, IEnumerable<Hall>, IEnumerable<Testimonial>>(home, about, halls, testimonials);


            return View(model);
        }


        public IActionResult Logout()
        {

            HttpContext.Session.Remove("ClientId");
            return RedirectToAction("Index", "Home");


        }


        public IActionResult About()
        {
            return View();
        }
        public IActionResult Halls()
        {
            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();



            var halls = _context.Halls;


            return View(halls);
        }

        [HttpPost]
        public async Task<IActionResult> HallSearch(string search)
        {


            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = await _context.Homes.SingleOrDefaultAsync();
            var halls = await _context.Halls.ToListAsync();

            if (search == null)
            {
                return View(halls);
            }


            else if (search != null)
            {
                halls = await _context.Halls.Where(x => x.HName.Contains(search) || x.HAddress.Contains(search)).ToListAsync();

                return View(halls);

            }
            return View(halls);

        }



        [HttpPost]
        public async Task<IActionResult> Contact(string name, string email, string phone, string text)
        {

            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            var contact = new Contact
            {
                Name = name,
                Email = email,
                Phone = phone,
                Messeages = text

            };

            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Edit_Profile()
        {

            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }

            var userProfile = _context.Users.SingleOrDefault(x => x.Id == Client);
            return View(userProfile);



        }

        [HttpPost]

        public async Task<IActionResult> Edit_Profile([Bind("Id,Fname,Lname,Username,Email,Userpassword,ImageFile")] User user)
        {

            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }


            if (Client != user.Id)
            {
                return NotFound();
            }


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
                else
                {
                    var data = _context.Users.AsNoTracking().Where(x => x.Id == user.Id).FirstOrDefault();
                    string PersonalImagePath = data.Photo;
                    user.Photo = PersonalImagePath;
                }

                try
                {
                    user.RoleId = 6;
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }

                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Edit_Profile));
            }
            return View(user);


        }

        public IActionResult Rate()
        {
            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }


            var rate = _context.Testimonials.Where(x => x.UserId == Client).SingleOrDefault();

            return View(rate);


        }

        [HttpPost]
        public async Task<IActionResult> Rate([Bind("Id", "UserId", "Content")] Testimonial testi)
        {
            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }


            if (ModelState.IsValid)
            {
                testi.UserId = Client;
                _context.Testimonials.Add(testi);
                await _context.SaveChangesAsync();

            }
            return View(testi);





        }



        private bool UserExists(decimal id)
        {
            return _context.Users.Any(e => e.Id == id);
        }

        public IActionResult UserBooking(decimal id)
        {

            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();

            var res = _context.Reservations;
            var resInfo = res.Where(x => x.Status == "Approved").ToList();


            if (resInfo != null)
            {


                foreach (var item in resInfo)
                {
                    if (item.Dateto.Value.Date < System.DateTime.Today.Date)
                    {
                        item.Status = "ends";
                        _context.Update(item);


                    }

                }

                _context.SaveChanges();
            }




            ViewBag.hall = _context.Halls.Where(x => x.HId == id).SingleOrDefault();

            var hRes = _context.Reservations.Where(x => x.HallsId == id);
            ViewBag.hallRes = hRes.Where(x => x.Status == "Approved" || x.Status == "pending");

            return View();

        }


        [HttpPost]

        public async Task<IActionResult> UserBooking(int hallid, DateTime? start, DateTime? end)
        {


            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();

            var hRes = _context.Reservations.Where(x => x.HallsId == hallid);
            ViewBag.hallRes = hRes.Where(x => x.Status == "Approved" || x.Status == "pending");


            var hallinfo = await _context.Halls.Where(x => x.HId == hallid).SingleOrDefaultAsync();
            ViewBag.hall = hallinfo;
            var visaCheck = await _context.Payments.Where(x => x.UserId == Client).SingleOrDefaultAsync();
            var res = await _context.Reservations.Where(x => x.HallsId == hallid).ToListAsync();
            var resInfo = res.Where(x => x.Status == "Approved" || x.Status == "pending");

            var total_price = ((Math.Abs((end - start).Value.Days)) + 1) * hallinfo.HPrice;









            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }

            if (visaCheck == null)
            {
                return RedirectToAction("Index", "Payments");

            }


            if (visaCheck.Ballance < total_price)
            {


                ModelState.AddModelError(String.Empty, "your ballance is not enough for pay please update your visa ");
                return View();
            }





            if (start > end)
            {
                ModelState.AddModelError(String.Empty, "invalid date");
                return View();

            }
            if ((Math.Abs(end.Value.Day - start.Value.Day)) >= 30)
            {
                ModelState.AddModelError(String.Empty, "you make can't a reservation for more than one month ");
                return View();

            }

            if (start < System.DateTime.Today.Date)
            {
                ModelState.AddModelError(String.Empty, "please make sure to choose a future date for reservation");
                return View();

            }
            if (resInfo != null)
            {

                foreach (var item in resInfo)
                {
                    if (end >= item.Datefrom.Value.Date && start <= item.Dateto.Value.Date)
                    {
                        ModelState.AddModelError(String.Empty, "The hall is not free in this date");
                        return View();
                    }

                }


            }







            if (ModelState.IsValid)
            {

                var reservation = new Reservation
                {
                    UsersId = Client,
                    HallsId = hallid,
                    Status = "pending",
                    TotalPrice = total_price,
                    Datefrom = start,
                    Dateto = end
                };

                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(MyOrders));
            }

            return View();
        }

        public IActionResult MyOrders()
        {
            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }
            var userReervation = _context.Reservations.Where(x => x.UsersId == Client).Include(x => x.Users).Include(x => x.Halls).ToList().OrderByDescending(x => x.Id);

            return View(userReervation);
        }







    }
}
