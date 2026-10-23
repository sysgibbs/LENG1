using CRUD_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_EF.Data;

public class AppDbContext : DbContext
{
    public DbSet<Persona> Personas => Set<Persona>();

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=Personas.db");
        }
    }

    
    
}