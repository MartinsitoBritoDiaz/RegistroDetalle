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

namespace RegistroDetalle.UI.Consultas
{
    public partial class cAsistencias : Form
    {
        public cAsistencias()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();
            List<Asistencias> listado = new List<Asistencias>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = repositorio.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = repositorio.GetList(p => p.AsistenciaId == id);
                        break;

                    case 2:
                        listado = repositorio.GetList(p => p.Asignatura.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        int cantidad = Convert.ToInt32(CriterioTextBox.Text);
                        listado = repositorio.GetList(p => p.Cantidad == cantidad);
                        break;
                }

                listado = listado.Where(c => c.Fecha >= DesdeDateTimePicker.Value && c.Fecha <= HastaDateTimePicker.Value).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
