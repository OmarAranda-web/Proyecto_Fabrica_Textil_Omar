namespace Proyecto_Fabrica_Textil_Omar
{
    partial class prendaOmar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prendaOmar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombrePrenda = new System.Windows.Forms.TextBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnRegresarMenu = new System.Windows.Forms.Button();
            this.btnInsertarPrenda = new System.Windows.Forms.Button();
            this.tabMostrarPrendas = new System.Windows.Forms.DataGridView();
            this.btnDetallesPrenda = new System.Windows.Forms.Button();
            this.btnRegPagAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabMostrarPrendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1098, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(818, 93);
            this.label1.TabIndex = 0;
            this.label1.Text = "INSERTAR PRENDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DE LA PRENDA ";
            // 
            // txtNombrePrenda
            // 
            this.txtNombrePrenda.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePrenda.Location = new System.Drawing.Point(641, 153);
            this.txtNombrePrenda.Name = "txtNombrePrenda";
            this.txtNombrePrenda.Size = new System.Drawing.Size(511, 57);
            this.txtNombrePrenda.TabIndex = 2;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(1168, 153);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(243, 51);
            this.lblMaterial.TabIndex = 3;
            this.lblMaterial.Text = "MATERIAL";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(1428, 150);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(479, 59);
            this.cmbMaterial.TabIndex = 4;
            this.cmbMaterial.Click += new System.EventHandler(this.mostrarMateriales);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(641, 294);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(511, 59);
            this.cmbCategoria.TabIndex = 5;
            this.cmbCategoria.Click += new System.EventHandler(this.mostrarCategorias);
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(1428, 285);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(479, 59);
            this.cmbColor.TabIndex = 6;
            this.cmbColor.Click += new System.EventHandler(this.mostrarColor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(608, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "CATEGORÍA DE LA PRENDA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1227, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 51);
            this.label4.TabIndex = 8;
            this.label4.Text = "COLOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 51);
            this.label5.TabIndex = 9;
            this.label5.Text = "PRECIO";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(641, 445);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(511, 57);
            this.txtPrecio.TabIndex = 10;
            // 
            // btnRegresarMenu
            // 
            this.btnRegresarMenu.Location = new System.Drawing.Point(1607, 404);
            this.btnRegresarMenu.Name = "btnRegresarMenu";
            this.btnRegresarMenu.Size = new System.Drawing.Size(129, 69);
            this.btnRegresarMenu.TabIndex = 11;
            this.btnRegresarMenu.Text = "REGRESAR AL MENU";
            this.btnRegresarMenu.UseVisualStyleBackColor = true;
            this.btnRegresarMenu.Click += new System.EventHandler(this.btnRegresarMenu_Click);
            // 
            // btnInsertarPrenda
            // 
            this.btnInsertarPrenda.Location = new System.Drawing.Point(1428, 404);
            this.btnInsertarPrenda.Name = "btnInsertarPrenda";
            this.btnInsertarPrenda.Size = new System.Drawing.Size(142, 69);
            this.btnInsertarPrenda.TabIndex = 12;
            this.btnInsertarPrenda.Text = "INSERTAR PRENDA";
            this.btnInsertarPrenda.UseVisualStyleBackColor = true;
            this.btnInsertarPrenda.Click += new System.EventHandler(this.btnInsertarPrenda_Click);
            // 
            // tabMostrarPrendas
            // 
            this.tabMostrarPrendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabMostrarPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabMostrarPrendas.Location = new System.Drawing.Point(12, 564);
            this.tabMostrarPrendas.Name = "tabMostrarPrendas";
            this.tabMostrarPrendas.RowHeadersWidth = 51;
            this.tabMostrarPrendas.RowTemplate.Height = 24;
            this.tabMostrarPrendas.Size = new System.Drawing.Size(1877, 349);
            this.tabMostrarPrendas.TabIndex = 13;
            // 
            // btnDetallesPrenda
            // 
            this.btnDetallesPrenda.Location = new System.Drawing.Point(1236, 404);
            this.btnDetallesPrenda.Name = "btnDetallesPrenda";
            this.btnDetallesPrenda.Size = new System.Drawing.Size(161, 69);
            this.btnDetallesPrenda.TabIndex = 14;
            this.btnDetallesPrenda.Text = "INSERTAR DETALLES DE PRENDA";
            this.btnDetallesPrenda.UseVisualStyleBackColor = true;
            this.btnDetallesPrenda.Click += new System.EventHandler(this.btnDetallesPrenda_Click);
            // 
            // btnRegPagAnterior
            // 
            this.btnRegPagAnterior.Location = new System.Drawing.Point(1768, 404);
            this.btnRegPagAnterior.Name = "btnRegPagAnterior";
            this.btnRegPagAnterior.Size = new System.Drawing.Size(139, 69);
            this.btnRegPagAnterior.TabIndex = 15;
            this.btnRegPagAnterior.Text = "Regresar";
            this.btnRegPagAnterior.UseVisualStyleBackColor = true;
            this.btnRegPagAnterior.Click += new System.EventHandler(this.btnRegPagAnterior_Click);
            // 
            // prendaOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 953);
            this.Controls.Add(this.btnRegPagAnterior);
            this.Controls.Add(this.btnDetallesPrenda);
            this.Controls.Add(this.tabMostrarPrendas);
            this.Controls.Add(this.btnInsertarPrenda);
            this.Controls.Add(this.btnRegresarMenu);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.txtNombrePrenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "prendaOmar";
            this.Text = "Insertar Detalles dePrenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.prenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabMostrarPrendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombrePrenda;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnRegresarMenu;
        private System.Windows.Forms.Button btnInsertarPrenda;
        private System.Windows.Forms.DataGridView tabMostrarPrendas;
        private System.Windows.Forms.Button btnDetallesPrenda;
        private System.Windows.Forms.Button btnRegPagAnterior;
    }
}