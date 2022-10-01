using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RoyalHalls1.Models;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RoyalHalls1.Controllers
{
    public class AdminHomesController : Controller
    {
        private readonly ModelContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminHomesController(ModelContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;

        }

        // GET: Homes
        public async Task<IActionResult> Index()
        {


            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }




            return View(await _context.Homes.ToListAsync());
        }



        // GET: Homes/Create
        public IActionResult Create()
        {


            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }
            var homeTable = _context.Homes.ToList();




            return View();
        }

        // POST: Homes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LogoImageFile,Title,Titledesc,SliderImageFile1,SliderImageFile2,SliderImageFile3,GalImg1,GalImg2,GalImg3,GalImg4,Address,Phone,Email,Medialink1,Medialink2,Medialink3")] Home home)
        {

            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }



            if (ModelState.IsValid)
            {


                if (home.LogoImageFile != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName = Guid.NewGuid().ToString() + "_" + home.LogoImageFile.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName); // wwwroot/image/filename

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await home.LogoImageFile.CopyToAsync(fileStream);
                    }
                    home.LogoImage = fileName;


                }

                if (home.SliderImageFile1 != null)
                {
                    string wwwRootPath2 = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName2 = Guid.NewGuid().ToString() + "_" + home.SliderImageFile1.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path2 = Path.Combine(wwwRootPath2 + "/Image/", fileName2); // wwwroot/image/filename

                    using (FileStream fileStream = new FileStream(path2, FileMode.Create))
                    {
                        await home.SliderImageFile1.CopyToAsync(fileStream);
                    }
                    home.SImage1 = fileName2;


                }
                if (home.SliderImageFile2 != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName = Guid.NewGuid().ToString() + "_" + home.SliderImageFile2.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName); // wwwroot/image/filename

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await home.SliderImageFile2.CopyToAsync(fileStream);
                    }
                    home.SImage2 = fileName;


                }
                if (home.SliderImageFile3 != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName = Guid.NewGuid().ToString() + "_" + home.SliderImageFile3.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName); // wwwroot/image/filename

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await home.SliderImageFile3.CopyToAsync(fileStream);
                    }
                    home.SImage3 = fileName;


                }
                _context.Add(home);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));


            }


            return View(home);
        }

        // GET: Homes/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


                return RedirectToAction("Login", "Account");
            }



            if (id == null)
            {
                return NotFound();
            }

            var home = await _context.Homes.FindAsync(id);
            if (home == null)
            {
                return NotFound();
            }
            return View(home);
        }

        // POST: Homes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("Id,LogoImageFile,Title,Titledesc,SliderImageFile1,SliderImageFile2,SliderImageFile3,GalImg1,GalImg2,GalImg3,GalImg4,Address,Phone,Email,Medialink1,Medialink2,Medialink3")] Home home)
        {

            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            if (id != home.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                if (home.LogoImageFile != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName = Guid.NewGuid().ToString() + "_" + home.LogoImageFile.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName); // wwwroot/image/filename

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await home.LogoImageFile.CopyToAsync(fileStream);
                    }
                    home.LogoImage = fileName;


                }

                else

                {
                    var data = _context.Homes.AsNoTracking().Where(x => x.Id == home.Id).FirstOrDefault();
                    string PersonalImagePath = data.LogoImage;
                    home.LogoImage = PersonalImagePath;
                }



                if (home.SliderImageFile1 != null)
                {
                    string wwwRootPath2 = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName2 = Guid.NewGuid().ToString() + "_" + home.SliderImageFile1.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path2 = Path.Combine(wwwRootPath2 + "/Image/", fileName2); // wwwroot/image/filename

                    using (FileStream fileStream = new FileStream(path2, FileMode.Create))
                    {
                        await home.SliderImageFile1.CopyToAsync(fileStream);
                    }
                    home.SImage1 = fileName2;


                }
                else

                {
                    var data = _context.Homes.AsNoTracking().Where(x => x.Id == home.Id).FirstOrDefault();
                    string PersonalImagePath = data.SImage1;
                    home.SImage1 = PersonalImagePath;
                }





                if (home.SliderImageFile2 != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName = Guid.NewGuid().ToString() + "_" + home.SliderImageFile2.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName); // wwwroot/image/filename

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await home.SliderImageFile2.CopyToAsync(fileStream);
                    }
                    home.SImage2 = fileName;


                }
                else

                {
                    var data = _context.Homes.AsNoTracking().Where(x => x.Id == home.Id).FirstOrDefault();
                    string PersonalImagePath = data.SImage2;
                    home.SImage2 = PersonalImagePath;
                }

                if (home.SliderImageFile3 != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName = Guid.NewGuid().ToString() + "_" + home.SliderImageFile3.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName); // wwwroot/image/filename

                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        await home.SliderImageFile3.CopyToAsync(fileStream);
                    }
                    home.SImage3 = fileName;


                }
                else
                {
                    var data = _context.Homes.AsNoTracking().Where(x => x.Id == home.Id).FirstOrDefault();
                    string PersonalImagePath = data.SImage3;
                    home.SImage3 = PersonalImagePath;
                }


                try
                {
                    _context.Update(home);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeExists(home.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(home);
        }


        private bool HomeExists(decimal id)
        {

            return _context.Homes.Any(e => e.Id == id);
        }



        public async Task<IActionResult> Contact_index()
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }


            var contact = await _context.Contacts.ToListAsync();

            return View(contact);

        }


        public async Task<IActionResult> AbountUs_Index()
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }


            var about = await _context.Abouts.ToListAsync();

            return View(about);

        }

        public async Task<IActionResult> AboutUs_Edit(decimal? id)
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

            var about = await _context.Abouts.FindAsync(id);
            if (about == null)
            {
                return NotFound();
            }
            return View(about);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> AboutUs_Edit(decimal id, [Bind("Id", "Title", "Descriotion", "Aboutphoto")] About about)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }



            if (id != about.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (about.Aboutphoto != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath; // wwwroot 
                    string fileName = Guid.NewGuid().ToString() + "_" + about.Aboutphoto.FileName; // sffjhfbvjhbjskdnklnklnlk_picture 
                    string path = Path.Combine(wwwRootPath + "/Image/", fileName); // wwwroot/image/filename

                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await about.Aboutphoto.CopyToAsync(fileStream);
                    }
                    about.Photo = fileName;

                }
                else
                {
                    var data = _context.Abouts.AsNoTracking().Where(x => x.Id == about.Id).FirstOrDefault();
                    string PersonalImagePath = data.Photo;
                    about.Photo = PersonalImagePath;
                }




                _context.Update(about);
                await _context.SaveChangesAsync();


                return RedirectToAction(nameof(AbountUs_Index));
            }
            return View(about);
        }

        public async Task<IActionResult> Testimonial()
        {

            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }


            var testi = await _context.Testimonials.Include(x => x.User).OrderByDescending(x => x.Id).ToListAsync();


            return View(testi);
        }



        public async Task<IActionResult> TestimonialDelete(decimal? id)
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

            var user = await _context.Testimonials
                .Include(u => u.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("TestimonialDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            var testi = await _context.Testimonials.FindAsync(id);
            _context.Testimonials.Remove(testi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Testimonial));
        }




    }
}
