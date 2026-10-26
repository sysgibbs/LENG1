using CRUD_PERSONAS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_PERSONAS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
    }
}