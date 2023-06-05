using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YummyTemplate.DAL;
using YummyTemplate.Entities;

namespace YummyTemplate.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly RelationDbContext _context;

        public TestimonialController(RelationDbContext context)
        {
            this._context = context;
        }
        public IActionResult Detail(int id)
        {
            Testimonial testimomnial = _context.Testimonials.Include(c => c.Profession).ToList().FirstOrDefault(x => x.Id == id);
            return View(testimomnial);
        }
    }
}
