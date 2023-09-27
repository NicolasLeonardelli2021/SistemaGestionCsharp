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
        public AltaProducto()
        {
            InitializeComponent();
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

            Constexto.crearProducto(producto);
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}
