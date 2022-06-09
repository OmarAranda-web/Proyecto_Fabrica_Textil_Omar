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
    public partial class DevolucionesOmar : Form
    {
        public DevolucionesOmar()
        {
            InitializeComponent();
        }

        private void DevolucionesOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
            CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabDevolucionOmar, "exec proc_consul_devolucion");
        }

        private void mostrarCliente(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbModPrenda, "Select PRENDA_OMAR.NOMBRE_PRENDA_OMAR from PRENDA_OMAR where PRENDA_OMAR.STATUS_PRENDA=1");
        }

        private void btnRegMenuOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String prendaDevOmar;
            float cantidDevOmar;
            try
            {
                prendaDevOmar = cmbModPrenda.Text;
                cantidDevOmar = (float)(Convert.ToDouble(txtCantidad.Text));
                if (cantidDevOmar<0)
                {
                    MessageBox.Show("SOLO SE ADMITEN VALORES VALIDOS");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Devoluciones '"+prendaDevOmar+"', "+cantidDevOmar+"");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabDevolucionOmar, "exec proc_consul_devolucion");
                    cmbModPrenda.Items.Clear();
                    txtCantidad.Clear();
                }
            }
            catch
            {
                MessageBox.Show("COLOQUE SOLO NUMEROS EN LA CASILLA");
            }
        }
    }
}
