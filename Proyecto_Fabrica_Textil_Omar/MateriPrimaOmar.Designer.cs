namespace Proyecto_Fabrica_Textil_Omar
{
    partial class MateriPrimaOmar
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
            this.txtNomMateria = new System.Windows.Forms.TextBox();
            this.txtExitencias = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtStockMax = new System.Windows.Forms.TextBox();
            this.cmbUnidadMedida = new System.Windows.Forms.ComboBox();
            this.btnRegMenuOmar = new System.Windows.Forms.Button();
            this.btnInsertarMateriaOmar = new System.Windows.Forms.Button();
            this.tabMateriasOmar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabMateriasOmar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materias Primas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(718, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DE LA MATERIA PRIMA";
            // 
            // txtNomMateria
            // 
            this.txtNomMateria.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomMateria.Location = new System.Drawing.Point(796, 79);
            this.txtNomMateria.Name = "txtNomMateria";
            this.txtNomMateria.Size = new System.Drawing.Size(512, 53);
            this.txtNomMateria.TabIndex = 2;
            // 
            // txtExitencias
            // 
            this.txtExitencias.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExitencias.Location = new System.Drawing.Point(796, 173);
            this.txtExitencias.Name = "txtExitencias";
            this.txtExitencias.Size = new System.Drawing.Size(512, 57);
            this.txtExitencias.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 46);
            this.label3.TabIndex = 4;
            this.label3.Text = "EXISTENCIA MATERIAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 51);
            this.label4.TabIndex = 5;
            this.label4.Text = "STOCK MINIMO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(367, 51);
            this.label5.TabIndex = 6;
            this.label5.Text = "STOCK MAXIMO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(451, 51);
            this.label6.TabIndex = 7;
            this.label6.Text = "UNIDAD DE MEDIDA";
            // 
            // txtStockMin
            // 
            this.txtStockMin.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMin.Location = new System.Drawing.Point(787, 277);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(512, 57);
            this.txtStockMin.TabIndex = 8;
            // 
            // txtStockMax
            // 
            this.txtStockMax.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMax.Location = new System.Drawing.Point(787, 366);
            this.txtStockMax.Name = "txtStockMax";
            this.txtStockMax.Size = new System.Drawing.Size(521, 57);
            this.txtStockMax.TabIndex = 9;
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidadMedida.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnidadMedida.FormattingEnabled = true;
            this.cmbUnidadMedida.Location = new System.Drawing.Point(787, 450);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(521, 59);
            this.cmbUnidadMedida.TabIndex = 10;
            this.cmbUnidadMedida.Click += new System.EventHandler(this.mostrarUnidadMedOmar);
            // 
            // btnRegMenuOmar
            // 
            this.btnRegMenuOmar.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegMenuOmar.Location = new System.Drawing.Point(1336, 283);
            this.btnRegMenuOmar.Name = "btnRegMenuOmar";
            this.btnRegMenuOmar.Size = new System.Drawing.Size(487, 220);
            this.btnRegMenuOmar.TabIndex = 11;
            this.btnRegMenuOmar.Text = "REGRESAR AL MENU";
            this.btnRegMenuOmar.UseVisualStyleBackColor = true;
            this.btnRegMenuOmar.Click += new System.EventHandler(this.btnRegMenuOmar_Click);
            // 
            // btnInsertarMateriaOmar
            // 
            this.btnInsertarMateriaOmar.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarMateriaOmar.Location = new System.Drawing.Point(1336, 79);
            this.btnInsertarMateriaOmar.Name = "btnInsertarMateriaOmar";
            this.btnInsertarMateriaOmar.Size = new System.Drawing.Size(487, 151);
            this.btnInsertarMateriaOmar.TabIndex = 12;
            this.btnInsertarMateriaOmar.Text = "INSERTAR MATERIA";
            this.btnInsertarMateriaOmar.UseVisualStyleBackColor = true;
            this.btnInsertarMateriaOmar.Click += new System.EventHandler(this.btnInsertarMateriaOmar_Click);
            // 
            // tabMateriasOmar
            // 
            this.tabMateriasOmar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabMateriasOmar.Location = new System.Drawing.Point(45, 537);
            this.tabMateriasOmar.Name = "tabMateriasOmar";
            this.tabMateriasOmar.RowHeadersWidth = 51;
            this.tabMateriasOmar.RowTemplate.Height = 24;
            this.tabMateriasOmar.Size = new System.Drawing.Size(1825, 416);
            this.tabMateriasOmar.TabIndex = 13;
            // 
            // MateriPrimaOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 1033);
            this.Controls.Add(this.tabMateriasOmar);
            this.Controls.Add(this.btnInsertarMateriaOmar);
            this.Controls.Add(this.btnRegMenuOmar);
            this.Controls.Add(this.cmbUnidadMedida);
            this.Controls.Add(this.txtStockMax);
            this.Controls.Add(this.txtStockMin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExitencias);
            this.Controls.Add(this.txtNomMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MateriPrimaOmar";
            this.Text = "MateriPrima";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MateriPrimaOmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabMateriasOmar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomMateria;
        private System.Windows.Forms.TextBox txtExitencias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.TextBox txtStockMax;
        private System.Windows.Forms.ComboBox cmbUnidadMedida;
        private System.Windows.Forms.Button btnRegMenuOmar;
        private System.Windows.Forms.Button btnInsertarMateriaOmar;
        private System.Windows.Forms.DataGridView tabMateriasOmar;
    }
}