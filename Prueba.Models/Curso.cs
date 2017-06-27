using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Models
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public int NumeroCreditos { get; set; }

        public virtual ICollection<Matricula> Matriculas { get; set; }
    }
}
