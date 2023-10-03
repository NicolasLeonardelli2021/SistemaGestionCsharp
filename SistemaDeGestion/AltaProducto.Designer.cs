namespace SistemaGestion
{
    partial class AltaProducto
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
            label1 = new Label();
            textDescripcion = new TextBox();
            precioVenta = new Label();
            numPrecio = new TextBox();
            numCosto = new TextBox();
            costo = new Label();
            numStock = new TextBox();
            stock = new Label();
            numIdUsuario = new TextBox();
            IdUsuario = new Label();
            EnviarForm = new Button();
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 68);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripcion";
            label1.Click += label1_Click;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(116, 65);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(227, 23);
            textDescripcion.TabIndex = 1;
            textDescripcion.TextChanged += textDescripcion_TextChanged;
            // 
            // precioVenta
            // 
            precioVenta.AutoSize = true;
            precioVenta.Location = new Point(41, 121);
            precioVenta.Name = "precioVenta";
            precioVenta.Size = new Size(72, 15);
            precioVenta.TabIndex = 2;
            precioVenta.Text = "Precio Venta";
            precioVenta.Click += precio_Click;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(116, 113);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(114, 23);
            numPrecio.TabIndex = 3;
            numPrecio.TextChanged += numPrecio_TextChanged;
            // 
            // numCosto
            // 
            numCosto.Location = new Point(116, 214);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(100, 23);
            numCosto.TabIndex = 7;
            numCosto.TextChanged += numCosto_TextChanged;
            // 
            // costo
            // 
            costo.AutoSize = true;
            costo.Location = new Point(41, 217);
            costo.Name = "costo";
            costo.Size = new Size(38, 15);
            costo.TabIndex = 6;
            costo.Text = "Costo";
            costo.Click += costo_Click;
            // 
            // numStock
            // 
            numStock.Location = new Point(116, 164);
            numStock.Name = "numStock";
            numStock.Size = new Size(114, 23);
            numStock.TabIndex = 5;
            numStock.TextChanged += numStock_TextChanged;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new Point(41, 167);
            stock.Name = "stock";
            stock.Size = new Size(36, 15);
            stock.TabIndex = 4;
            stock.Text = "Stock";
            stock.Click += stock_Click;
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(116, 265);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(100, 23);
            numIdUsuario.TabIndex = 9;
            numIdUsuario.TextChanged += numIdUsuario_TextChanged;
            // 
            // IdUsuario
            // 
            IdUsuario.AutoSize = true;
            IdUsuario.Location = new Point(41, 268);
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Size = new Size(57, 15);
            IdUsuario.TabIndex = 8;
            IdUsuario.Text = "IdUsuario";
            IdUsuario.Click += IdUsuario_Click;
            // 
            // EnviarForm
            // 
            EnviarForm.Location = new Point(311, 9);
            EnviarForm.Name = "EnviarForm";
            EnviarForm.Size = new Size(75, 23);
            EnviarForm.TabIndex = 10;
            EnviarForm.Text = "Agregar";
            EnviarForm.UseVisualStyleBackColor = true;
            EnviarForm.Click += EnviarForm_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSeaGreen;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 42);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(116, 9);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 0;
            label2.Text = "Alta de Productos";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(EnviarForm);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 360);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 45);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(230, 9);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AltaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(399, 405);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(numIdUsuario);
            Controls.Add(IdUsuario);
            Controls.Add(numCosto);
            Controls.Add(costo);
            Controls.Add(numStock);
            Controls.Add(stock);
            Controls.Add(numPrecio);
            Controls.Add(precioVenta);
            Controls.Add(textDescripcion);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AltaProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaProducto";
            Load += AltaProducto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textDescripcion;
        private Label precioVenta;
        private TextBox numPrecio;
        private TextBox numCosto;
        private Label costo;
        private TextBox numStock;
        private Label stock;
        private TextBox numIdUsuario;
        private Label IdUsuario;
        private Button EnviarForm;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Button button1;
    }
}