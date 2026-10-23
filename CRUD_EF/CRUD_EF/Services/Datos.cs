using CRUD_EF.Data;
using CRUD_EF.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_EF.Services;

public class Datos
{
    public void Create(Persona persona)
    {
        using var db = new AppDbContext();

        db.Personas.Add(persona);
        db.SaveChanges();
    }

    public List<Persona> Read()
    {
        using var db = new AppDbContext();

        return db.Personas
            .AsNoTracking()
            .OrderBy(p => p.PersonaID)
            .ToList();
    }

    public bool Update(Persona persona)
    {
        using var db = new AppDbContext();

        var existente = db.Personas.Find(persona.PersonaID);

        if (existente is null)
            return false;

        existente.Nombre = persona.Nombre;
        existente.Apellido = persona.Apellido;
        existente.Correo = persona.Correo;

        db.SaveChanges();
        return true;
    }

    public bool Delete(int personaID)
    {
        using var db = new AppDbContext();

        var persona = db.Personas.Find(personaID);

        if (persona is null)
            return false;

        db.Personas.Remove(persona);
        db.SaveChanges();
        return true;
    }

    public Persona? BuscarId(int PersonaID)
    {
        using var db = new AppDbContext();

        return db.Personas
            .AsNoTracking()
            .FirstOrDefault(p => p.PersonaID == PersonaID);
    }

    public List<Persona> BuscarNombre(string nombre)
    {
        using var db = new AppDbContext();

        return db.Personas
            .AsNoTracking()
            .Where(p => p.Nombre.Contains(nombre))
            .OrderBy(p => p.Nombre)
            .ToList();
    }
}