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
    public partial class rAsignatura : Form
    {
        public rAsignatura()
        {
            InitializeComponent();
        }

        private void RAsignatura_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            MyErrorProvider.Clear();

            AsignaturaIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
        }

        private void LlenaCampo(Asignaturas asignatura)
        {
            AsignaturaIdNumericUpDown.Value = asignatura.AsignaturaId;
            NombreTextBox.Text = asignatura.Nombre;
        }

        private Asignaturas LlenaClase()
        {
            Asignaturas asignatura = new Asignaturas();
            asignatura.AsignaturaId = Convert.ToInt32(AsignaturaIdNumericUpDown.Value);
            asignatura.Nombre = NombreTextBox.Text;

            return asignatura;
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
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            Asignaturas asignatura = repositorio.Buscar((int)AsignaturaIdNumericUpDown.Value);
            return (asignatura != null);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            bool paso = false;
            Asignaturas asignatura;

            if (!Validar())
                return;

            asignatura = LlenaClase();

            if (AsignaturaIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(asignatura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se encunetra en la base de datos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(asignatura);
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
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            MyErrorProvider.Clear();

            int id;
            int.TryParse(Convert.ToString(AsignaturaIdNumericUpDown.Value), out id);

            Limpiar();

            if (repositorio.Buscar(id) != null)
            {
                repositorio.Eliminar(id);
                MessageBox.Show("!Asignatura eliminada!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyErrorProvider.SetError(AsignaturaIdNumericUpDown, "No puede eliminar una asignatura que no existe");
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            int id;
            int.TryParse(Convert.ToString(AsignaturaIdNumericUpDown.Value), out id);

            Asignaturas asignatura = repositorio.Buscar(id);

            if(asignatura != null)
            {
                LlenaCampo(asignatura);
            }
            else
            {
                MessageBox.Show("Asignatura encontrada");
            }


        }
    }
}
