using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public DateTime FechaMatricula { get; set; }
        public int AlumnoId { get; set; }
        public int CursoId { get; set; }

        public virtual Curso  Cursos { get; set; }
        public virtual Alumno Alumnos { get; set; } 

    }
}
