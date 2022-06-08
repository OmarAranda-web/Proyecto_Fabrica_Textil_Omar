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
    public partial class MateriPrimaOmar : Form
    {
        public MateriPrimaOmar()
        {
            InitializeComponent();
        }

        private void mostrarUnidadMedOmar(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbUnidadMedida, "select Upper(UNIDAD_MEDIDA_OMAR.NOMBRE_MEDIDA_OMAR) from UNIDAD_MEDIDA_OMAR");
        }

        private void MateriPrimaOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
        }

        private void btnRegMenuOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnInsertarMateriaOmar_Click(object sender, EventArgs e)
        {
            String nomMateriaOmar,unidadMed;
            float existenciMatOmar, stoKMinOmar, stoKMaxOmar;
            try
            {
                nomMateriaOmar = txtNomMateria.Text;
                existenciMatOmar =(float) (Convert.ToDouble(txtExitencias.Text));
                stoKMinOmar = (float)(Convert.ToDouble(txtStockMin.Text));
                stoKMaxOmar=(float)(Convert.ToDouble(txtStockMax.Text));
                unidadMed=cmbUnidadMedida.Text;
                if (nomMateriaOmar=="" || existenciMatOmar<0 || stoKMinOmar<0 || stoKMaxOmar<0 || unidadMed=="")
                {
                    MessageBox.Show("LLENE TODOS LOS CAMPOS Y SOLO SE ADMITEN VALORES POSITIVOS");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_MateriasPrimas '"+nomMateriaOmar+"', "+existenciMatOmar+","+stoKMinOmar+","+stoKMaxOmar+",'"+unidadMed+"'");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    txtNomMateria.Clear();
                    txtExitencias.Clear();
                    txtStockMax.Clear();
                    txtStockMin.Clear();
                    cmbUnidadMedida.Items.Clear();
                }
            }
            catch
            {
                MessageBox.Show("COLOQUE VALORES CORRECTOS(CANTIDADES NUMERICAS)");
            }
        }
    }
}
