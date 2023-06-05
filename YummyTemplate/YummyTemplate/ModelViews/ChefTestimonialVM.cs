using YummyTemplate.Entities;

namespace YummyTemplate.ModelViews
{
    public class ChefTestimonialVM
    {
        public IEnumerable<Chef> Chefs { get; set; }

        public IEnumerable<Testimonial> Testimonials { get; set; }
    }
}
