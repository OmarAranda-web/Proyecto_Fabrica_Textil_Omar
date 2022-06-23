namespace Proyecto_Fabrica_Textil_Omar
{
    partial class CompraOmar
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
            this.lblCompra = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnRegMenOmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolioCompra = new System.Windows.Forms.TextBox();
            this.flpanelProveedores = new System.Windows.Forms.FlowLayoutPanel();
            this.tabCompras = new System.Windows.Forms.DataGridView();
            this.lblnomProvedor = new System.Windows.Forms.Label();
            this.lbllcompra = new System.Windows.Forms.Label();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Location = new System.Drawing.Point(667, 13);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(55, 16);
            this.lblCompra.TabIndex = 0;
            this.lblCompra.Text = "Compra";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(118, 85);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(93, 16);
            this.lblProveedor.TabIndex = 1;
            this.lblProveedor.Text = "PROVEEDOR";
            // 
            // btnRegMenOmar
            // 
            this.btnRegMenOmar.Location = new System.Drawing.Point(1013, 782);
            this.btnRegMenOmar.Name = "btnRegMenOmar";
            this.btnRegMenOmar.Size = new System.Drawing.Size(114, 52);
            this.btnRegMenOmar.TabIndex = 3;
            this.btnRegMenOmar.Text = "REGRESAR AL MENU";
            this.btnRegMenOmar.UseVisualStyleBackColor = true;
            this.btnRegMenOmar.Click += new System.EventHandler(this.btnRegMenOmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "FOLIO DE COMPRA ";
            // 
            // txtFolioCompra
            // 
            this.txtFolioCompra.Location = new System.Drawing.Point(743, 68);
            this.txtFolioCompra.Name = "txtFolioCompra";
            this.txtFolioCompra.Size = new System.Drawing.Size(147, 22);
            this.txtFolioCompra.TabIndex = 5;
            // 
            // flpanelProveedores
            // 
            this.flpanelProveedores.AutoScroll = true;
            this.flpanelProveedores.Location = new System.Drawing.Point(121, 123);
            this.flpanelProveedores.Name = "flpanelProveedores";
            this.flpanelProveedores.Size = new System.Drawing.Size(1006, 327);
            this.flpanelProveedores.TabIndex = 6;
            // 
            // tabCompras
            // 
            this.tabCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabCompras.Location = new System.Drawing.Point(121, 522);
            this.tabCompras.Name = "tabCompras";
            this.tabCompras.RowHeadersWidth = 51;
            this.tabCompras.RowTemplate.Height = 24;
            this.tabCompras.Size = new System.Drawing.Size(1006, 150);
            this.tabCompras.TabIndex = 7;
            // 
            // lblnomProvedor
            // 
            this.lblnomProvedor.AutoSize = true;
            this.lblnomProvedor.Location = new System.Drawing.Point(232, 85);
            this.lblnomProvedor.Name = "lblnomProvedor";
            this.lblnomProvedor.Size = new System.Drawing.Size(44, 16);
            this.lblnomProvedor.TabIndex = 8;
            this.lblnomProvedor.Text = "label1";
            // 
            // lbllcompra
            // 
            this.lbllcompra.AutoSize = true;
            this.lbllcompra.Location = new System.Drawing.Point(118, 478);
            this.lbllcompra.Name = "lbllcompra";
            this.lbllcompra.Size = new System.Drawing.Size(74, 16);
            this.lbllcompra.TabIndex = 9;
            this.lbllcompra.Text = "COMPRAS";
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.Location = new System.Drawing.Point(829, 730);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(153, 16);
            this.lblTotalCompra.TabIndex = 10;
            this.lblTotalCompra.Text = "TOTAL DE LA COMPRA";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1010, 730);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(32, 16);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "total";
            // 
            // CompraOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.lbllcompra);
            this.Controls.Add(this.lblnomProvedor);
            this.Controls.Add(this.tabCompras);
            this.Controls.Add(this.flpanelProveedores);
            this.Controls.Add(this.txtFolioCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegMenOmar);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblCompra);
            this.Name = "CompraOmar";
            this.Text = "Compra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompraOmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnRegMenOmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFolioCompra;
        private System.Windows.Forms.FlowLayoutPanel flpanelProveedores;
        private System.Windows.Forms.DataGridView tabCompras;
        private System.Windows.Forms.Label lblnomProvedor;
        private System.Windows.Forms.Label lbllcompra;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.Label lblTotal;
    }
}