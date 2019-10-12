using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.Entidades
{
    public class EstudiantesDetalle
    {
        [Key]
        public int EstudianteId { get; set; }
        public int AsistenciaId { get; set; }
        public string Nombre { get; set; }
        public bool Presencia { get; set; }

        public EstudiantesDetalle(int estudianteId, int asistenciaId,string nombre, bool presencia)
        {
            EstudianteId = estudianteId;
            AsistenciaId = asistenciaId;
            Nombre = nombre;
            Presencia = presencia;
        }

        public EstudiantesDetalle()
        {
            EstudianteId = 0;
            AsistenciaId = 0;
            Nombre = string.Empty;
            Presencia = false;
        }
    }
}
