using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAO.Repositories
{
    public class MatriculaRepository
    {
        Contexto contex =null;
        public MatriculaRepository()
        {
            contex = new Contexto();
        }

        public List<Matricula> Listar()
        {
            return contex.Matriculas.ToList();
        }
        public Boolean Crear(Matricula matricula)
        {
            try
            {
                contex.Matriculas.Add(matricula);
                contex.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
