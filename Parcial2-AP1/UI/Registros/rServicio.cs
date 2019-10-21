using Parcial2_AP1.BLL;
using Parcial2_AP1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_AP1.UI.Registros
{
    public partial class rServicio : Form
    {
        
        public rServicio()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            MyerrorProvider.Clear();
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
        }

        private Servicio LlenaClase()
        {
            Servicio categoria = new Servicio();
            categoria.CategoriaID = Convert.ToInt32(IDnumericUpDown.Value);
            categoria.Descripcion = DescripciontextBox.Text;

            return categoria;
        }

        private void LlenaCampos(Servicio c)
        {
            IDnumericUpDown.Value = c.CategoriaID;
            DescripciontextBox.Text = c.Descripcion;
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MyerrorProvider.SetError(DescripciontextBox, "El Campo descripción no puede estar vacío");
                paso = false;
            }

            return paso;
        }

        private bool Existe()
        {
            RepositorioBase<Servicio> repositorio = new RepositorioBase<Servicio>();
            Servicio c = repositorio.Buscar(Convert.ToInt32(IDnumericUpDown.Value));
            return (c != null);
        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            bool paso;
            Servicio categoria = new Servicio();
            categoria = LlenaClase();
            RepositorioBase<Servicio> repositorio = new RepositorioBase<Servicio>();

            if (IDnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(categoria);
            }     
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar porque no existe","Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(categoria);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo Guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Servicio categoria = new Servicio();
            RepositorioBase<Servicio>  repositorio = new RepositorioBase<Servicio>();
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            categoria = repositorio.Buscar(ID);

            if (categoria != null)
            {
                Limpiar();
                LlenaCampos(categoria);
            }
            else
                MessageBox.Show("Categoria no Encontrada");
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            RepositorioBase<Servicio>  repositorio = new RepositorioBase<Servicio>();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe en la Base de Datos", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                paso = repositorio.Eliminar(ID);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se pudo eliminar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
