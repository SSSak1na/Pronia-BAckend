using MVC_introViewBag_ViewData_TempData_Front_to_back.DAL;
using MVC_introViewBag_ViewData_TempData_Front_to_back.Models;

namespace MVC_introViewBag_ViewData_TempData_Front_to_back.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Dictionary<string,string>>GetSettingsAsync()
        {
            Dictionary<string, string> settings = await _context.Settings.ToDictionaryAsync(s => s.Key, s => s.Value);
            return settings;
        }
    }
}
