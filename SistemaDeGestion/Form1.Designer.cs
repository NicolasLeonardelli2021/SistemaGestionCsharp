namespace SistemaDeGestion
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
            panel_Lateral = new Panel();
            btn_Productos = new Button();
            btn_Usuarios = new Button();
            btn_Inicio = new Button();
            panel1 = new Panel();
            panel_Contenedor = new Panel();
            panel_Superior = new Panel();
            label1 = new Label();
            panel_Lateral.SuspendLayout();
            panel_Superior.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Lateral
            // 
            panel_Lateral.BackColor = SystemColors.Highlight;
            panel_Lateral.Controls.Add(btn_Productos);
            panel_Lateral.Controls.Add(btn_Usuarios);
            panel_Lateral.Controls.Add(btn_Inicio);
            panel_Lateral.Controls.Add(panel1);
            panel_Lateral.Dock = DockStyle.Left;
            panel_Lateral.Location = new Point(0, 0);
            panel_Lateral.Name = "panel_Lateral";
            panel_Lateral.Size = new Size(200, 450);
            panel_Lateral.TabIndex = 0;
            // 
            // btn_Productos
            // 
            btn_Productos.Cursor = Cursors.Hand;
            btn_Productos.Dock = DockStyle.Top;
            btn_Productos.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Productos.ForeColor = SystemColors.ActiveCaptionText;
            btn_Productos.Location = new Point(0, 169);
            btn_Productos.Name = "btn_Productos";
            btn_Productos.Size = new Size(200, 34);
            btn_Productos.TabIndex = 2;
            btn_Productos.Text = "Productos";
            btn_Productos.UseVisualStyleBackColor = true;
            btn_Productos.Click += btn_Productos_Click;
            // 
            // btn_Usuarios
            // 
            btn_Usuarios.Cursor = Cursors.Hand;
            btn_Usuarios.Dock = DockStyle.Top;
            btn_Usuarios.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Usuarios.ForeColor = SystemColors.ActiveCaptionText;
            btn_Usuarios.Location = new Point(0, 135);
            btn_Usuarios.Name = "btn_Usuarios";
            btn_Usuarios.Size = new Size(200, 34);
            btn_Usuarios.TabIndex = 1;
            btn_Usuarios.Text = "Usuarios";
            btn_Usuarios.UseVisualStyleBackColor = true;
            btn_Usuarios.Click += btn_Usuarios_Click;
            // 
            // btn_Inicio
            // 
            btn_Inicio.Cursor = Cursors.Hand;
            btn_Inicio.Dock = DockStyle.Top;
            btn_Inicio.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Inicio.ForeColor = SystemColors.ActiveCaptionText;
            btn_Inicio.Location = new Point(0, 101);
            btn_Inicio.Name = "btn_Inicio";
            btn_Inicio.Size = new Size(200, 34);
            btn_Inicio.TabIndex = 0;
            btn_Inicio.Text = "Inicio";
            btn_Inicio.UseVisualStyleBackColor = true;
            btn_Inicio.Click += btn_Inicio_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 101);
            panel1.TabIndex = 0;
            // 
            // panel_Contenedor
            // 
            panel_Contenedor.Dock = DockStyle.Fill;
            panel_Contenedor.Location = new Point(200, 0);
            panel_Contenedor.Name = "panel_Contenedor";
            panel_Contenedor.Size = new Size(895, 450);
            panel_Contenedor.TabIndex = 1;
            panel_Contenedor.Paint += panel_Contenedor_Paint;
            // 
            // panel_Superior
            // 
            panel_Superior.BackColor = SystemColors.HotTrack;
            panel_Superior.Controls.Add(label1);
            panel_Superior.Dock = DockStyle.Top;
            panel_Superior.Location = new Point(200, 0);
            panel_Superior.Name = "panel_Superior";
            panel_Superior.Size = new Size(895, 27);
            panel_Superior.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(223, 6);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Sistema de Gestión";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 450);
            Controls.Add(panel_Superior);
            Controls.Add(panel_Contenedor);
            Controls.Add(panel_Lateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel_Lateral.ResumeLayout(false);
            panel_Superior.ResumeLayout(false);
            panel_Superior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Lateral;
        private Panel panel_Contenedor;
        private Button btn_Productos;
        private Button btn_Usuarios;
        private Button btn_Inicio;
        private Panel panel1;
        private Panel panel_Superior;
        private Label label1;
    }
}