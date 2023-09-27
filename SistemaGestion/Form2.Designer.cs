namespace SistemaGestion
{
    partial class FormModificar
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
            EnviarModif = new Button();
            numIdUsuario = new TextBox();
            IdUsuario = new Label();
            numCosto = new TextBox();
            costo = new Label();
            numStock = new TextBox();
            stock = new Label();
            numPrecio = new TextBox();
            precioVenta = new Label();
            textDescripcion = new TextBox();
            SuspendLayout();
            // 
            // EnviarModif
            // 
            EnviarModif.Location = new Point(358, 392);
            EnviarModif.Name = "EnviarModif";
            EnviarModif.Size = new Size(75, 23);
            EnviarModif.TabIndex = 20;
            EnviarModif.Text = "Enviar";
            EnviarModif.UseVisualStyleBackColor = true;
            EnviarModif.Click += EnviarModif_Click;
            // 
            // numIdUsuario
            // 
            numIdUsuario.Location = new Point(350, 341);
            numIdUsuario.Name = "numIdUsuario";
            numIdUsuario.Size = new Size(100, 23);
            numIdUsuario.TabIndex = 19;
            // 
            // IdUsuario
            // 
            IdUsuario.AutoSize = true;
            IdUsuario.Location = new Point(361, 314);
            IdUsuario.Name = "IdUsuario";
            IdUsuario.Size = new Size(57, 15);
            IdUsuario.TabIndex = 18;
            IdUsuario.Text = "IdUsuario";
            // 
            // numCosto
            // 
            numCosto.Location = new Point(350, 261);
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(100, 23);
            numCosto.TabIndex = 17;
            // 
            // costo
            // 
            costo.AutoSize = true;
            costo.Location = new Point(361, 234);
            costo.Name = "costo";
            costo.Size = new Size(38, 15);
            costo.TabIndex = 16;
            costo.Text = "Costo";
            // 
            // numStock
            // 
            numStock.Location = new Point(350, 188);
            numStock.Name = "numStock";
            numStock.Size = new Size(100, 23);
            numStock.TabIndex = 15;
            // 
            // stock
            // 
            stock.AutoSize = true;
            stock.Location = new Point(368, 159);
            stock.Name = "stock";
            stock.Size = new Size(36, 15);
            stock.TabIndex = 14;
            stock.Text = "Stock";
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(350, 109);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(100, 23);
            numPrecio.TabIndex = 13;
            // 
            // precioVenta
            // 
            precioVenta.AutoSize = true;
            precioVenta.Location = new Point(361, 82);
            precioVenta.Name = "precioVenta";
            precioVenta.Size = new Size(72, 15);
            precioVenta.TabIndex = 12;
            precioVenta.Text = "Precio Venta";
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(350, 36);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(100, 23);
            textDescripcion.TabIndex = 11;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EnviarModif);
            Controls.Add(numIdUsuario);
            Controls.Add(IdUsuario);
            Controls.Add(numCosto);
            Controls.Add(costo);
            Controls.Add(numStock);
            Controls.Add(stock);
            Controls.Add(numPrecio);
            Controls.Add(precioVenta);
            Controls.Add(textDescripcion);
            Name = "FormModificar";
            Text = "Modificar";
            Load += FormModificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnviarModif;
        private TextBox numIdUsuario;
        private Label IdUsuario;
        private TextBox numCosto;
        private Label costo;
        private TextBox numStock;
        private Label stock;
        private TextBox numPrecio;
        private Label precioVenta;
        private TextBox textDescripcion;
    }
}