namespace Proyecto_Fabrica_Textil_Omar
{
    partial class VentaOmar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            this.flPanelClientes = new System.Windows.Forms.FlowLayoutPanel();
            this.flpanelCategoria = new System.Windows.Forms.FlowLayoutPanel();
            this.taaVentas = new System.Windows.Forms.DataGridView();
            this.lblnomCliente = new System.Windows.Forms.Label();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblClientCate = new System.Windows.Forms.Label();
            this.btnRegClientes = new System.Windows.Forms.Button();
            this.lblDetaVenta = new System.Windows.Forms.Label();
            this.lblTotalVenta = new System.Windows.Forms.Label();
            this.lblcantiVenta = new System.Windows.Forms.Label();
            this.btnBuscarPrend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venta";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(301, 55);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(66, 16);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.Location = new System.Drawing.Point(884, 794);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(180, 73);
            this.btnRegresarMenu.TabIndex = 3;
            this.btnRegresarMenu.Text = "REGRESAR AL MENU";
            this.btnRegresarMenu.UseVisualStyleBackColor = true;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // flPanelClientes
            // 
            this.flPanelClientes.AutoScroll = true;
            this.flPanelClientes.Location = new System.Drawing.Point(304, 287);
            this.flPanelClientes.Name = "flPanelClientes";
            this.flPanelClientes.Size = new System.Drawing.Size(771, 227);
            this.flPanelClientes.TabIndex = 4;
            // 
            // flpanelCategoria
            // 
            this.flpanelCategoria.Location = new System.Drawing.Point(304, 111);
            this.flpanelCategoria.Name = "flpanelCategoria";
            this.flpanelCategoria.Size = new System.Drawing.Size(771, 86);
            this.flpanelCategoria.TabIndex = 5;
            // 
            // taaVentas
            // 
            this.taaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taaVentas.Location = new System.Drawing.Point(304, 549);
            this.taaVentas.Name = "taaVentas";
            this.taaVentas.RowHeadersWidth = 51;
            this.taaVentas.RowTemplate.Height = 24;
            this.taaVentas.Size = new System.Drawing.Size(760, 169);
            this.taaVentas.TabIndex = 6;
            this.taaVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seleccionar_folios);
            // 
            // lblnomCliente
            // 
            this.lblnomCliente.AutoSize = true;
            this.lblnomCliente.Location = new System.Drawing.Point(371, 55);
            this.lblnomCliente.Name = "lblnomCliente";
            this.lblnomCliente.Size = new System.Drawing.Size(44, 16);
            this.lblnomCliente.TabIndex = 7;
            this.lblnomCliente.Text = "label3";
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(304, 89);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(73, 16);
            this.lblCategorias.TabIndex = 8;
            this.lblCategorias.Text = "Categorias";
            // 
            // lblClientCate
            // 
            this.lblClientCate.AutoSize = true;
            this.lblClientCate.Location = new System.Drawing.Point(293, 268);
            this.lblClientCate.Name = "lblClientCate";
            this.lblClientCate.Size = new System.Drawing.Size(110, 16);
            this.lblClientCate.TabIndex = 9;
            this.lblClientCate.Text = "Clientes/Prendas";
            // 
            // btnRegClientes
            // 
            this.btnRegClientes.Location = new System.Drawing.Point(708, 794);
            this.btnRegClientes.Name = "btnRegClientes";
            this.btnRegClientes.Size = new System.Drawing.Size(117, 73);
            this.btnRegClientes.TabIndex = 10;
            this.btnRegClientes.Text = "Clientes";
            this.btnRegClientes.UseVisualStyleBackColor = true;
            this.btnRegClientes.Click += new System.EventHandler(this.btnRegClientes_Click);
            // 
            // lblDetaVenta
            // 
            this.lblDetaVenta.AutoSize = true;
            this.lblDetaVenta.Location = new System.Drawing.Point(304, 521);
            this.lblDetaVenta.Name = "lblDetaVenta";
            this.lblDetaVenta.Size = new System.Drawing.Size(114, 16);
            this.lblDetaVenta.TabIndex = 11;
            this.lblDetaVenta.Text = "Detalles de Venta";
            // 
            // lblTotalVenta
            // 
            this.lblTotalVenta.AutoSize = true;
            this.lblTotalVenta.Location = new System.Drawing.Point(881, 738);
            this.lblTotalVenta.Name = "lblTotalVenta";
            this.lblTotalVenta.Size = new System.Drawing.Size(95, 16);
            this.lblTotalVenta.TabIndex = 12;
            this.lblTotalVenta.Text = "Total de Venta";
            // 
            // lblcantiVenta
            // 
            this.lblcantiVenta.AutoSize = true;
            this.lblcantiVenta.Location = new System.Drawing.Point(991, 738);
            this.lblcantiVenta.Name = "lblcantiVenta";
            this.lblcantiVenta.Size = new System.Drawing.Size(14, 16);
            this.lblcantiVenta.TabIndex = 13;
            this.lblcantiVenta.Text = "0";
            // 
            // btnBuscarPrend
            // 
            this.btnBuscarPrend.Location = new System.Drawing.Point(917, 66);
            this.btnBuscarPrend.Name = "btnBuscarPrend";
            this.btnBuscarPrend.Size = new System.Drawing.Size(158, 23);
            this.btnBuscarPrend.TabIndex = 14;
            this.btnBuscarPrend.Text = "Buscar Prenda";
            this.btnBuscarPrend.UseVisualStyleBackColor = true;
            this.btnBuscarPrend.Click += new System.EventHandler(this.btnBuscarPrend_Click);
            // 
            // VentaOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.btnBuscarPrend);
            this.Controls.Add(this.lblcantiVenta);
            this.Controls.Add(this.lblTotalVenta);
            this.Controls.Add(this.lblDetaVenta);
            this.Controls.Add(this.btnRegClientes);
            this.Controls.Add(this.lblClientCate);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.lblnomCliente);
            this.Controls.Add(this.taaVentas);
            this.Controls.Add(this.flpanelCategoria);
            this.Controls.Add(this.flPanelClientes);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Name = "VentaOmar";
            this.Text = "Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VentaOmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taaVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnRegresarMenu;
        private System.Windows.Forms.FlowLayoutPanel flPanelClientes;
        private System.Windows.Forms.FlowLayoutPanel flpanelCategoria;
        private System.Windows.Forms.DataGridView taaVentas;
        private System.Windows.Forms.Label lblnomCliente;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblClientCate;
        private System.Windows.Forms.Button btnRegClientes;
        private System.Windows.Forms.Label lblDetaVenta;
        private System.Windows.Forms.Label lblTotalVenta;
        private System.Windows.Forms.Label lblcantiVenta;
        private System.Windows.Forms.Button btnBuscarPrend;
    }
}