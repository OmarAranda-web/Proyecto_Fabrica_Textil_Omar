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
    public partial class VentaOmar : Form
    {
        public VentaOmar()
        {
            InitializeComponent();
        }

        private void VentaOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
        }

        private void mostrarClientes(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbCliente, "Select CLIENTE_OMAR.RAZON_SOCIAL_CLIENTE_OMAR from CLIENTE_OMAR where CLIENTE_OMAR.STATUS_CLIENTE_OMAR=1");
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
