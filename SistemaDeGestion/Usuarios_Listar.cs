using SistemaGestion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeGestion
{
    public partial class Usuarios_Listar : Form
    {
        public Usuarios_Listar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;


            int Id = (int)this.ListadoUsuarios.Rows[e.RowIndex].Cells["id"].Value;
            Usuario usuario = ConstextoUsuario.ListarUsuarios().Where(x => x.Id == Id).FirstOrDefault();

            if (this.ListadoUsuarios.Columns[e.ColumnIndex].Name == "Editar")
            {
                AltaUsuario form = new AltaUsuario(usuario);
                //form.FormClosed += form.FormClosed;
                form.ShowDialog();
                cargarUsuarios();
            }
            else
                if (this.ListadoUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                ConstextoUsuario.EliminarUsuario(usuario);
                cargarUsuarios();
            }
        }

        public void cargarUsuarios()
        {
            List<Usuario> lista = ConstextoUsuario.ListarUsuarios();
            ListadoUsuarios.AutoGenerateColumns = false;
            ListadoUsuarios.DataSource = lista;
        }


        private void Usuarios_Listar_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }

        public void ListarUsuarios()
        {
            List<Usuario> lista = ConstextoUsuario.ListarUsuarios();
            ListadoUsuarios.AutoGenerateColumns = false;
            ListadoUsuarios.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaUsuario form = new AltaUsuario();

            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("El Usuario se Grabó correctamente");
                this.cargarUsuarios();
            };
        }
    }
}
