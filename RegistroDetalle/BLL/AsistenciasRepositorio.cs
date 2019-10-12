using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.BLL
{
    public class AsistenciasRepositorio : RepositorioBase<Asistencias>
    {
        public override bool Modificar(Asistencias asistencia)
        {
            var Anterior = base._contexto.asistencias.Find(asistencia.AsistenciaId);
            foreach(var item in Anterior.Estudiantes)
            {
                if (!asistencia.Estudiantes.Exists(d => d.EstudianteId == item.EstudianteId))
                    base._contexto.Entry(item).State = EntityState.Deleted;
            }

            bool paso = base.Modificar(asistencia);

            return paso;
        }

        public override Asistencias Buscar(int id)
        {
            Asistencias asistencia = new Asistencias();

            asistencia = base._contexto.asistencias.Find(id);

            asistencia.Estudiantes.Count();

            return base.Buscar(id);
        }
    }
}
