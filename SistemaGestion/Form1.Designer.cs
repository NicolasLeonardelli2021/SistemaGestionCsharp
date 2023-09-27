namespace SistemaGestion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            tablaUsuario = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            AltaProducto = new Button();
            Id = new DataGridViewTextBoxColumn();
            Editar = new DataGridViewButtonColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaUsuario).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Editar, Descripciones, Costo, PrecioVenta, Stock });
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(725, 398);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tablaUsuario
            // 
            tablaUsuario.AllowUserToAddRows = false;
            tablaUsuario.AllowUserToDeleteRows = false;
            tablaUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaUsuario.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, NombreUsuario, Contraseña, Mail });
            tablaUsuario.Location = new Point(27, 216);
            tablaUsuario.Name = "tablaUsuario";
            tablaUsuario.ReadOnly = true;
            tablaUsuario.RowTemplate.Height = 25;
            tablaUsuario.Size = new Size(529, 150);
            tablaUsuario.TabIndex = 1;
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
            // AltaProducto
            // 
            AltaProducto.Location = new Point(625, 115);
            AltaProducto.Name = "AltaProducto";
            AltaProducto.Size = new Size(112, 23);
            AltaProducto.TabIndex = 2;
            AltaProducto.Text = "Agregar Producto";
            AltaProducto.UseVisualStyleBackColor = true;
            AltaProducto.Click += AltaProducto_Click;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Editar
            // 
            Editar.HeaderText = "Editar";
            Editar.Name = "Editar";
            Editar.ReadOnly = true;
            Editar.Text = "Editar";
            Editar.UseColumnTextForButtonValue = true;
            // 
            // Descripciones
            // 
            Descripciones.DataPropertyName = "Descripciones";
            Descripciones.HeaderText = "Descripciones";
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            // 
            // Costo
            // 
            Costo.DataPropertyName = "Costo";
            Costo.HeaderText = "Costo";
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.DataPropertyName = "PrecioVenta";
            PrecioVenta.HeaderText = "PrecioVenta";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.DataPropertyName = "Stock";
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AltaProducto);
            Controls.Add(tablaUsuario);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView tablaUsuario;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Mail;
        private Button AltaProducto;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewButtonColumn Editar;
        private DataGridViewTextBoxColumn Descripciones;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
    }
}