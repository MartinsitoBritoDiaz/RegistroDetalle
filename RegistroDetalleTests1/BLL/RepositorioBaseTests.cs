using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroDetalle.BLL;
using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void RepositorioBaseTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();

            bool paso = false;

            Asistencias asistencia = repositorio.Buscar(2);

            if (asistencia != null)
                paso = true;

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void DisposeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();

            Assert.IsTrue(repositorio.Eliminar(2));
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GuardarTest()
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();
            Asistencias asistencia = new Asistencias();
            List<EstudiantesDetalle> lista = new List<EstudiantesDetalle>();

            bool paso;

            lista.Add(new EstudiantesDetalle(0, 0, "Martinsito", true));

            asistencia.AsistenciaId = 0;
            asistencia.Asignatura = "Aplicada";
            asistencia.Cantidad = 1;
            asistencia.Estudiantes = lista;
            asistencia.Fecha = DateTime.Now;

            paso = repositorio.Guardar(asistencia);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();
            Asistencias asistencia = new Asistencias();
            List<EstudiantesDetalle> lista = new List<EstudiantesDetalle>();

            bool paso;

            lista.Add(new EstudiantesDetalle(1, 2, "Martinsito", true));

            asistencia.AsistenciaId = 2;
            asistencia.Asignatura = "Aplicada";
            asistencia.Cantidad = 1;
            asistencia.Estudiantes = lista;
            asistencia.Fecha = DateTime.Now;

            paso = repositorio.Modificar(asistencia);

            Assert.AreEqual(paso, true);
        }
    }
}