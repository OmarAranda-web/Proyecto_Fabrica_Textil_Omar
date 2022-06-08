namespace Proyecto_Fabrica_Textil_Omar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPerdida = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnAsitencias = new System.Windows.Forms.Button();
            this.btnIngresarDetalles = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.btnMateriaPrima = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnPrendas = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(799, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "FABRICA DE ROPA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1945, 76);
            this.panel1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1297, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(186, 100);
            this.panel4.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.btnPrendas);
            this.panel2.Controls.Add(this.btnPedido);
            this.panel2.Controls.Add(this.btnCliente);
            this.panel2.Controls.Add(this.btnVenta);
            this.panel2.Location = new System.Drawing.Point(21, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(664, 963);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Controls.Add(this.btnDevoluciones);
            this.panel3.Controls.Add(this.btnMateriaPrima);
            this.panel3.Controls.Add(this.btnCompra);
            this.panel3.Controls.Add(this.btnProveedor);
            this.panel3.Location = new System.Drawing.Point(682, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 960);
            this.panel3.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnPerdida);
            this.panel5.Controls.Add(this.btnPersonal);
            this.panel5.Controls.Add(this.btnAsitencias);
            this.panel5.Controls.Add(this.btnIngresarDetalles);
            this.panel5.Location = new System.Drawing.Point(1318, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(627, 960);
            this.panel5.TabIndex = 16;
            // 
            // btnPerdida
            // 
            this.btnPerdida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerdida.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerdida.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.sueter2;
            this.btnPerdida.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerdida.Location = new System.Drawing.Point(22, 51);
            this.btnPerdida.Name = "btnPerdida";
            this.btnPerdida.Size = new System.Drawing.Size(593, 167);
            this.btnPerdida.TabIndex = 11;
            this.btnPerdida.Text = "INSERTAR PERDIDA";
            this.btnPerdida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPerdida.UseVisualStyleBackColor = true;
            this.btnPerdida.Click += new System.EventHandler(this.btnPerdida_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.vestido;
            this.btnPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonal.Location = new System.Drawing.Point(22, 277);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(593, 167);
            this.btnPersonal.TabIndex = 12;
            this.btnPersonal.Text = "INSERTAR PERSONAL";
            this.btnPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnAsitencias
            // 
            this.btnAsitencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAsitencias.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsitencias.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.vestido2;
            this.btnAsitencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsitencias.Location = new System.Drawing.Point(22, 491);
            this.btnAsitencias.Name = "btnAsitencias";
            this.btnAsitencias.Size = new System.Drawing.Size(593, 167);
            this.btnAsitencias.TabIndex = 13;
            this.btnAsitencias.Text = "INSERTAR ASISTENCIAS";
            this.btnAsitencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsitencias.UseVisualStyleBackColor = true;
            this.btnAsitencias.Click += new System.EventHandler(this.btnAsitencias_Click);
            // 
            // btnIngresarDetalles
            // 
            this.btnIngresarDetalles.BackColor = System.Drawing.SystemColors.Info;
            this.btnIngresarDetalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarDetalles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresarDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarDetalles.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.icono_fa;
            this.btnIngresarDetalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngresarDetalles.Location = new System.Drawing.Point(131, 712);
            this.btnIngresarDetalles.Name = "btnIngresarDetalles";
            this.btnIngresarDetalles.Size = new System.Drawing.Size(387, 128);
            this.btnIngresarDetalles.TabIndex = 0;
            this.btnIngresarDetalles.Text = "INGRESAR DETALLES DE FABRICA";
            this.btnIngresarDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIngresarDetalles.UseVisualStyleBackColor = false;
            this.btnIngresarDetalles.Click += new System.EventHandler(this.btnIngresarDetalles_Click);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevoluciones.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevoluciones.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.sueter;
            this.btnDevoluciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevoluciones.Location = new System.Drawing.Point(23, 51);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(593, 167);
            this.btnDevoluciones.TabIndex = 7;
            this.btnDevoluciones.Text = "DEVOLUCIONES";
            this.btnDevoluciones.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // btnMateriaPrima
            // 
            this.btnMateriaPrima.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMateriaPrima.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMateriaPrima.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.shorts;
            this.btnMateriaPrima.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMateriaPrima.Location = new System.Drawing.Point(23, 277);
            this.btnMateriaPrima.Name = "btnMateriaPrima";
            this.btnMateriaPrima.Size = new System.Drawing.Size(593, 167);
            this.btnMateriaPrima.TabIndex = 8;
            this.btnMateriaPrima.Text = "INSERTAR MATERIA PRIMA ";
            this.btnMateriaPrima.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMateriaPrima.UseVisualStyleBackColor = true;
            this.btnMateriaPrima.Click += new System.EventHandler(this.btnMateriaPrima_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompra.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompra.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.saco;
            this.btnCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompra.Location = new System.Drawing.Point(23, 491);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(593, 167);
            this.btnCompra.TabIndex = 9;
            this.btnCompra.Text = "INSERTAR COMPRA";
            this.btnCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedor.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.playera2;
            this.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.Location = new System.Drawing.Point(23, 676);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(593, 179);
            this.btnProveedor.TabIndex = 10;
            this.btnProveedor.Text = "INSERTAR PROVEEDOR";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProveedor.UseVisualStyleBackColor = true;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnPrendas
            // 
            this.btnPrendas.BackColor = System.Drawing.Color.Transparent;
            this.btnPrendas.BackgroundImage = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.insertarPrenda11;
            this.btnPrendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrendas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrendas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrendas.FlatAppearance.BorderSize = 0;
            this.btnPrendas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrendas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrendas.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrendas.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrendas.Location = new System.Drawing.Point(3, 16);
            this.btnPrendas.Name = "btnPrendas";
            this.btnPrendas.Size = new System.Drawing.Size(658, 202);
            this.btnPrendas.TabIndex = 3;
            this.btnPrendas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrendas.UseVisualStyleBackColor = false;
            this.btnPrendas.Click += new System.EventHandler(this.btnPrendas_Click);
            this.btnPrendas.MouseLeave += new System.EventHandler(this.imagen1MoiNSERTAR);
            this.btnPrendas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imagen2MoInsertar);
            // 
            // btnPedido
            // 
            this.btnPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedido.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.vestido3;
            this.btnPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedido.Location = new System.Drawing.Point(38, 277);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(602, 167);
            this.btnPedido.TabIndex = 4;
            this.btnPedido.Text = "INSERTAR PEDIDO";
            this.btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.pantalon;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(38, 491);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(602, 167);
            this.btnCliente.TabIndex = 5;
            this.btnCliente.Text = "INSERTAR CLIENTE";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVenta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.Image = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.playera;
            this.btnVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVenta.Location = new System.Drawing.Point(47, 682);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(593, 167);
            this.btnVenta.TabIndex = 6;
            this.btnVenta.Text = "INSERTAR VENTA";
            this.btnVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Inicio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngresarDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPrendas;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnDevoluciones;
        private System.Windows.Forms.Button btnMateriaPrima;
        private System.Windows.Forms.Button btnCompra;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnPerdida;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnAsitencias;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnVenta;
    }
}

