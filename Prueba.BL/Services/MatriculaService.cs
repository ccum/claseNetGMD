using Prueba.DAO.Repositories;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.BL.Services
{
    public class MatriculaService
    {
        MatriculaRepository repositorio;
        public MatriculaService()
        {
            repositorio = new MatriculaRepository();
        }
        public List<Matricula> Listar()
        {
            return repositorio.Listar();
        }
        public bool Crear(Matricula matricula)
        {
            matricula.FechaMatricula = DateTime.Now;
            return repositorio.Crear(matricula);
        }
        public List<Matricula> ListadoPorAlumno(int alumnoID)
        {
            return repositorio.ListadoPorAlumno(alumnoID);
        }
    }
}
