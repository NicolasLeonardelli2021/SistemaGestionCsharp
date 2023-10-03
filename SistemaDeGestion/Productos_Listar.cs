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
    public partial class Productos_Listar : Form
    {
        public Productos_Listar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;


            int Id = (int)this.ListadoProductos.Rows[e.RowIndex].Cells["id"].Value;
            Producto producto = ContextoProductos.ListarProductos().Where(x => x.Id == Id).FirstOrDefault();

            if (this.ListadoProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                AltaProducto form = new AltaProducto(producto);
                //form.FormClosed += form.FormClosed;
                form.ShowDialog();
                cargarProductos();
            }
            else
                if (this.ListadoProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                ContextoProductos.EliminarProducto(producto);
                cargarProductos();
            }
        }

        private void Productos_Listar_Load(object sender, EventArgs e)
        {
            cargarProductos();

        }

        public void cargarProductos()
        {
            List<Producto> lista = ContextoProductos.ListarProductos();
            ListadoProductos.AutoGenerateColumns = false;
            ListadoProductos.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaProducto form = new AltaProducto();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("El Producto se Grabó correctamente");
                this.cargarProductos();
            };
        }


    }
}
