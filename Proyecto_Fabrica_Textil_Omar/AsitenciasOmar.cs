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
    public partial class AsitenciasOmar : Form
    {
        public AsitenciasOmar()
        {
            InitializeComponent();
        }

        private void AsitenciasOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
        }

        private void mostrarRFCPerOmar(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbRFCPerOmar, "Select UPPER(PERSONAL_OMAR.RFC_PERSONAL_OMAR) FROM PERSONAL_OMAR");
        }

        private void btnRegMenOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
