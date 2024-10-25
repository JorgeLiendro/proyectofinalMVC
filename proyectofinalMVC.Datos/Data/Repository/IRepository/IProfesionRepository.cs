using proyectofinalMVC.Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectofinalMVC.Datos.Data.Repository.IRepository
{
    public interface IProfesionRepository : IRepository<Profesion>
    {
        void Update(Profesion profesion);
    }
}
