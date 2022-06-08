namespace Proyecto_Fabrica_Textil_Omar
{
    partial class PedidoOmar
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
            this.cmbModeloPrenda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnMenuOmar = new System.Windows.Forms.Button();
            this.txtcantidadProd = new System.Windows.Forms.TextBox();
            this.btnInsertarPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(878, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DE PRENDA";
            // 
            // cmbModeloPrenda
            // 
            this.cmbModeloPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModeloPrenda.FormattingEnabled = true;
            this.cmbModeloPrenda.Location = new System.Drawing.Point(237, 77);
            this.cmbModeloPrenda.Name = "cmbModeloPrenda";
            this.cmbModeloPrenda.Size = new System.Drawing.Size(121, 24);
            this.cmbModeloPrenda.TabIndex = 2;
            this.cmbModeloPrenda.Click += new System.EventHandler(this.mostrarModeloPrenda);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad del Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Razon Social del Cliente";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Click += new System.EventHandler(this.mostrarClientes);
            // 
            // btnMenuOmar
            // 
            this.btnMenuOmar.Location = new System.Drawing.Point(539, 366);
            this.btnMenuOmar.Name = "btnMenuOmar";
            this.btnMenuOmar.Size = new System.Drawing.Size(145, 69);
            this.btnMenuOmar.TabIndex = 7;
            this.btnMenuOmar.Text = "REGRESAR AL MENU";
            this.btnMenuOmar.UseVisualStyleBackColor = true;
            this.btnMenuOmar.Click += new System.EventHandler(this.btnMenuOmar_Click);
            // 
            // txtcantidadProd
            // 
            this.txtcantidadProd.Location = new System.Drawing.Point(237, 178);
            this.txtcantidadProd.Name = "txtcantidadProd";
            this.txtcantidadProd.Size = new System.Drawing.Size(100, 22);
            this.txtcantidadProd.TabIndex = 9;
            // 
            // btnInsertarPedido
            // 
            this.btnInsertarPedido.Location = new System.Drawing.Point(268, 366);
            this.btnInsertarPedido.Name = "btnInsertarPedido";
            this.btnInsertarPedido.Size = new System.Drawing.Size(131, 69);
            this.btnInsertarPedido.TabIndex = 10;
            this.btnInsertarPedido.Text = "INSERTAR PEDIDO";
            this.btnInsertarPedido.UseVisualStyleBackColor = true;
            this.btnInsertarPedido.Click += new System.EventHandler(this.btnInsertarPedido_Click);
            // 
            // PedidoOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.btnInsertarPedido);
            this.Controls.Add(this.txtcantidadProd);
            this.Controls.Add(this.btnMenuOmar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbModeloPrenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PedidoOmar";
            this.Text = "Pedido";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModeloPrenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnMenuOmar;
        private System.Windows.Forms.TextBox txtcantidadProd;
        private System.Windows.Forms.Button btnInsertarPedido;
    }
}