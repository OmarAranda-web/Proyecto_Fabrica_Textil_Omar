using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Fabrica_Textil_Omar
{
    public partial class PedidoOmar : Form
    {
        public static int inserPrend=0;
        public static int inserClient = 0;
        public PedidoOmar()
        {
            InitializeComponent();
        }

        private void mostrarModeloPrenda(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbModeloPrenda,"Select PRENDA_OMAR.NOMBRE_PRENDA_OMAR from PRENDA_OMAR where PRENDA_OMAR.STATUS_PRENDA=1");
        }

        private void Pedido_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
            CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabPedido, "exec proc_consulta_pedido");
        }

        private void mostrarClientes(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(comboBox1, "Select CLIENTE_OMAR.RAZON_SOCIAL_CLIENTE_OMAR from CLIENTE_OMAR where CLIENTE_OMAR.STATUS_CLIENTE_OMAR=1");
        }

        private void btnMenuOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnInsertarPedido_Click(object sender, EventArgs e)
        {
            String nombrePrenda,cliente;
            float cantidadPrendas;
            try
            {
                nombrePrenda=cmbModeloPrenda.Text;
                cliente = comboBox1.Text;
                cantidadPrendas =(float) (Convert.ToDouble(txtcantidadProd.Text));
                if (cantidadPrendas < 0)
                {
                    MessageBox.Show("No Coloque Canitdades negativas");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_pedido '" + nombrePrenda + "', " + cantidadPrendas + ", '" + cliente + "'");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabPedido, "exec proc_consulta_pedido");
                    cmbModeloPrenda.Items.Clear();
                    comboBox1.Items.Clear();
                    txtcantidadProd.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Coloque valores Validos");
            }
        }

        private void btnPrendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            inserPrend = 1;
            prendaOmar frmPrenda = new prendaOmar();
            frmPrenda.Show();
        }

        private void btnInsertarClientePed_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClienteOmar frmClien = new ClienteOmar();
            inserClient = 1;
            frmClien.Show();
        }
    }
}
