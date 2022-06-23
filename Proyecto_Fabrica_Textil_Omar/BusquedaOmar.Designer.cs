namespace Proyecto_Fabrica_Textil_Omar
{
    partial class BusquedaOmar
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenda = new System.Windows.Forms.TextBox();
            this.tabBusqueda = new System.Windows.Forms.DataGridView();
            this.btnRegBus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(470, 19);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(174, 16);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "BUSQEUDA DE PRENDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Coloque el nombre o caracter";
            // 
            // txtPrenda
            // 
            this.txtPrenda.Location = new System.Drawing.Point(333, 102);
            this.txtPrenda.Name = "txtPrenda";
            this.txtPrenda.Size = new System.Drawing.Size(100, 22);
            this.txtPrenda.TabIndex = 3;
            this.txtPrenda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buscarProducto);
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabBusqueda.Location = new System.Drawing.Point(109, 155);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.RowHeadersWidth = 51;
            this.tabBusqueda.RowTemplate.Height = 24;
            this.tabBusqueda.Size = new System.Drawing.Size(984, 270);
            this.tabBusqueda.TabIndex = 4;
            // 
            // btnRegBus
            // 
            this.btnRegBus.Location = new System.Drawing.Point(694, 101);
            this.btnRegBus.Name = "btnRegBus";
            this.btnRegBus.Size = new System.Drawing.Size(99, 32);
            this.btnRegBus.TabIndex = 6;
            this.btnRegBus.Text = "Regresar";
            this.btnRegBus.UseVisualStyleBackColor = true;
            this.btnRegBus.Click += new System.EventHandler(this.evenRegresar);
            // 
            // BusquedaOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 516);
            this.Controls.Add(this.btnRegBus);
            this.Controls.Add(this.tabBusqueda);
            this.Controls.Add(this.txtPrenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbltitulo);
            this.Name = "BusquedaOmar";
            this.Text = "BusquedaOmar";
            this.Load += new System.EventHandler(this.BusquedaOmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrenda;
        private System.Windows.Forms.DataGridView tabBusqueda;
        private System.Windows.Forms.Button btnRegBus;
    }
}