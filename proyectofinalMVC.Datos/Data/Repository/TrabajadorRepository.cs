using proyectofinalMVC.Data;
using proyectofinalMVC.Datos.Data.Repository.IRepository;
using proyectofinalMVC.Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectofinalMVC.Datos.Data.Repository
{
    public class TrabajadorRepository : Repository<Trabajador>, ITrabajadorRepository
    {
        private readonly ApplicationDbContext _db;

        public TrabajadorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Trabajador trabajador)
        {
            var objDesdeDb = _db.Trabajador.FirstOrDefault(s => s.CodTrabajador == trabajador.CodTrabajador);
            objDesdeDb.Ci = trabajador.Ci;
            objDesdeDb.Nombre = trabajador.Nombre;
            objDesdeDb.Apellido = trabajador.Apellido;
            objDesdeDb.Direccion = trabajador.Direccion;

            _db.SaveChanges();
        }

    }
}
