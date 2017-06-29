using Prueba.DAO.Interfaces;
using Prueba.DAO.Repositories;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.BL.Services
{
    public class AlumnosService
    {
        IAlumnoRepository repositorio = null;
        public AlumnosService()
        {
            repositorio = new AlumnoRepository();
        }
        public List<Alumno> Listar()
        {
            return repositorio.Listar();
        }
        public Alumno BuscarPorId(int alumnoID)
        {
            return repositorio.BuscarPorId(alumnoID);
        }

        public bool Crear(Alumno alumno)
        {
            int result = repositorio.Crear(alumno);
            if (result > 0)
                return true;
            return false;
        }

        public Boolean Editar(Alumno alumno)
        {
            Alumno sinCambios = repositorio.BuscarPorId(alumno.AlumnoId);
            sinCambios.Apellido = alumno.Apellido;
            sinCambios.Cumpleaño = alumno.Cumpleaño;
            sinCambios.Nombre = alumno.Nombre;
            return repositorio.Editar(sinCambios);
        }

    }
}
