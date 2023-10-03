namespace SistemaDeGestion
{
    partial class Usuarios_Listar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListadoUsuarios = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            btnAgregarUsu = new Button();
            ((System.ComponentModel.ISupportInitialize)ListadoUsuarios).BeginInit();
            SuspendLayout();
            // 
            // ListadoUsuarios
            // 
            ListadoUsuarios.AllowUserToDeleteRows = false;
            ListadoUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListadoUsuarios.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail, Editar, Eliminar });
            ListadoUsuarios.Location = new Point(12, 76);
            ListadoUsuarios.Name = "ListadoUsuarios";
            ListadoUsuarios.ReadOnly = true;
            ListadoUsuarios.RowTemplate.Height = 25;
            ListadoUsuarios.Size = new Size(855, 150);
            ListadoUsuarios.TabIndex = 0;
            ListadoUsuarios.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "NombreUsuario";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            // 
            // Contraseña
            // 
            Contraseña.DataPropertyName = "Contraseña";
            Contraseña.HeaderText = "Contraseña";
            Contraseña.Name = "Contraseña";
            Contraseña.ReadOnly = true;
            // 
            // Mail
            // 
            Mail.DataPropertyName = "Mail";
            Mail.HeaderText = "Mail";
            Mail.Name = "Mail";
            Mail.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // btnAgregarUsu
            // 
            btnAgregarUsu.Location = new Point(742, 47);
            btnAgregarUsu.Name = "btnAgregarUsu";
            btnAgregarUsu.Size = new Size(125, 23);
            btnAgregarUsu.TabIndex = 1;
            btnAgregarUsu.Text = "Agregar Usuario";
            btnAgregarUsu.UseVisualStyleBackColor = true;
            btnAgregarUsu.Click += button1_Click;
            // 
            // Usuarios_Listar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 450);
            Controls.Add(btnAgregarUsu);
            Controls.Add(ListadoUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Usuarios_Listar";
            Text = "Usuarios_Listar";
            Load += Usuarios_Listar_Load;
            ((System.ComponentModel.ISupportInitialize)ListadoUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ListadoUsuarios;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Mail;
        private DataGridViewButtonColumn Editar;
        private DataGridViewButtonColumn Eliminar;
        private Button btnAgregarUsu;
    }
}