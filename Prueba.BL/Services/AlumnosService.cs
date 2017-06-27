﻿using Prueba.DAO.Repositories;
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
        AlumnoRepository repositorio = null;
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

        public Boolean Crear(Alumno alumno)
        {
            int result = repositorio.Crear(alumno);
            if (result > 0)
                return true;
            return false;
        }

        public Boolean Editar(Alumno alumno)
        {
            return false;
        }

    }
}
