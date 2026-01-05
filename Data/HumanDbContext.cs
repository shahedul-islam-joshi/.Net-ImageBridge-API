using image_API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace image_API.Data
{
    public class HumanDbContext : DbContext
    {
        public HumanDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Human> _Humans { get; set; }
    }
}
