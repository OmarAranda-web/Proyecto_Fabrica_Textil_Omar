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
    public partial class ProveedorOmar : Form
    {
        public ProveedorOmar()
        {
            InitializeComponent();
        }

        private void ProveedorOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
            CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabProveedor, "exec proc_consul_proveedor");
        }

        private void btnRegMenOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnInsertarProveedor_Click(object sender, EventArgs e)
        {
            String razonSocialPorvee, contactoProve, emailProvee, direccionProvee;
            int telefonoProvee;
            try
            {
                razonSocialPorvee = txtRazonSocialOmar.Text;
                contactoProve = txtContacto.Text;
                telefonoProvee = Convert.ToInt32(txtTelefono.Text);
                emailProvee = txtEmail.Text;
                direccionProvee = txtDireccionOmar.Text;
                if (razonSocialPorvee==""||contactoProve==""|| telefonoProvee<0|| emailProvee==""||direccionProvee=="")
                {
                    MessageBox.Show("LLENE TODOS LOS CAMPOS DEL FORMULARIO");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_proveedor '"+razonSocialPorvee+"', '"+contactoProve+"', '"+telefonoProvee+"','"+emailProvee+"','"+direccionProvee+"'");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabProveedor, "exec proc_consul_proveedor");
                    txtContacto.Clear();
                    txtDireccionOmar.Clear();
                    txtEmail.Clear();
                    txtRazonSocialOmar.Clear();
                    txtTelefono.Clear();
                }
            }
            catch
            {
                MessageBox.Show("LLENE LOS CAMPOS DE FORMA ADECUADA");
            }
        }
    }
}
