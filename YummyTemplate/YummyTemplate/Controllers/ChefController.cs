using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YummyTemplate.DAL;
using YummyTemplate.Entities;

namespace YummyTemplate.Controllers
{
    public class ChefController : Controller
    {
        private readonly RelationDbContext _context;

        public ChefController(RelationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Detail(int id)
        {
            Chef chef = _context.Chefs.Include(c => c.ChefSocialMedia).Include(c => c.Profession).ToList().FirstOrDefault(x => x.Id == id);
            return View(chef);
        }
    }
}
