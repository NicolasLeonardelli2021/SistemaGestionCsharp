using System.Collections.Generic;
using System.Data.SqlClient;

namespace SistemaGestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;


            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
            Producto producto = Constexto.ListarProductos().Where(x => x.Id == Id).FirstOrDefault();

            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "")
            {
                FormModificar modificar = new FormModificar(producto);
                modificar.FormClosed += Modificar_FormClosed;
                modificar.ShowDialog();

            }
        }

        private void Modificar_FormClosed(object? sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarUsuarios();

        }

        private void CargarUsuarios()
        {
            List<Usuario> lista = ConstextoUsuario.ListarUsuarios();

            tablaUsuario.AutoGenerateColumns = false;
            tablaUsuario.DataSource = lista;
        }

        private void CargarProductos()
        {
            List<Producto> lista = Constexto.ListarProductos();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = lista;
        }

        private void AltaProducto_Click(object sender, EventArgs e)
        {

        }

        private void tablaUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }
    }
}