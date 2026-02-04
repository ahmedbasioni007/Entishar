using Microsoft.EntityFrameworkCore;

namespace Entishar.Data
{
    public class EntisharContext : DbContext
    {
        public EntisharContext (DbContextOptions<EntisharContext> options): base(options){}

        public DbSet<Models.User> Users { get; set; } = default!;

    }
}
