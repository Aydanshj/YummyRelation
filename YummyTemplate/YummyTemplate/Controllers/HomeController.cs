using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YummyTemplate.DAL;
using YummyTemplate.Entities;
using YummyTemplate.ModelViews;

namespace YummyTemplate.Controllers
{
    public class HomeController : Controller
    {
        private readonly RelationDbContext _context;

        public HomeController(RelationDbContext context)
        {
            this._context = context;
        }



        public IActionResult Index()
        {

            IEnumerable<Chef> chefs = _context.Chefs.Include(c => c.ChefSocialMedia).Include(c => c.Profession).AsEnumerable();
            IEnumerable<Testimonial> testimonials = _context.Testimonials.Include(c => c.Profession).AsEnumerable();


            ChefTestimonialVM model = new()
            {
                Chefs = chefs,
                Testimonials = testimonials
            };

            return View(model);
        }

    }
}
