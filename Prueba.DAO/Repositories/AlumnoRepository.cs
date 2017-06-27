using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAO.Repositories
{
    public class AlumnoRepository
    {
        Contexto contex = null;
        public AlumnoRepository()
        {
            Contexto contex= new Contexto();
        }
        public List<Alumno> Listar()
        {
            return contex.Alumnos.ToList();
        }
        public Alumno BuscarPorId(int Id)
        {
           Alumno result = contex.Alumnos.Where(s => s.AlumnoId == Id).FirstOrDefault();
            return result;
        }
        public int Crear(Alumno alumno)
        {

            Alumno result = contex.Alumnos.Add(alumno);
            contex.SaveChanges();
            return result.AlumnoId;
        }

        public int Editar(Alumno alumno)
        {
            ///Alumno result = contex.Alumnos.en(alumno);
            //contex.SaveChanges();
            //return result.AlumnoId;

            return 0;
        }

    }
}
