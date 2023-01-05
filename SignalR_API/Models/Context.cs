using Microsoft.EntityFrameworkCore;
using SignalR_API.Model;

namespace SignalR_API.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options):base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
