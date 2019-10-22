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

namespace Parcial2_AP1.UI.Registros
{
    public partial class rVenta : Form
    {
        public List<DetalleVenta> Detalle { get; set; }
        private decimal Total = 0;
        public rVenta()
        {
            InitializeComponent();
            this.Detalle = new List<DetalleVenta>();
            this.DetalledataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CargarServicios();
        }

        private void Limpiar()
        {
            MyerrorProvider.Clear();      
            IDnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            EstudiantetextBox.Text = string.Empty;
            ServiciocomboBox.Text = string.Empty;
            CantidadtextBox.Text = string.Empty;
            PreciotextBox.Text = string.Empty;
            ImportetextBox.Text = string.Empty; 
            TotaltextBox.Text = string.Empty;
            this.Detalle = new List<DetalleVenta>();
            CargarGrid();
            MyerrorProvider.Clear();
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;
            DetalledataGridView.Columns["DetalleVentaID"].Visible = false;
            DetalledataGridView.Columns["VentaID"].Visible = false;
        }

        private void CargarServicios()
        {
            List<Servicio> lista = new List<Servicio>();
            RepositorioBase<Servicio> repositorio = new RepositorioBase<Servicio>();
            lista = repositorio.GetList(p =>true);
            ServiciocomboBox.DataSource = lista;
            ServiciocomboBox.ValueMember = "CategoriaID";
            ServiciocomboBox.DisplayMember = "Descripcion";
        }

        private Venta LlenaClase()
        {
            Venta venta = new Venta();
            venta.VentaID = Convert.ToInt32(IDnumericUpDown.Value);
            venta.Fecha = FechadateTimePicker.Value;
            venta.Estudiante = EstudiantetextBox.Text;
            venta.Total = Convert.ToDecimal(TotaltextBox.Text);
            venta.Servicios = this.Detalle;

            return venta;
        }

        private void LlenaCampos(Venta v)
        {
            IDnumericUpDown.Value = v.VentaID;
            EstudiantetextBox.Text = v.Estudiante;
            FechadateTimePicker.Value = v.Fecha;
            TotaltextBox.Text = v.Total.ToString();
            Total = v.Total;
            this.Detalle = v.Servicios;
            CargarGrid();
        }

        private bool Existe()
        {

            RepositorioBase<Venta> repositorio = new RepositorioBase<Venta>();
            Venta venta = new Venta();
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            venta = repositorio.Buscar(ID);

            return (venta != null);
        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool ValidarRemover()
        {
            bool paso = true;

            if (DetalledataGridView.SelectedRows == null)
            {
                MyerrorProvider.SetError(Removerbutton, "Debe seleccionar al menos una fila.");
                paso = false;
            }

            return paso;
        }


        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (!ValidarRemover())
                return;
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                var ImporteEliminado = DetalledataGridView.CurrentRow.Cells[5].Value;
                decimal eliminado = Convert.ToDecimal(ImporteEliminado);
                Total -= eliminado;
                TotaltextBox.Text = Total.ToString();
                this.Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);     
                CargarGrid();
            }
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(EstudiantetextBox.Text))
            {
                MyerrorProvider.SetError(EstudiantetextBox, "Este campo no puede estar vacio.");
                paso = false;
            }
            if(this.Detalle.Count == 0)
            {
                MyerrorProvider.SetError(Agregarbutton, "Debe agregar un servicio.");
                paso = false;
            }

            return paso;
        }

        private bool ValidarAgregar()
        {
            bool paso = true;
            int cantidad = 0;
            decimal precio = 0;
            MyerrorProvider.Clear();
            if(ServiciocomboBox.Text == "")
            {
                MyerrorProvider.SetError(ServiciocomboBox, "Debe elegir un servicio.");
                paso = false;
            }
            if (ServiciocomboBox.SelectedIndex == -1)
            {
                MyerrorProvider.SetError(ServiciocomboBox, "Debe elegir un servicio.");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CantidadtextBox.Text))
            {
                MyerrorProvider.SetError(CantidadtextBox, "Este campo no puede estar vacio.");
                paso = false;
            }
            else
            {
                try
                {
                    cantidad = Convert.ToInt32(CantidadtextBox.Text);
                }
                catch (Exception)
                {
                    MyerrorProvider.SetError(CantidadtextBox, "Este debe ser numerico.");
                    paso = false;
                }
            }

            if (string.IsNullOrWhiteSpace(PreciotextBox.Text))
            {

                MyerrorProvider.SetError(PreciotextBox, "Este campo no puede estar vacio.");
                paso = false;
            }
            else
            {
                try
                {
                    precio = Convert.ToInt32(PreciotextBox.Text);
                }
                catch (Exception)
                {
                    MyerrorProvider.SetError(PreciotextBox, "Este debe ser numerico.");
                    paso = false;
                }
            }

            if (cantidad < 0)
            {
                MyerrorProvider.SetError(CantidadtextBox, "Este campo debe ser mayor a cero.");
                paso = false;
            }

            if (precio < 0)
            {
                MyerrorProvider.SetError(PreciotextBox, "Este debe ser mayor a cero.");
                paso = false;
            }


            return paso;
        }

        private string NombreServicio()
        {
            string nombre = "";
            RepositorioBase<Servicio> repositorio = new RepositorioBase<Servicio>();
            nombre = repositorio.Buscar((int)ServiciocomboBox.SelectedValue).Descripcion;
            return nombre;
        }

        private decimal CalcularImporte()
        {
            int cantidad = Convert.ToInt32(CantidadtextBox.Text);
            decimal precio = Convert.ToDecimal(PreciotextBox.Text);
            decimal importe = cantidad * precio;
            return importe;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<DetalleVenta>)DetalledataGridView.DataSource;
            if (!ValidarAgregar())
                return;
            this.Detalle.Add(new DetalleVenta(
                   detalleVentaID: 0,
                   ventaID: Convert.ToInt32(IDnumericUpDown.Value),
                   servicioCombo: NombreServicio(),
                   cantidad: Convert.ToInt32(CantidadtextBox.Text),
                   precio: Convert.ToDecimal(PreciotextBox.Text),
                   importe: CalcularImporte()
                )
            );
            ImportetextBox.Text = CalcularImporte().ToString();
            Total += CalcularImporte();
            TotaltextBox.Text = Convert.ToString(Total);
            MyerrorProvider.Clear();
            CargarGrid();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso;
            if (!Validar())
                return;
            RepositorioVenta repositorio = new RepositorioVenta();
            Venta venta = new Venta();

            venta = LlenaClase();
            if(IDnumericUpDown.Value == 0)
            {
                paso = repositorio.Guardar(venta);
            }
            else
            {
                if (!Existe())
                {
                    MessageBox.Show("No se puede modificar porque no existe en la base de datos",
                           "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(venta);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            Venta venta = new Venta();
            RepositorioBase<Venta> repositorio = new RepositorioBase<Venta>();
            venta = repositorio.Buscar(ID);

            if (venta != null)
            {
                Limpiar();
                LlenaCampos(venta);
            }
            else
            {
                MessageBox.Show("Venta no encontrada.");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            int ID = Convert.ToInt32(IDnumericUpDown.Value);
            bool paso;
            RepositorioBase<Venta> repositorio = new RepositorioBase<Venta>();

            if (!Existe())
            {
                MessageBox.Show("No se puede eliminar porque no existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                paso = repositorio.Eliminar(ID);
                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Venta eliminada!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la venta", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarDosCampos()
        {
            MyerrorProvider.Clear();
            bool paso = true;
            int cantidad = 0;
            decimal precio = 0;
            
            if (string.IsNullOrWhiteSpace(CantidadtextBox.Text))
            {
                MyerrorProvider.SetError(CantidadtextBox, "Este campo no puede estar vacio.");
                paso = false;
            }
            else
            {
                try
                {
                    cantidad = Convert.ToInt32(CantidadtextBox.Text);
                }
                catch (Exception)
                {
                    MyerrorProvider.SetError(CantidadtextBox, "Este debe ser numerico.");
                    paso = false;
                }
            }

            if (string.IsNullOrWhiteSpace(PreciotextBox.Text))
            {

                MyerrorProvider.SetError(PreciotextBox, "Este campo no puede estar vacio.");
                paso = false;
            }
            else
            {
                try
                {
                    precio = Convert.ToInt32(PreciotextBox.Text);
                }
                catch (Exception)
                {
                    MyerrorProvider.SetError(PreciotextBox, "Este debe ser numerico.");
                    paso = false;
                }
            }

            if (cantidad < 0)
            {
                MyerrorProvider.SetError(CantidadtextBox, "Este campo debe ser mayor a cero.");
                paso = false;
            }

            if (precio < 0)
            {
                MyerrorProvider.SetError(PreciotextBox, "Este campo  debe ser mayor a cero.");
                paso = false;
            }
            return paso;
        }

        private void PreciotextBox_TextChanged(object sender, EventArgs e)
        {
            if (!ValidarDosCampos())
                return;
            MyerrorProvider.Clear();
            int cantidad = Convert.ToInt32(CantidadtextBox.Text);
            decimal precio = Convert.ToDecimal(PreciotextBox.Text);
            decimal importe = cantidad * precio;

            ImportetextBox.Text = importe.ToString();
        }
    }
}
