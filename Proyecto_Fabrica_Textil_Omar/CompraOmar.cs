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
    public partial class CompraOmar : Form
    {
        public CompraOmar()
        {
            InitializeComponent();
        }

        private void CompraOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
        }

        private void mostrarProveOmar(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbProveedor, "select Upper(PROVEEDOR_OMAR.RAZON_SOCIAL_PROVE_OMAR) from PROVEEDOR_OMAR where PROVEEDOR_OMAR.STATUS_PROVEEDOR_OMAR=1");
        }

        private void btnRegMenOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
