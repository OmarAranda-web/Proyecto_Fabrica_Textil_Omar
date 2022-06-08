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
    public partial class PersonalOmar : Form
    {
        public PersonalOmar()
        {
            InitializeComponent();
        }

        private void mostrarMaquOmar(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbNumMaquOmar, "Select MAQUINARIA.NUMERO_MAQUINARIA_OMAR FROM MAQUINARIA");
        }

        private void PersonalOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
        }

        private void mostrarAreasOmar(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbAreaFabriOmar, "Select UPPER(AREAS_FABRICA_OMAR.NOMBRE_AREA_OMAR) From AREAS_FABRICA_OMAR");
        }

        private void mostrarCargoOmar(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbCargoOmar, "SELECT UPPER(CARGO_OMAR.NOMBRE_CARGO_OMAR) FROM CARGO_OMAR");
        }

        private void btnRegMenOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            string refc_perosnal, nomPersonal, ap1Pers, ap2Pers, direcPers, emailOmarPers, telefonoPerso, numMaquPers, areaFabri, cargPersonal;
            try
            {
                refc_perosnal=txtRFCPersoOmar.Text;
                nomPersonal=txtNomPersonal.Text;
                ap1Pers=txtApellido1Omar.Text;
                ap2Pers=txtApellido2Omar.Text;
                direcPers = txtDireccionOmar.Text;
                emailOmarPers = txtemailOmar.Text;
                telefonoPerso=txtemailOmar.Text;
                numMaquPers = cmbNumMaquOmar.Text;
                areaFabri = cmbAreaFabriOmar.Text;
                cargPersonal = cmbCargoOmar.Text;
                if (refc_perosnal=="" || nomPersonal=="" || ap1Pers=="" || ap2Pers=="" || direcPers=="" ||
                    emailOmarPers==""|| telefonoPerso=="" || numMaquPers=="" || areaFabri==""|| cargPersonal=="")
                {
                    MessageBox.Show("LLENA TODOS LOS CAMPOS DE PERSONAL");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_personal '"+refc_perosnal+"', '"+nomPersonal+"','"+ap1Pers+"','"+ap2Pers+"','"+direcPers+"','"+emailOmarPers+"','"+telefonoPerso+"','"+numMaquPers+"','"+areaFabri+"','"+cargPersonal+"'");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    txtRFCPersoOmar.Clear();
                    txtNomPersonal.Clear();
                    txtApellido1Omar.Clear();
                    txtApellido2Omar.Clear();
                    txtDireccionOmar.Clear();
                    txtTelefonoPerOmar.Clear();
                    txtemailOmar.Clear();
                    cmbNumMaquOmar.Items.Clear();
                    cmbAreaFabriOmar.Items.Clear();
                    cmbCargoOmar.Items.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Lle los campos de forma correcta");
            }
        }
    }
}
