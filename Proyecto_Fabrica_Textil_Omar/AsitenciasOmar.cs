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

        /*private void mostrarRFCPerOmar(object sender, EventArgs e)
        {
            //CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbRFCPerOmar, "Select UPPER(PERSONAL_OMAR.RFC_PERSONAL_OMAR) FROM PERSONAL_OMAR");
        }*/

        private void btnRegMenOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnAsistenciaOmar_Click(object sender, EventArgs e)
        {
            string horaEnt, horaSal, rfcPersonal, fechaAsis;
            int unidades;
            try
            {
                if (cmbHoraEnt.Text=="" || cmbMinsEnt.Text=="" || cmbEntampm.Text==""||cmbHoraSal.Text==""||cmbMinsSal.Text==""||cmbampmSal.Text==""
                    || txtRFC.Text==""||txtUnidOmar.Text=="" || calenFecha.SelectionRange.Start.ToShortDateString()=="")
                {
                    MessageBox.Show("LLENE TODOS LOS CAMPOS","MENSAJE DE FABRICA");
                }
                else
                {
                    horaEnt = (cmbHoraEnt.Text + ":" + cmbMinsEnt.Text + " " + cmbEntampm.Text);
                    horaSal = (cmbHoraSal.Text + ":" + cmbMinsSal.Text + " " + cmbampmSal.Text);
                    rfcPersonal = txtRFC.Text;
                    fechaAsis = calenFecha.SelectionRange.Start.ToShortDateString();
                    unidades = Convert.ToInt32(txtUnidOmar.Text);
                    if (horaEnt == horaSal)
                    {
                        MessageBox.Show("LA HORA DE ENTRADA ES LA MISMA QUE LA HORA DE SALIDA","MENSAJE DE FABRICA");
                    }
                    else
                    {
                        CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Asistencias '" + horaEnt + "','" + horaSal + "','" + rfcPersonal + "','" + unidades + "','" + fechaAsis + "'");
                        if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                        {
                            MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(),"MENSAJE DE FABRICA");
                        }
                        CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                        cmbampmSal.SelectedIndex = 0;
                        cmbEntampm.SelectedIndex = 0;
                        cmbHoraEnt.SelectedIndex = 0;
                        cmbHoraSal.SelectedIndex = 0;
                        cmbMinsEnt.SelectedIndex = 0;
                        cmbMinsSal.SelectedIndex = 0;
                        txtRFC.Clear();
                        txtUnidOmar.Clear();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Solo se aceptan Numeros en la cantidad", "MENSAJE DE FABRICA");
            }            
        }
    }
}
