﻿using System;
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
    public partial class PerdidasOmar : Form
    {
        public PerdidasOmar()
        {
            InitializeComponent();
        }

        private void PerdidasOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
            //CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabPerdidasOmar, "exec proc_consul_perdidas");
        }

        private void btnRegMenOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void mostrarMateriaOmar(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbMateriaOmar, "Select Upper(MATERIAS_PRIMAS_OMAR.NOMBRE_MATERIAPRIMA_OMAR) from MATERIAS_PRIMAS_OMAR where MATERIAS_PRIMAS_OMAR.STATUS_MATERIA_OMAR = 1 group by MATERIAS_PRIMAS_OMAR.NOMBRE_MATERIAPRIMA_OMAR");
        }

        private void mostrarRFCOmar(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbRFCOmar, "Select UPPER(PERSONAL_OMAR.RFC_PERSONAL_OMAR) FROM PERSONAL_OMAR GROUP BY PERSONAL_OMAR.RFC_PERSONAL_OMAR");
        }

        private void btnPerdidaPrendOmar_Click(object sender, EventArgs e)
        {
            String materiPrima, observacionPerdida, rfcEmpleado;
            float cantidadMateria;
            try
            {
                materiPrima= cmbMateriaOmar.Text;
                cantidadMateria = (float)(Convert.ToDouble(txtCantiPerd.Text));
                observacionPerdida = txtObservaPerd.Text;
                rfcEmpleado = cmbRFCOmar.Text;
                if (materiPrima=="" || cantidadMateria<0 || observacionPerdida==""|| rfcEmpleado=="")
                {
                    MessageBox.Show("LLENE TODOS LOS CAMPOS DE LA PERDIDA, SINO HAY OBSERVACIONES COLOQUE NINGUNA Y NO SON VALIDOS NUMEROS NEGATIVOS","MENSAJE DE FABRICA");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_perdida '"+materiPrima+"', "+cantidadMateria+", '"+observacionPerdida+"', '"+rfcEmpleado+"'");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(),"MENSAJE DE FABRICA");
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    //CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabPerdidasOmar, "exec proc_consul_perdidas");
                    cmbMateriaOmar.Items.Clear();
                    txtCantiPerd.Clear();
                    txtObservaPerd.Clear();
                    cmbRFCOmar.Items.Clear();
                }
            }
            catch
            {
                MessageBox.Show("SOLO SON VALIDOS NUMEROS EN LA CANTIDAD","MENSAJE DE FABRICA");
            }
        }
    }
}
