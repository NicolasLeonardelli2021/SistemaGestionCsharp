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
    public partial class FormModificar : Form
    {
        public FormModificar()
        {
            InitializeComponent();
        }
        private Producto _producto;
        public FormModificar(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
        }
        private void EnviarModif_Click(object sender, EventArgs e)
        {

            Producto producto = new Producto();

            _producto.Descripciones = textDescripcion.Text;
            _producto.Costo = decimal.Parse(numCosto.Text);
            _producto.PrecioVenta = decimal.Parse(numPrecio.Text);
            _producto.Stock = int.Parse(numStock.Text);
            _producto.IdUsuario = int.Parse(numIdUsuario.Text);

            Constexto.ModificarProducto(_producto);
            MessageBox.Show("Se grabo Correctamente");
        }

        private void FormModificar_Load(object sender, EventArgs e)
        {
            this.textDescripcion.Text = _producto.Descripciones;
            this.numCosto.Text = _producto.Costo.ToString();
            this.numPrecio.Text = _producto.PrecioVenta.ToString();
            this.numIdUsuario.Text = _producto.IdUsuario.ToString();
            this.stock.Text = _producto.Stock.ToString();
        }
    }
}
