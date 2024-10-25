using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using proyectofinalMVC.Datos.Models;

namespace proyectofinalMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //modelos añadidos
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Trabajador> Trabajador { get; set; }
        public DbSet<Profesion> Profesion { get; set; }
        public DbSet<Proyecto> Proyecto { get; set;}
        public DbSet<ProyectoTrabajador> proyectoTrabajador { get; set; }
    }
}
