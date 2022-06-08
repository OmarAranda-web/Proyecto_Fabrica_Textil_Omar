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
    public partial class ClienteOmar : Form
    {
        public ClienteOmar()
        {
            InitializeComponent();
        }

        private void ClienteOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.ShowDialog();
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            String razonSocialCliente, direcCliente, telefonoClien, emailClien;
            
            try
            {
                razonSocialCliente = TXTRazonSocial.Text;
                direcCliente = txtDireccion.Text;
                telefonoClien = txtTelefono.Text;
                emailClien = txtEmail.Text;
                if (razonSocialCliente=="" || direcCliente=="" || telefonoClien =="" || emailClien=="")
                {
                    MessageBox.Show("LLENE TODOS LOS CAMPOS");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Cliente '" + razonSocialCliente + "', '" + direcCliente + "','" + telefonoClien + "','" + emailClien + "'");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    TXTRazonSocial.Clear();
                    txtDireccion.Clear();
                    txtTelefono.Clear();
                    txtEmail.Clear();
                }

            }
            catch
            {
                MessageBox.Show("Coloque los valores de manera correcta");
            }
        }
    }
}
