using SistemaDeGestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class AltaProducto : Form
    {
        private bool agregar = true;
        private Producto _producto = new Producto();


        public AltaProducto()
        {
            InitializeComponent();
        }

        public AltaProducto(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
            agregar = false;
            CargarDatosForm();
        }

        private void CargarDatosForm()
        {
            this.textDescripcion.Text = _producto.Descripciones;
            this.numCosto.Text = _producto.Costo.ToString();
            this.numPrecio.Text = _producto.PrecioVenta.ToString();
            this.numStock.Text = _producto.Stock.ToString();
            this.numIdUsuario.Text = _producto.IdUsuario.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void precio_Click(object sender, EventArgs e)
        {

        }

        private void AltaProducto_Load(object sender, EventArgs e)
        {

        }

        private void EnviarForm_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Descripciones = textDescripcion.Text;
            producto.Costo = decimal.Parse(numCosto.Text);
            producto.PrecioVenta = decimal.Parse(numPrecio.Text);
            producto.Stock = int.Parse(numStock.Text);
            producto.IdUsuario = int.Parse(numIdUsuario.Text);

            if (agregar)
            {
                ContextoProductos.crearProducto(producto);
            }
            else
            {
                producto.Id = _producto.Id;
                ContextoProductos.ModificarProducto(producto);
            }
            DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void textDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void numStock_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void stock_Click(object sender, EventArgs e)
        {
        }

        private void numPrecio_TextChanged(object sender, EventArgs e)
        {
        }

        private void costo_Click(object sender, EventArgs e)
        {
        }

        private void numCosto_TextChanged(object sender, EventArgs e)
        {
        }

        private void numIdUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void IdUsuario_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
