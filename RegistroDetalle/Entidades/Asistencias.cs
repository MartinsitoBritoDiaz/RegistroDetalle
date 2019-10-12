using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.Entidades
{
    public class Asistencias
    {
        [Key]
        public int AsistenciaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Asignatura { get; set; }
        public int Cantidad { get; set; }

        public virtual List<EstudiantesDetalle> Estudiantes { get; set; }

        public Asistencias()
        {
            AsistenciaId = 0;
            Fecha = DateTime.Now;
            Asignatura = string.Empty;
            Cantidad = 0;

            Estudiantes = new List<EstudiantesDetalle>();
        }
    }
}
