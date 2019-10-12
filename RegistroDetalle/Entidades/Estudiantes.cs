using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public bool Asistencia { get; set; }

        public Estudiantes(int estudianteId, string nombre, bool asistencia)
        {
            EstudianteId = estudianteId;
            Nombre = nombre;
            Asistencia = asistencia;
        }

        public Estudiantes()
        {
            EstudianteId = 0;
            Nombre = string.Empty;
            Asistencia = false;
        }
    }
}
