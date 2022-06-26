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
        public static string clave_provee="";
        public static string clave_materias = "";
        public static string folio_compra = "";
        public static float precioMateria=0;
        public static string calidad="";
        public static float cantidad=0;
        private void CompraOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
            mostrar_clientes();
        }
        public void mostrar_clientes()
        {
            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select PROVEEDOR_OMAR.RAZON_SOCIAL_PROVE_OMAR, PROVEEDOR_OMAR.CLAVE_PROVEEDOR_OMAR from PROVEEDOR_OMAR");
            while (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
            {
                creear_botones_provedores_omar(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(), CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[1].ToString());
            }
            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
        }
        public void creear_botones_provedores_omar(string nombreProve_omar, string claveProve_omar)
        {
            //omar_vector_boton = new Button[omar_contador+1];
            Button btn_proveedores = new Button();
            btn_proveedores.Text = nombreProve_omar;
            btn_proveedores.Tag = claveProve_omar;
            btn_proveedores.TextAlign = ContentAlignment.MiddleRight;
            btn_proveedores.Width = 150;
            btn_proveedores.Height = 150;
            btn_proveedores.Image = Properties.Resources.camiseta;
            btn_proveedores.ImageAlign = ContentAlignment.MiddleLeft;
            flpanelProveedores.Controls.Add(btn_proveedores);
            btn_proveedores.Click += new EventHandler(eventos_btnProvedores);
        }
        public void eventos_btnProvedores(object sender, EventArgs e)
        {
            Button tagProve = sender as Button;
            clave_provee = Convert.ToString(tagProve.Tag);
            try
            {
                folio_compra=txtFolioCompra.Text;
                if (folio_compra=="")
                {
                    MessageBox.Show("Coloque el folio de compra");
                }
                else
                {
                    txtFolioCompra.Enabled = false;
                    flpanelProveedores.Controls.Clear();
                    mostrar_materiasPrimas();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            
        }
        public void mostrar_materiasPrimas()
        {
            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select MATERIAS_PRIMAS_OMAR.NOMBRE_MATERIAPRIMA_OMAR, MATERIAS_PRIMAS_OMAR.ID_MATERIA_PRIMA_OMAR from MATERIAS_PRIMAS_OMAR");
            while (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
            {
                creear_botones_materias_omar(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(), CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[1].ToString());
            }
            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
        }
        public void creear_botones_materias_omar(string nommbre_Materia_Omar, string id_materia)
        {
            Button btn_materias = new Button();
            btn_materias.Text = nommbre_Materia_Omar;
            btn_materias.Tag = id_materia;
            btn_materias.TextAlign = ContentAlignment.MiddleRight;
            btn_materias.Width = 150;
            btn_materias.Height = 150;
            btn_materias.Image = Properties.Resources.camiseta;
            btn_materias.ImageAlign = ContentAlignment.MiddleLeft;
            flpanelProveedores.Controls.Add(btn_materias);
            btn_materias.Click += new EventHandler(eventos_btnMaterias);
        }
        public void eventos_btnMaterias(object sender, EventArgs e)
        {
            Button tagMateria = sender as Button;
            clave_materias = Convert.ToString(tagMateria.Tag);
            cantidad = (float)Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Coloque la cantidad"));
            calidad = Microsoft.VisualBasic.Interaction.InputBox("En una escala del 1 al 10 coloque la calidad");
            precioMateria = (float)(Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Coloque el precio de una Unidad de Material")));

            //flpanelProveedores.Controls.Clear();
            MessageBox.Show(clave_materias);
        }


        private void btnRegMenOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
