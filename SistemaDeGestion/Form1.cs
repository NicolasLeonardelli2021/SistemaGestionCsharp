using SistemaGestion;

namespace SistemaDeGestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            if (panel_Contenedor.Controls.Count > 0)
            {
                panel_Contenedor.Controls.RemoveAt(0);
            }
            pagInicio form = new pagInicio();
            form.TopLevel = false;
            panel_Contenedor.Controls.Add(form);
            form.Show();
        }

        private void panel_Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            if (panel_Contenedor.Controls.Count > 0)
            {
                panel_Contenedor.Controls.RemoveAt(0);
            }
            Usuarios_Listar form = new Usuarios_Listar();
            form.TopLevel = false;
            panel_Contenedor.Controls.Add(form);
            form.Show();


        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            if (panel_Contenedor.Controls.Count > 0)
            {
                panel_Contenedor.Controls.RemoveAt(0);
            }
            Productos_Listar form = new Productos_Listar();
            form.TopLevel = false;
            panel_Contenedor.Controls.Add(form);
            form.Show();
        }
    }
}