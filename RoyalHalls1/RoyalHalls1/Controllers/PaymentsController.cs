using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RoyalHalls1.Models;
using System.Linq;
using System.Threading.Tasks;

namespace RoyalHalls1.Controllers
{
    public class PaymentsController : Controller
    {
        private readonly ModelContext _context;

        public PaymentsController(ModelContext context)
        {
            _context = context;
        }

        // GET: Payments
        public async Task<IActionResult> Index()
        {
            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }


            var modelContext = _context.Payments.Include(p => p.User).Where(x => x.UserId == Client).SingleOrDefaultAsync();
            return View(await modelContext);
        }

        // GET: Payments/Details/5


        // GET: Payments/Create
        public IActionResult Create()
        {

            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }

            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Email");
            return View();
        }

        // POST: Payments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,CardName,Cvv,ExpirationDate,Ballance")] Payment payment)
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
                payment.UserId = Client;
                _context.Add(payment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(payment);
        }

        // GET: Payments/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }

            if (id == null)
            {
                return NotFound();
            }

            var payment = await _context.Payments.FindAsync(id);
            if (payment == null)
            {
                return NotFound();
            }
            return View(payment);
        }

        // POST: Payments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("Id,UserId,CardName,Cvv,ExpirationDate,Ballance")] Payment payment)
        {

            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }

            if (id != payment.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    payment.UserId = Client;
                    _context.Update(payment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentExists(payment.Id))
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
            return View(payment);
        }

        // GET: Payments/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            var Client = HttpContext.Session.GetInt32("ClientId");

            ViewBag.uId = Client;
            ViewBag.h = _context.Homes.SingleOrDefault();


            if (Client == null)
            {

                return RedirectToAction("Login", "Account");
            }



            if (id == null)
            {
                return NotFound();
            }

            var payment = await _context.Payments
                .Include(p => p.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (payment == null)
            {
                return NotFound();
            }

            return View(payment);
        }

        // POST: Payments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var payment = await _context.Payments.FindAsync(id);
            _context.Payments.Remove(payment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentExists(decimal id)
        {
            return _context.Payments.Any(e => e.Id == id);
        }


    }
}
