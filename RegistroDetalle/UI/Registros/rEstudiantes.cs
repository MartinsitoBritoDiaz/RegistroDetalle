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
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void REstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();
            EstudianteIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
        }

        private void LlenaCampo(Estudiantes estudiantes)
        {
            EstudianteIdNumericUpDown.Value = estudiantes.EstudianteId;
            NombreTextBox.Text = estudiantes.Nombre;
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiantes = new Estudiantes();

            estudiantes.EstudianteId = Convert.ToInt32(EstudianteIdNumericUpDown.Value);
            estudiantes.Nombre = NombreTextBox.Text;

            return estudiantes;
        }

        private bool Validar()
        {
            bool paso = true;

            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "El campo Nombre no puede estar vacio");
                NombreTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            Estudiantes estudiantes = repositorio.Buscar((int)EstudianteIdNumericUpDown.Value);

            return (estudiantes != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            bool paso = false;
            Estudiantes estudiante;

            if (!Validar())
                return;

            estudiante = LlenaClase();

            if (EstudianteIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encuentra en la base de datos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(estudiante);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("!Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puede modificar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Borrarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            MyErrorProvider.Clear();

            int id;
            int.TryParse(Convert.ToString(EstudianteIdNumericUpDown.Value), out id);

            Limpiar();

            if (repositorio.Buscar(id) != null)
            {
                repositorio.Eliminar(id);
                MessageBox.Show("!Eliminado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyErrorProvider.SetError(EstudianteIdNumericUpDown, "No puede eliminar un estudiante que no existe");
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();

            int id;
            int.TryParse(Convert.ToString(EstudianteIdNumericUpDown.Value), out id);

            Limpiar();

            Estudiantes estudiante = repositorio.Buscar(id);

            if (estudiante != null)
            {
                LlenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("Estudiante encontrado");
            }
        }
    }
}
