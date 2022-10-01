using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyalHalls1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RoyalHalls1.Controllers
{
    public class AdminController : Controller
    {
        private readonly ModelContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AdminController(ModelContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Dashboard()
        {

            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }


            ViewBag.NumOfUsers = _context.Users.Where(x => x.RoleId == 6).Count();
            var bookedHalls = _context.Reservations.Where(x => x.Status == "Approved").Select(x => x.HallsId);
            var numofbookedHalls = bookedHalls.Distinct().Count();



            ViewBag.NumOfBooked = numofbookedHalls;
            var NumOfHalls = _context.Halls.Count();
            ViewBag.NumOfNonBookedHalls = NumOfHalls - numofbookedHalls;

            var userDetails = _context.Users.Where(x => x.RoleId == 6);



            return View(userDetails);
        }

        public IActionResult AdminProfile()
        {

            var admin_id = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == admin_id);


            if (admin_id == null)
            {
                return RedirectToAction("Login", "Account");
            }
            var adminProfile = _context.Users.SingleOrDefault(x => x.Id == admin_id);
            return View(adminProfile);

        }
        [HttpPost]
        public async Task<IActionResult> AdminProfile([Bind("Id,Fname,Lname,Username,Email,Userpassword,ImageFile")] User user)
        {
            var admin_id = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = await _context.Users.AsNoTracking().SingleOrDefaultAsync(x => x.Id == admin_id);


            if (admin_id == null)
            {
                RedirectToAction("Login", "Account");
            }

            if (admin_id != user.Id)
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
                    var data = await _context.Users.AsNoTracking().Where(x => x.Id == user.Id).FirstOrDefaultAsync();
                    string PersonalImagePath = data.Photo;
                    user.Photo = PersonalImagePath;
                }

                try
                {
                    user.RoleId = 5;
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
                return RedirectToAction(nameof(AdminProfile));
            }
            return View(user);
        }

        private bool UserExists(decimal id)
        {
            return _context.Users.Any(e => e.Id == id);
        }



        //magange halls (CRUD)

        public async Task<IActionResult> HallIndex()
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            return View(await _context.Halls.ToListAsync());
        }


        // GET: Halls/Details/5
        public async Task<IActionResult> HallDetails(decimal? id)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            if (id == null)
            {
                return NotFound();
            }

            var hall = await _context.Halls
                .FirstOrDefaultAsync(m => m.HId == id);
            if (hall == null)
            {
                return NotFound();
            }

            return View(hall);
        }

        // GET: Halls/Create


        public IActionResult HallCreate()
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            return View();
        }

        // POST: Halls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HallCreate([Bind("HId,HName,HDescription,HAddress,HPrice,HImageFile")] Hall hall)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            if (ModelState.IsValid)
            {
                if (hall.HImageFile != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName = Guid.NewGuid().ToString() + "_" + hall.HImageFile.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName); // wwwroot/image/filename

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await hall.HImageFile.CopyToAsync(fileStream);
                    }
                    hall.HPhoto = fileName;

                }
                _context.Add(hall);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(HallIndex));
            }
            return View(hall);
        }

        // GET: Halls/Edit/5
        public async Task<IActionResult> HallEdit(decimal? id)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }


            if (id == null)
            {
                return NotFound();
            }

            var hall = await _context.Halls.Where(x => x.HId == id).SingleOrDefaultAsync();
            if (hall == null)
            {
                return NotFound();
            }
            return View(hall);
        }

        // POST: Halls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> HallEdit(decimal id, [Bind("HId,HName,HDescription,HAddress,HPrice,,HImageFile")] Hall hall)
        {


            if (id != hall.HId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (hall.HImageFile != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName = Guid.NewGuid().ToString() + "_" + hall.HImageFile.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName); // wwwroot/image/filename

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await hall.HImageFile.CopyToAsync(fileStream);
                    }
                    hall.HPhoto = fileName;

                }

                else

                {
                    var data = _context.Halls.AsNoTracking().Where(x => x.HId == hall.HId).FirstOrDefault();
                    string PersonalImagePath = data.HPhoto;
                    hall.HPhoto = PersonalImagePath;
                }


                try
                {
                    _context.Update(hall);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HallExists(hall.HId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(HallIndex));
            }
            return View(hall);
        }

        // GET: Halls/Delete/5
        public async Task<IActionResult> HallDelete(decimal? id)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            if (id == null)
            {
                return NotFound();
            }

            var hall = await _context.Halls
                .FirstOrDefaultAsync(m => m.HId == id);
            if (hall == null)
            {
                return NotFound();
            }

            return View(hall);
        }

        // POST: Halls/Delete/5
        [HttpPost, ActionName("HallDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> HallDeleteConfirmed(decimal id)
        {
            var hall = await _context.Halls.FindAsync(id);
            _context.Halls.Remove(hall);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(HallIndex));
        }

        private bool HallExists(decimal id)
        {
            return _context.Halls.Any(e => e.HId == id);
        }


        public async Task<IActionResult> Report()
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }



            var modelContext = await _context.Reservations.Include(r => r.Halls).Include(r => r.Users).Where(x => x.Status != "pending").ToArrayAsync();
            var resUsers = _context.Reservations.Include(r => r.Halls).Include(r => r.Users).Where(x => x.Status == "Approved" || x.Status == "ends").Select(x => x.UsersId).Distinct().Count();
            var profit = _context.Reservations.Include(r => r.Halls).Include(r => r.Users).Where(x => x.Status == "Approved" || x.Status == "ends").Sum(x => x.TotalPrice);
            var losses = _context.Reservations.Include(r => r.Halls).Include(r => r.Users).Where(x => x.Status == "rejected").Sum(x => x.TotalPrice);
            ViewBag.numUrese = resUsers;
            ViewBag.totalPres = profit;
            ViewBag.totalLres = losses;

            var allRes = await _context.Reservations.ToListAsync();
            var years = allRes.OrderBy(x => x.Datefrom.Value.Year).Select(x => x.Datefrom.Value.Year).Distinct();

            var num = new List<int>();

            foreach (var item in years)
            {
                num.Add(allRes.Where(x => (x.Status == "Approved" || x.Status == "ends") && x.Datefrom.Value.Year == item).Count());
            }



            ViewBag.num = num;
            ViewBag.year = years;


            return View(modelContext);

        }
        [HttpPost]
        public async Task<IActionResult> Report(int? year, int? month)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            var allRes = await _context.Reservations.ToListAsync();
            var years = allRes.OrderBy(x => x.Datefrom.Value.Year).Select(x => x.Datefrom.Value.Year).Distinct();

            var num = new List<int>();

            foreach (var item in years)
            {
                num.Add(allRes.Where(x => (x.Status == "Approved" || x.Status == "ends") && x.Datefrom.Value.Year == item).Count());
            }
            ViewBag.num = num;
            ViewBag.year = years;




            var modelContext = await _context.Reservations.Include(r => r.Halls).Include(r => r.Users).Where(x => x.Status != "pending").ToArrayAsync();



            ViewBag.numUrese = modelContext.Where(x => x.Status == "Approved" || x.Status == "ends").Select(x => x.UsersId).Distinct().Count();
            ViewBag.totalPres = modelContext.Where(x => x.Status == "Approved" || x.Status == "ends").Sum(x => x.TotalPrice);
            ViewBag.totalLres = modelContext.Where(x => x.Status == "rejected").Sum(x => x.TotalPrice);

            if (year == null && month == null)
                return View(modelContext);


            else if (month == null && year != null)
            {


                var res = modelContext.Where(x => x.Datefrom.Value.Year == year || x.Dateto.Value.Year == year);

                ViewBag.numUrese = res.Where(x => x.Status == "Approved" || x.Status == "ends").Select(x => x.UsersId).Distinct().Count();
                ViewBag.totalPres = res.Where(x => x.Status == "Approved" || x.Status == "ends").Sum(x => x.TotalPrice);
                ViewBag.totalLres = res.Where(x => x.Status == "rejected").Sum(x => x.TotalPrice);

                years = res.OrderBy(x => x.Datefrom.Value.Year).Select(x => x.Datefrom.Value.Year).Distinct();

                num = new List<int>();

                foreach (var item in years)
                {
                    num.Add(allRes.Where(x => (x.Status == "Approved" || x.Status == "ends") && x.Datefrom.Value.Year == item).Count());
                }
                ViewBag.num = num;
                ViewBag.year = years;


                return View(res);

            }
            else if (month != null && year == null)
            {
                var res = modelContext.Where(x => x.Datefrom.Value.Month == month || x.Dateto.Value.Month == month);
                ViewBag.numUrese = res.Where(x => x.Status == "Approved" || x.Status == "ends").Select(x => x.UsersId).Distinct().Count();
                ViewBag.totalPres = res.Where(x => x.Status == "Approved" || x.Status == "ends").Sum(x => x.TotalPrice);
                ViewBag.totalLres = res.Where(x => x.Status == "rejected").Sum(x => x.TotalPrice);

                years = res.OrderBy(x => x.Datefrom.Value.Year).Select(x => x.Datefrom.Value.Year).Distinct();

                num = new List<int>();

                foreach (var item in years)
                {
                    num.Add(allRes.Where(x => (x.Status == "Approved" || x.Status == "ends") && x.Datefrom.Value.Year == item).Count());
                }
                ViewBag.num = num;
                ViewBag.year = years;


                return View(res);

            }
            else
            {
                var res = modelContext.Where(x => (x.Datefrom.Value.Month == month || x.Dateto.Value.Month == month) && (x.Datefrom.Value.Year == year || x.Dateto.Value.Year == year));
                ViewBag.numUrese = res.Where(x => x.Status == "Approved" || x.Status == "ends").Select(x => x.UsersId).Distinct().Count();
                ViewBag.totalPres = res.Where(x => x.Status == "Approved" || x.Status == "ends").Sum(x => x.TotalPrice);
                ViewBag.totalLres = res.Where(x => x.Status == "rejected").Sum(x => x.TotalPrice);

                years = res.OrderBy(x => x.Datefrom.Value.Year).Select(x => x.Datefrom.Value.Year).Distinct();

                num = new List<int>();

                foreach (var item in years)
                {
                    num.Add(allRes.Where(x => (x.Status == "Approved" || x.Status == "ends") && x.Datefrom.Value.Year == item).Count());
                }
                ViewBag.num = num;
                ViewBag.year = years;

                return View(res);

            }

        }

        public IActionResult logout()
        {

            HttpContext.Session.Remove("AdminId");
            return RedirectToAction("Login", "Account");


        }





    }
}
