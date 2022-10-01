using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using RoyalHalls1.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RoyalHalls1.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly ModelContext _context;

        public ReservationsController(ModelContext context)
        {
            _context = context;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            var penRes = await _context.Reservations.Where(x => x.Status == "pending").ToListAsync();

            if (penRes != null)
            {
                foreach (var item in penRes)
                {

                    if (item.Datefrom.Value.Date < DateTime.Today.Date)
                    {
                        item.Status = "Missed";
                        _context.Update(item);
                    }

                }

                _context.SaveChanges();

            }





            var modelContext = _context.Reservations.Include(r => r.Halls).Include(r => r.Users).OrderByDescending(x => x.Id);
            return View(await modelContext.ToListAsync());
        }


        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(decimal? id)
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

            var reservation = await _context.Reservations
                .Include(r => r.Halls)
                .Include(r => r.Users)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }




        public async Task<IActionResult> Approved(decimal id)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }




            if (!ReservationExists(id))
            {
                return NotFound("there is no reservation");
            }

            var reservation = await _context.Reservations.FindAsync(id);
            var hall = await _context.Halls.SingleOrDefaultAsync(x => x.HId == reservation.HallsId);
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Id == reservation.UsersId);
            ViewBag.hall = hall;
            ViewBag.user = user;

            return View(reservation);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Approved(decimal? id)
        {

            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }





            var reservation = await _context.Reservations.FindAsync(id);
            var clientid = reservation.UsersId;
            var visa = await _context.Payments.Where(x => x.UserId == clientid).SingleOrDefaultAsync();

            if (visa.Ballance < reservation.TotalPrice)
            {
                ModelState.AddModelError(String.Empty, "there is no enough ballance in users Visa card");
                return RedirectToAction(nameof(Index));

            }


            visa.Ballance -= reservation.TotalPrice;
            reservation.Status = "Approved";
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();

            var userInfo = await _context.Users.Where(x => x.Id == clientid).SingleOrDefaultAsync();




            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("Royal Halls", "obadaallan2000@outlook.com");
            message.From.Add(from);
            MailboxAddress to = new MailboxAddress(userInfo.Username, userInfo.Email);
            message.To.Add(to);
            message.Subject = "Royal Halls";
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody =
            "<p style=\"color:wihite\">Hello sir, your reservation request has been accepted. Hope you have a good time </p>" + "Regards";
            message.Body = bodyBuilder.ToMessageBody();
            using (var clinte = new SmtpClient())
            {
                clinte.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
                clinte.Authenticate("obadaallan2000@outlook.com", "nhgfrrcqrmtrlycf");

                clinte.Send(message);
                clinte.Disconnect(true);

            }





            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Reject(decimal id)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }



            if (!ReservationExists(id))
            {
                return NotFound("there is no reservation");
            }

            var reservation = await _context.Reservations.FindAsync(id);
            var hall = await _context.Halls.SingleOrDefaultAsync(x => x.HId == reservation.HallsId);
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Id == reservation.UsersId);
            ViewBag.hall = hall;
            ViewBag.user = user;

            return View(reservation);
        }



        // POST: Reservations/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reject(decimal? id)
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            var reservation = await _context.Reservations.FindAsync(id);
            reservation.Status = "rejected";
            var clientid = reservation.UsersId;
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();


            var userInfo = await _context.Users.Where(x => x.Id == clientid).SingleOrDefaultAsync();

            MimeMessage message = new MimeMessage();
            MailboxAddress from = new MailboxAddress("Royal Halls", "obadaallan2000@outlook.com");
            message.From.Add(from);
            MailboxAddress to = new MailboxAddress(userInfo.Username, userInfo.Email);
            message.To.Add(to);
            message.Subject = "Royal Halls";
            BodyBuilder bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody =
            "<p style=\"color:wihite\">Hello sir, Unfortunately we are sorry to inform you that your reservation request has been rejected </p>" + "Regards";
            message.Body = bodyBuilder.ToMessageBody();
            using (var clinte = new SmtpClient())
            {
                clinte.Connect("smtp-mail.outlook.com", 587, SecureSocketOptions.StartTls);
                clinte.Authenticate("obadaallan2000@outlook.com", "nhgfrrcqrmtrlycf");

                clinte.Send(message);
                clinte.Disconnect(true);

            }



            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(decimal id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Serach()
        {
            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }


            var modelContext = _context.Reservations.Include(r => r.Halls).Include(r => r.Users);
            return View(await modelContext.ToListAsync());
        }


        [HttpPost]
        public async Task<IActionResult> Serach(DateTime? startDate, DateTime? endDate)
        {

            var Adminid = HttpContext.Session.GetInt32("AdminId");
            ViewBag.adminProfile = _context.Users.SingleOrDefault(x => x.Id == Adminid);


            if (Adminid == null)
            {

                return RedirectToAction("Login", "Account");
            }

            var modelContext = _context.Reservations.Include(r => r.Halls).Include(r => r.Users);
            if (startDate == null && endDate == null)
                return View(modelContext);
            else if (startDate == null && endDate != null)
            {
                var result = await modelContext.Where(x => x.Dateto.Value.Date == endDate).ToListAsync();
                return View(result);

            }
            else if (startDate != null && endDate == null)
            {
                var result = await modelContext.Where(x => x.Datefrom.Value.Date == startDate).ToListAsync();
                return View(result);
            }
            else
            {
                var result = await modelContext.Where(x => x.Datefrom.Value.Date >= startDate && x.Dateto.Value.Date <= endDate).ToListAsync();
                return View(result);
            }


        }


    }
}
