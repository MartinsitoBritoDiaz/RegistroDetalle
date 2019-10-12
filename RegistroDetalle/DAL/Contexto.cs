using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Asistencias> asistencias { get; set; }
        public DbSet<Asignaturas> asignaturas { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public Contexto() : base("ConStr") { }
    }
}
