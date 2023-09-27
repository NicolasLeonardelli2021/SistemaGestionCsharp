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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 19);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Descripcion";
            label1.Click += label1_Click;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(147, 48);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 1;
            // 
            // precioVenta
            // 
            precioVenta.AutoSize = true;
            precioVenta.Location = new Point(158, 94);
            precioVenta.Name = "precioVenta";
            precioVenta.Size = new Size(72, 15);
            precioVenta.TabIndex = 2;
            precioVenta.Text = "Precio Venta";
            precioVenta.Click += precio_Click;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(147, 121);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(100, 23);
            numPrecio.TabIndex = 3;
            // 
            // numCosto
            // 
            numCosto.Location = new Point(147, 273);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(100, 23);
            numCosto.TabIndex = 7;
            // 
            // costo
            // 
            costo.AutoSize = true;
            costo.Location = new Point(158, 246);
            costo.Name = "costo";
            costo.Size = new Size(38, 15);
            costo.TabIndex = 6;
            costo.Text = "Costo";
            // 
            // numStock
            // 
            numStock.Location = new Point(147, 200);
            numStock.Name = "numStock";
            numStock.Size = new Size(100, 23);
            numStock.TabIndex = 5;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new Point(165, 171);
            stock.Name = "stock";
            stock.Size = new Size(36, 15);
            stock.TabIndex = 4;
            stock.Text = "Stock";
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(147, 353);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(100, 23);
            numIdUsuario.TabIndex = 9;
            // 
            // IdUsuario
            // 
            IdUsuario.AutoSize = true;
            IdUsuario.Location = new Point(158, 326);
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Size = new Size(57, 15);
            IdUsuario.TabIndex = 8;
            IdUsuario.Text = "IdUsuario";
            // 
            // EnviarForm
            // 
            EnviarForm.Location = new Point(155, 404);
            EnviarForm.Name = "EnviarForm";
            EnviarForm.Size = new Size(75, 23);
            EnviarForm.TabIndex = 10;
            EnviarForm.Text = "Enviar";
            EnviarForm.UseVisualStyleBackColor = true;
            EnviarForm.Click += EnviarForm_Click;
            // 
            // AltaProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EnviarForm);
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
            Name = "AltaProducto";
            Text = "AltaProducto";
            Load += AltaProducto_Load;
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
    }
}