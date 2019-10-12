using RegistroDetalle.BLL;
using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDetalle.UI.Registros
{
    public partial class rAsistencias : Form
    {
        public List<EstudiantesDetalle> Detalle { get; set; }
        public rAsistencias()
        {
            InitializeComponent();
            this.Detalle = new List<EstudiantesDetalle>();
        }

        private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = this.Detalle;
        }
        private void Limpiar()
        {
            MyErrorProvider.Clear();

            AsistenciasIdNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            AsignaturaComboBox.Text = string.Empty;
            EstudianteComboBox.Text = string.Empty;
            PresenteCheckBox.Checked = false;
            CantidadTextBox.Text = string.Empty;

            this.Detalle = new List<EstudiantesDetalle>();
            CargarGrid();
        }

        private Asistencias LlenaClase()
        {
            Asistencias asistencia = new Asistencias();
            asistencia.AsistenciaId = Convert.ToInt32(AsistenciasIdNumericUpDown.Value);
            asistencia.Fecha = FechaDateTimePicker.Value;
            asistencia.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
            asistencia.Asignatura = AsignaturaComboBox.Text;
            asistencia.Estudiantes = this.Detalle;

            return asistencia;
        }

        private void LlenaCampos(Asistencias asistencia)
        {
            AsistenciasIdNumericUpDown.Value = asistencia.AsistenciaId;
            FechaDateTimePicker.Value = asistencia.Fecha;
            AsignaturaComboBox.Text = asistencia.Asignatura;
            CantidadTextBox.Text = Convert.ToString(asistencia.Cantidad);
            this.Detalle = asistencia.Estudiantes;
            CargarGrid();
        }
        
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if(this.Detalle.Count == 0)
            {
                MyErrorProvider.SetError(DetalleDataGridView, "Debe agregar algun estudiante");
                EstudianteComboBox.Focus();
                paso = false;
            }

            if(AsignaturaComboBox.Items.Count == 0 )
            {
                MyErrorProvider.SetError(AsignaturaComboBox, "Debe de agregar una asignatura para completar la asistencia");
                AsignaturaComboBox.Focus();
                paso = false;
            }

            if(AsignaturaComboBox.Text.Trim().Length == 0)
            {
                MyErrorProvider.SetError(AsignaturaComboBox, "Debe de seleccionar una asignatura para completar la asistencia");
                AsignaturaComboBox.Focus();
                paso = false;
            }

            return paso;
        }
        private void RAsistencias_Load(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorioEstudiante = new RepositorioBase<Estudiantes>();
            foreach(var auxiliar in repositorioEstudiante.GetList(p => true))
            {
                EstudianteComboBox.Items.Add(auxiliar.Nombre);
            }

            RepositorioBase<Asignaturas> repositorioAsignatura = new RepositorioBase<Asignaturas>();
            foreach (var auxiliar in repositorioAsignatura.GetList(p => true))
            {
                AsignaturaComboBox.Items.Add(auxiliar.Nombre);
            }

        }

        private void FechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AgregarEstudiantebutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorioEstudiante = new RepositorioBase<Estudiantes>();
            rEstudiantes estudiantes = new rEstudiantes();
            estudiantes.ShowDialog();

            EstudianteComboBox.Items.Clear();

            foreach (var auxiliar in repositorioEstudiante.GetList(p => true))
            {
                EstudianteComboBox.Items.Add(auxiliar.Nombre);
            }

        }

        private void AgregarEstudianteDataButton_Click(object sender, EventArgs e)
        {
            if (EstudianteComboBox.Text.Trim().Length != 0)
            {
                if (DetalleDataGridView.DataSource != null)
                    this.Detalle = (List<EstudiantesDetalle>)DetalleDataGridView.DataSource;

                this.Detalle.Add(
                    new EstudiantesDetalle(
                        estudianteId: 0,
                        asistenciaId: Convert.ToInt32(AsistenciasIdNumericUpDown.Value),
                        nombre: EstudianteComboBox.Text,
                        presencia: PresenteCheckBox.Checked
                        )
                    );

                CargarGrid();
                EstudianteComboBox.Focus();
                EstudianteComboBox.Text = "";

                CantidadTextBox.Text = DetalleDataGridView.Rows.Count.ToString();
            }
            else
            {
                MessageBox.Show("Debe de seleccionar un estudiante.");
            }
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();

            Asistencias asistencia = repositorio.Buscar((int)AsistenciasIdNumericUpDown.Value);

            return (asistencia != null);
        }
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();

            Asistencias asistencia;
            bool paso = false;

            if (!Validar())
                return;

            asistencia = LlenaClase();

            if (AsistenciasIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(asistencia);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una asistencia que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(asistencia);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AsignaturaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void EstudianteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void RemoverFilaButton_Click(object sender, EventArgs e)
        {
            if(DetalleDataGridView.Rows.Count > 0 && DetalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
            }
        }

        private void Borrarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();
            MyErrorProvider.Clear(); 

            int id;
            int.TryParse(Convert.ToString(AsistenciasIdNumericUpDown.Value), out id);

            Limpiar();

            if(repositorio.Buscar(id) != null)
            {
                repositorio.Eliminar(id);
                MessageBox.Show("!Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else{
                MyErrorProvider.SetError(AsistenciasIdNumericUpDown, "No se puede eliminar una asistencia que no existe");
            }

        }

        private void GroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();

            int id;
            int.TryParse(Convert.ToString(AsistenciasIdNumericUpDown.Value), out id);

            Limpiar();

            Asistencias asistencia = repositorio.Buscar(id);

            if (asistencia != null)
            {
                LlenaCampos(asistencia);
            }
            else
            {
                MessageBox.Show("Asistencia no entrada");
            }
        }

        private void DetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
