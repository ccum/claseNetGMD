using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAO.Repositories
{
    public class ClaseRepository
    {
        Contexto context = new Contexto();
        public ClaseRepository()
        {

        }

        public List<Clase> ListarClases()
        {
            List<Clase> lista = new List<Clase>();
            lista = context.Clases.ToList();

            return lista;
        }
    }
}
