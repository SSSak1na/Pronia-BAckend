using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_introViewBag_ViewData_TempData_Front_to_back.DAL;
using MVC_introViewBag_ViewData_TempData_Front_to_back.Models;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ClientController : Controller
    {
        private readonly AppDbContext _context;

        public ClientController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Client> clients = await _context.Clients.Include(c=>c.Profession).ToListAsync();
            return View(clients);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Proffesions = await _context.Professions.ToListAsync();
            return View();
        }
        [HttpPost]


        public async Task<IActionResult> Create(Client client)
        {
            if(!ModelState.IsValid) 
            {
                ViewBag.Proffesions = await _context.Professions.ToListAsync();

                return View(client);
            }
            bool result=await _context.Professions.AnyAsync(p=>p.Id == client.ProfessionId);
            if(!result)
            {
                
               ModelState.AddModelError("ProfessionId", "Bu Id uygun ixtisas tapilmadi, zehmet olmasa duzgun daxil edin");
                ViewBag.Proffesions = await _context.Professions.ToListAsync();
                return View();
            }

            await _context.Clients.AddAsync(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
