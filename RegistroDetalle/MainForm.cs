using RegistroDetalle.UI.Consultas;
using RegistroDetalle.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDetalle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsistencias asistencias = new rAsistencias();
            asistencias.MdiParent = this;
            asistencias.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignatura asignatura = new rAsignatura();
            asignatura.MdiParent = this;
            asignatura.Show();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes estudiantes = new rEstudiantes();
            estudiantes.MdiParent = this;
            estudiantes.Show();
        }

        private void AsistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cAsistencias asistencia = new cAsistencias();
            asistencia.MdiParent = this;
            asistencia.Show();
        }

        private void EstudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cEstudiantes estudiante = new cEstudiantes();
            estudiante.MdiParent = this;
            estudiante.Show();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cAsignaturas asignaturas = new cAsignaturas();
            asignaturas.MdiParent = this;
            asignaturas.Show();
        }
    }
}
