using Microsoft.EntityFrameworkCore;
using YummyTemplate.Entities;

namespace YummyTemplate.DAL
{
    public class RelationDbContext:DbContext
    {
        public RelationDbContext(DbContextOptions<RelationDbContext> options) :base(options)
        {

        }

        public DbSet<Chef> Chefs { get; set; }

        public DbSet<Profession> Professions { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

        public DbSet<ChefSocialMedia> ChefSocialMedias { get; set; }
    }
}
