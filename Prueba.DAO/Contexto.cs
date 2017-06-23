using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.DAO
{
    public class Contexto: DbContext
    {
        public Contexto():base("Contexto")
        {
                
        }

        public DbSet<Clase> Clases { get; set; }
        public DbSet<Profesor> Profesores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
