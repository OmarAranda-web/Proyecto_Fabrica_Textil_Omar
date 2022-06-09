namespace Proyecto_Fabrica_Textil_Omar
{
    partial class DevolucionesOmar
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModPrenda = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnRegMenuOmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabDevolucionOmar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabDevolucionOmar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devoluciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenda";
            // 
            // cmbModPrenda
            // 
            this.cmbModPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModPrenda.FormattingEnabled = true;
            this.cmbModPrenda.Location = new System.Drawing.Point(302, 47);
            this.cmbModPrenda.Name = "cmbModPrenda";
            this.cmbModPrenda.Size = new System.Drawing.Size(121, 24);
            this.cmbModPrenda.TabIndex = 2;
            this.cmbModPrenda.Click += new System.EventHandler(this.mostrarCliente);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "CANTIDAD DE DEVOLUCIONES";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(302, 129);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 4;
            // 
            // btnRegMenuOmar
            // 
            this.btnRegMenuOmar.Location = new System.Drawing.Point(302, 235);
            this.btnRegMenuOmar.Name = "btnRegMenuOmar";
            this.btnRegMenuOmar.Size = new System.Drawing.Size(138, 61);
            this.btnRegMenuOmar.TabIndex = 7;
            this.btnRegMenuOmar.Text = "REGRESAR AL MENU";
            this.btnRegMenuOmar.UseVisualStyleBackColor = true;
            this.btnRegMenuOmar.Click += new System.EventHandler(this.btnRegMenuOmar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "INSERTAR DEVOLUCION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabDevolucionOmar
            // 
            this.tabDevolucionOmar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabDevolucionOmar.Location = new System.Drawing.Point(471, 47);
            this.tabDevolucionOmar.Name = "tabDevolucionOmar";
            this.tabDevolucionOmar.RowHeadersWidth = 51;
            this.tabDevolucionOmar.RowTemplate.Height = 24;
            this.tabDevolucionOmar.Size = new System.Drawing.Size(744, 387);
            this.tabDevolucionOmar.TabIndex = 9;
            // 
            // DevolucionesOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.tabDevolucionOmar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegMenuOmar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbModPrenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DevolucionesOmar";
            this.Text = "Devoluciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DevolucionesOmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabDevolucionOmar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModPrenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnRegMenuOmar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tabDevolucionOmar;
    }
}