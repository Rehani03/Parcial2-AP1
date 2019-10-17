using Parcial2_AP1.UI.Consultas;
using Parcial2_AP1.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_AP1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rFactura factura = new rFactura();
            factura.MdiParent = this;
            factura.Show();
        }

        private void RegistrarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rCategoria categoria = new rCategoria();
            categoria.MdiParent = this;
            categoria.Show();
        }

        private void ConsultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cFactura factura = new cFactura();
            factura.MdiParent = this;
            factura.Show();
        }
    }
}
