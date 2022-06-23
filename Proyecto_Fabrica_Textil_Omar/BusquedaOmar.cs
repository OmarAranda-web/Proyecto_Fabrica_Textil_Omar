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
    public partial class BusquedaOmar : Form
    {
        public BusquedaOmar()
        {
            InitializeComponent();
        }

        private void BusquedaOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
        }

        private void buscarProducto(object sender, KeyEventArgs e)
        {
            string varBusqueda="";
            varBusqueda=txtPrenda.Text;
            CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabBusqueda, "exec proc_buscar_prenda '%"+varBusqueda+"%'");
        }

        private void evenRegresar(object sender, EventArgs e)
        {
            this.Close();
            VentaOmar frmVenta = new VentaOmar();
            frmVenta.Show();

        }
    }
}
