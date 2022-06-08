namespace Proyecto_Fabrica_Textil_Omar
{
    partial class AsitenciasOmar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegMenOmar = new System.Windows.Forms.Button();
            this.txxFechEntradaOmar = new System.Windows.Forms.TextBox();
            this.txxFechSalidaOmar = new System.Windows.Forms.TextBox();
            this.txtUnidOmar = new System.Windows.Forms.TextBox();
            this.cmbRFCPerOmar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asitencias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "FECHA Y HORA DE ENTRADA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA Y HORA DE SALIDA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "RFC DEL PERSONAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "UNIDADES ELABORADAS";
            // 
            // btnRegMenOmar
            // 
            this.btnRegMenOmar.Location = new System.Drawing.Point(75, 306);
            this.btnRegMenOmar.Name = "btnRegMenOmar";
            this.btnRegMenOmar.Size = new System.Drawing.Size(143, 70);
            this.btnRegMenOmar.TabIndex = 5;
            this.btnRegMenOmar.Text = "REGRESAR AL MENU";
            this.btnRegMenOmar.UseVisualStyleBackColor = true;
            this.btnRegMenOmar.Click += new System.EventHandler(this.btnRegMenOmar_Click);
            // 
            // txxFechEntradaOmar
            // 
            this.txxFechEntradaOmar.Location = new System.Drawing.Point(341, 86);
            this.txxFechEntradaOmar.Name = "txxFechEntradaOmar";
            this.txxFechEntradaOmar.Size = new System.Drawing.Size(121, 22);
            this.txxFechEntradaOmar.TabIndex = 6;
            // 
            // txxFechSalidaOmar
            // 
            this.txxFechSalidaOmar.Location = new System.Drawing.Point(341, 131);
            this.txxFechSalidaOmar.Name = "txxFechSalidaOmar";
            this.txxFechSalidaOmar.Size = new System.Drawing.Size(121, 22);
            this.txxFechSalidaOmar.TabIndex = 7;
            // 
            // txtUnidOmar
            // 
            this.txtUnidOmar.Location = new System.Drawing.Point(341, 238);
            this.txtUnidOmar.Name = "txtUnidOmar";
            this.txtUnidOmar.Size = new System.Drawing.Size(100, 22);
            this.txtUnidOmar.TabIndex = 8;
            // 
            // cmbRFCPerOmar
            // 
            this.cmbRFCPerOmar.FormattingEnabled = true;
            this.cmbRFCPerOmar.Location = new System.Drawing.Point(341, 187);
            this.cmbRFCPerOmar.Name = "cmbRFCPerOmar";
            this.cmbRFCPerOmar.Size = new System.Drawing.Size(121, 24);
            this.cmbRFCPerOmar.TabIndex = 9;
            this.cmbRFCPerOmar.Click += new System.EventHandler(this.mostrarRFCPerOmar);
            // 
            // AsitenciasOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.cmbRFCPerOmar);
            this.Controls.Add(this.txtUnidOmar);
            this.Controls.Add(this.txxFechSalidaOmar);
            this.Controls.Add(this.txxFechEntradaOmar);
            this.Controls.Add(this.btnRegMenOmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AsitenciasOmar";
            this.Text = "Asitencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AsitenciasOmar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegMenOmar;
        private System.Windows.Forms.TextBox txxFechEntradaOmar;
        private System.Windows.Forms.TextBox txxFechSalidaOmar;
        private System.Windows.Forms.TextBox txtUnidOmar;
        private System.Windows.Forms.ComboBox cmbRFCPerOmar;
    }
}