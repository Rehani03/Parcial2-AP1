using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2_AP1.Entidades;
using Parcial2_AP1.BLL;

namespace Parcial2_AP1.UI.Consultas
{
    public partial class cVenta : Form
    {
        public cVenta()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Venta>();
            RepositorioBase<Venta> repositorio = new RepositorioBase<Venta>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0: //Todo
                        listado = repositorio.GetList(p => true);
                        break;
                    case 1: //ID
                        int ID = GetCriterio();
                        listado = repositorio.GetList(p => p.VentaID == ID);
                        break;
                    case 2: //Nombre
                        string nombre = CriteriotextBox.Text;
                        listado = repositorio.GetList(p => p.Estudiante == nombre);
                        break;
                    case 3: //Total
                        decimal total = GetCriterioTotal();
                        listado = repositorio.GetList(p => p.Total == total);
                        break;
                    default:
                        MessageBox.Show("No existe esa opción en el filtro.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                //Fecha
               //listado = listado.Where(p => p.Fecha >= DesdedateTimePicker.Value.Date && p.Fecha <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            this.ConsultadataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ConsultadataGridView.DataSource = listado;

        }

        private int GetCriterio()
        {
            int ID = 0;
            try
            {
                ID = Convert.ToInt32(CriteriotextBox.Text);
                return ID;
            }
            catch (Exception)
            {
                MessageBox.Show("El criterio debe ser numérico.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return ID;
        }

        private decimal GetCriterioTotal()
        {
            decimal total = 0;
            try
            {
                total = Convert.ToDecimal(CriteriotextBox.Text);
                return total;
            }
            catch (Exception)
            {
                MessageBox.Show("El criterio debe ser numérico.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return total;
        }
    }
}
