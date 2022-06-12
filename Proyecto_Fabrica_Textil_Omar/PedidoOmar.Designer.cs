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
            this.tabPedido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(878, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "PEDIDO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DE PRENDA";
            // 
            // cmbModeloPrenda
            // 
            this.cmbModeloPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModeloPrenda.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModeloPrenda.FormattingEnabled = true;
            this.cmbModeloPrenda.Location = new System.Drawing.Point(774, 194);
            this.cmbModeloPrenda.Name = "cmbModeloPrenda";
            this.cmbModeloPrenda.Size = new System.Drawing.Size(415, 59);
            this.cmbModeloPrenda.TabIndex = 2;
            this.cmbModeloPrenda.Click += new System.EventHandler(this.mostrarModeloPrenda);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(530, 51);
            this.label4.TabIndex = 4;
            this.label4.Text = "CANTIDAD DEL PEDIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 648);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(653, 51);
            this.label5.TabIndex = 5;
            this.label5.Text = "RAZON SOCIAL DEL CLIENTE";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(774, 640);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(415, 59);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Click += new System.EventHandler(this.mostrarClientes);
            // 
            // btnMenuOmar
            // 
            this.btnMenuOmar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuOmar.Location = new System.Drawing.Point(718, 779);
            this.btnMenuOmar.Name = "btnMenuOmar";
            this.btnMenuOmar.Size = new System.Drawing.Size(471, 195);
            this.btnMenuOmar.TabIndex = 7;
            this.btnMenuOmar.Text = "REGRESAR AL MENU";
            this.btnMenuOmar.UseVisualStyleBackColor = true;
            this.btnMenuOmar.Click += new System.EventHandler(this.btnMenuOmar_Click);
            // 
            // txtcantidadProd
            // 
            this.txtcantidadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidadProd.Location = new System.Drawing.Point(774, 418);
            this.txtcantidadProd.Name = "txtcantidadProd";
            this.txtcantidadProd.Size = new System.Drawing.Size(415, 53);
            this.txtcantidadProd.TabIndex = 9;
            // 
            // btnInsertarPedido
            // 
            this.btnInsertarPedido.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarPedido.Location = new System.Drawing.Point(72, 779);
            this.btnInsertarPedido.Name = "btnInsertarPedido";
            this.btnInsertarPedido.Size = new System.Drawing.Size(498, 195);
            this.btnInsertarPedido.TabIndex = 10;
            this.btnInsertarPedido.Text = "INSERTAR PEDIDO";
            this.btnInsertarPedido.UseVisualStyleBackColor = true;
            this.btnInsertarPedido.Click += new System.EventHandler(this.btnInsertarPedido_Click);
            // 
            // tabPedido
            // 
            this.tabPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabPedido.Location = new System.Drawing.Point(1210, 106);
            this.tabPedido.Name = "tabPedido";
            this.tabPedido.RowHeadersWidth = 51;
            this.tabPedido.RowTemplate.Height = 24;
            this.tabPedido.Size = new System.Drawing.Size(702, 915);
            this.tabPedido.TabIndex = 11;
            // 
            // PedidoOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1033);
            this.Controls.Add(this.tabPedido);
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
            ((System.ComponentModel.ISupportInitialize)(this.tabPedido)).EndInit();
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
        private System.Windows.Forms.DataGridView tabPedido;
    }
}