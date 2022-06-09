namespace Proyecto_Fabrica_Textil_Omar
{
    partial class PerdidasOmar
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMateriaOmar = new System.Windows.Forms.ComboBox();
            this.cmbRFCOmar = new System.Windows.Forms.ComboBox();
            this.txtCantiPerd = new System.Windows.Forms.TextBox();
            this.txtObservaPerd = new System.Windows.Forms.TextBox();
            this.btnRegMenOmar = new System.Windows.Forms.Button();
            this.btnPerdidaPrendOmar = new System.Windows.Forms.Button();
            this.tabPerdidasOmar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPerdidasOmar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(700, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perdidas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MATERIA PRIMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CANTIDAD DE LA PERDIDA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "OBSERVACIONES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "RFC DEL PERSONAL";
            // 
            // cmbMateriaOmar
            // 
            this.cmbMateriaOmar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaOmar.FormattingEnabled = true;
            this.cmbMateriaOmar.Location = new System.Drawing.Point(292, 68);
            this.cmbMateriaOmar.Name = "cmbMateriaOmar";
            this.cmbMateriaOmar.Size = new System.Drawing.Size(121, 24);
            this.cmbMateriaOmar.TabIndex = 6;
            this.cmbMateriaOmar.Click += new System.EventHandler(this.mostrarMateriaOmar);
            // 
            // cmbRFCOmar
            // 
            this.cmbRFCOmar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRFCOmar.FormattingEnabled = true;
            this.cmbRFCOmar.Location = new System.Drawing.Point(292, 190);
            this.cmbRFCOmar.Name = "cmbRFCOmar";
            this.cmbRFCOmar.Size = new System.Drawing.Size(121, 24);
            this.cmbRFCOmar.TabIndex = 7;
            this.cmbRFCOmar.Click += new System.EventHandler(this.mostrarRFCOmar);
            // 
            // txtCantiPerd
            // 
            this.txtCantiPerd.Location = new System.Drawing.Point(292, 105);
            this.txtCantiPerd.Name = "txtCantiPerd";
            this.txtCantiPerd.Size = new System.Drawing.Size(100, 22);
            this.txtCantiPerd.TabIndex = 9;
            // 
            // txtObservaPerd
            // 
            this.txtObservaPerd.Location = new System.Drawing.Point(292, 149);
            this.txtObservaPerd.Name = "txtObservaPerd";
            this.txtObservaPerd.Size = new System.Drawing.Size(100, 22);
            this.txtObservaPerd.TabIndex = 10;
            // 
            // btnRegMenOmar
            // 
            this.btnRegMenOmar.Location = new System.Drawing.Point(292, 290);
            this.btnRegMenOmar.Name = "btnRegMenOmar";
            this.btnRegMenOmar.Size = new System.Drawing.Size(121, 77);
            this.btnRegMenOmar.TabIndex = 11;
            this.btnRegMenOmar.Text = "REGRESAR AL MENU";
            this.btnRegMenOmar.UseVisualStyleBackColor = true;
            this.btnRegMenOmar.Click += new System.EventHandler(this.btnRegMenOmar_Click);
            // 
            // btnPerdidaPrendOmar
            // 
            this.btnPerdidaPrendOmar.Location = new System.Drawing.Point(97, 290);
            this.btnPerdidaPrendOmar.Name = "btnPerdidaPrendOmar";
            this.btnPerdidaPrendOmar.Size = new System.Drawing.Size(118, 54);
            this.btnPerdidaPrendOmar.TabIndex = 12;
            this.btnPerdidaPrendOmar.Text = "INSERTAR PERDIDA";
            this.btnPerdidaPrendOmar.UseVisualStyleBackColor = true;
            this.btnPerdidaPrendOmar.Click += new System.EventHandler(this.btnPerdidaPrendOmar_Click);
            // 
            // tabPerdidasOmar
            // 
            this.tabPerdidasOmar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabPerdidasOmar.Location = new System.Drawing.Point(475, 92);
            this.tabPerdidasOmar.Name = "tabPerdidasOmar";
            this.tabPerdidasOmar.RowHeadersWidth = 51;
            this.tabPerdidasOmar.RowTemplate.Height = 24;
            this.tabPerdidasOmar.Size = new System.Drawing.Size(977, 391);
            this.tabPerdidasOmar.TabIndex = 13;
            // 
            // PerdidasOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.tabPerdidasOmar);
            this.Controls.Add(this.btnPerdidaPrendOmar);
            this.Controls.Add(this.btnRegMenOmar);
            this.Controls.Add(this.txtObservaPerd);
            this.Controls.Add(this.txtCantiPerd);
            this.Controls.Add(this.cmbRFCOmar);
            this.Controls.Add(this.cmbMateriaOmar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PerdidasOmar";
            this.Text = "Perdidas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PerdidasOmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPerdidasOmar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMateriaOmar;
        private System.Windows.Forms.ComboBox cmbRFCOmar;
        private System.Windows.Forms.TextBox txtCantiPerd;
        private System.Windows.Forms.TextBox txtObservaPerd;
        private System.Windows.Forms.Button btnRegMenOmar;
        private System.Windows.Forms.Button btnPerdidaPrendOmar;
        private System.Windows.Forms.DataGridView tabPerdidasOmar;
    }
}