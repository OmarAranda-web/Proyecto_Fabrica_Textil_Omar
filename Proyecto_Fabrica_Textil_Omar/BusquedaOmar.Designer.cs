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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaOmar));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrenda = new System.Windows.Forms.TextBox();
            this.tabBusqueda = new System.Windows.Forms.DataGridView();
            this.btnRegBus = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.lblRegMen = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabBusqueda)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(306, 31);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(215, 19);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "BUSQUEDA DE PRENDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(550, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRENDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(492, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(559, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "COLOQUE EL NOMBRE O CARACTER";
            // 
            // txtPrenda
            // 
            this.txtPrenda.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenda.Location = new System.Drawing.Point(833, 260);
            this.txtPrenda.Name = "txtPrenda";
            this.txtPrenda.Size = new System.Drawing.Size(157, 42);
            this.txtPrenda.TabIndex = 3;
            this.txtPrenda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buscarProducto);
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabBusqueda.Location = new System.Drawing.Point(414, 323);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.RowHeadersWidth = 51;
            this.tabBusqueda.RowTemplate.Height = 24;
            this.tabBusqueda.Size = new System.Drawing.Size(686, 198);
            this.tabBusqueda.TabIndex = 4;
            // 
            // btnRegBus
            // 
            this.btnRegBus.BackColor = System.Drawing.SystemColors.Info;
            this.btnRegBus.BackgroundImage = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.menu;
            this.btnRegBus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegBus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegBus.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegBus.Location = new System.Drawing.Point(110, 209);
            this.btnRegBus.Name = "btnRegBus";
            this.btnRegBus.Size = new System.Drawing.Size(115, 108);
            this.btnRegBus.TabIndex = 6;
            this.btnRegBus.UseVisualStyleBackColor = false;
            this.btnRegBus.Click += new System.EventHandler(this.evenRegresar);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlTitulo.BackgroundImage = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.TituloFabrica;
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitulo.Controls.Add(this.panel5);
            this.pnlTitulo.Controls.Add(this.panel4);
            this.pnlTitulo.Controls.Add(this.panel3);
            this.pnlTitulo.Controls.Add(this.panel2);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1166, 114);
            this.pnlTitulo.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(948, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(102, 112);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(118, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(96, 112);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1050, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(114, 112);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(118, 112);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.lblRegMen);
            this.panel1.Controls.Add(this.lblbuscar);
            this.panel1.Controls.Add(this.btnRegBus);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 419);
            this.panel1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "DE UN CLIC EN LA OPCION QUE NECESITE";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PowderBlue;
            this.panel8.Controls.Add(this.label7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(342, 71);
            this.panel8.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(320, 35);
            this.label7.TabIndex = 17;
            this.label7.Text = "MENU DE OPCIONES";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(86, 129);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(171, 18);
            this.lblbuscar.TabIndex = 20;
            this.lblbuscar.Text = "BUSCAR UNA PRENDA";
            // 
            // lblRegMen
            // 
            this.lblRegMen.AutoSize = true;
            this.lblRegMen.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegMen.Location = new System.Drawing.Point(86, 187);
            this.lblRegMen.Name = "lblRegMen";
            this.lblRegMen.Size = new System.Drawing.Size(162, 18);
            this.lblRegMen.TabIndex = 22;
            this.lblRegMen.Text = "REGRESAR AL MENU";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.panel11);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.lbltitulo);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(342, 114);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(824, 71);
            this.panel7.TabIndex = 21;
            // 
            // panel13
            // 
            this.panel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel13.BackgroundImage")));
            this.panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(145, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(143, 71);
            this.panel13.TabIndex = 7;
            // 
            // panel12
            // 
            this.panel12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel12.BackgroundImage")));
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(145, 71);
            this.panel12.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel11.BackgroundImage")));
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(539, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(144, 71);
            this.panel11.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackgroundImage = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.camiseta;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(683, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(141, 71);
            this.panel9.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(699, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTA";
            // 
            // BusquedaOmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Fabrica_Textil_Omar.Properties.Resources.Fondo_Fabrica;
            this.ClientSize = new System.Drawing.Size(1166, 533);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.tabBusqueda);
            this.Controls.Add(this.txtPrenda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusquedaOmar";
            this.Text = "BusquedaOmar";
            this.Load += new System.EventHandler(this.BusquedaOmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabBusqueda)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegMen;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label1;
    }
}