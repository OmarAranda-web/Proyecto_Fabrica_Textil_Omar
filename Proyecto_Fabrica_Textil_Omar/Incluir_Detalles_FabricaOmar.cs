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
    public partial class Incluir_Detalles_FabricaOmar : Form
    {
        public Incluir_Detalles_FabricaOmar()
        {
            InitializeComponent();
        }

        private void Incluir_Detalles_Fabrica_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
        }

        private void btnInsertarColor_Click(object sender, EventArgs e)
        {
            String colorPrrenda;
            colorPrrenda = txtColor.Text;
            if (colorPrrenda=="")
            {
                MessageBox.Show("Coloque un color");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_color '" + colorPrrenda + "'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeColor = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeColor);
                }
                txtColor.Clear();
                CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnInsertarMaterial_Click(object sender, EventArgs e)
        {
            String material;
            material = txtMaterial.Text;
            if (material=="")
            {
                MessageBox.Show("Coloque un Material");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Material '" + material + "'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeMa = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeMa);
                }
                txtMaterial.Clear();
                CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String categoria;
            categoria = txtCategoria.Text;
            if (categoria=="")
            {
                MessageBox.Show("Coloque un Categoria");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Categoria '" + categoria + "'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeCa = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeCa);
                }
                txtCategoria.Clear();
                CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
            }
        }

        private void btnUnidadMed_Click(object sender, EventArgs e)
        {
            String unidad, abre;
            unidad = txtUnidadMed.Text;
            abre = txtAbre.Text;
            if (unidad=="" || abre=="")
            {
                MessageBox.Show("Coloque un Unidad o Abreviatura");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Unidad '"+unidad+"','"+abre+"'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeUni = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeUni);
                }
                txtUnidadMed.Clear();
                txtAbre.Clear();
                CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
            }
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            String nomArea, capaArea;
            nomArea=txtArea.Text;
            capaArea=txtCapacidadArea.Text;
            if (nomArea=="" || capaArea=="")
            {
                MessageBox.Show("Coloque el Nombre del Area o Capacidad");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_area '"+nomArea+"', '"+capaArea+"'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeArea = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeArea);
                }
                txtArea.Clear();
                txtCapacidadArea.Clear();
                CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
            }

        }

        private void btnCatMaq_Click(object sender, EventArgs e)
        {
            String catMaq;
            catMaq = txtCategoriaMaq.Text;
            if (catMaq == "")
            {
                MessageBox.Show("Coloque el Nombre de la Categoria de Maquinaria");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_catMaq '"+catMaq+"'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeCat = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeCat);
                }
                txtCategoriaMaq.Clear();             
                CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
            }
        }

        private void btnInsertarCargo_Click(object sender, EventArgs e)
        {
            string cargo, actCargo;
            float sueldoCar;
            try
            {
                cargo = txtCargo.Text;
                actCargo = txtDescCargo.Text;
                sueldoCar = (float)Convert.ToDouble(txtSueldoCargo.Text);
                if (cargo==""|| actCargo==""||sueldoCar<0)
                {
                    MessageBox.Show("Llene los campos de forma correcta y no es valido cantidades negativas en el sueldo");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_cargo '"+cargo+"', '"+actCargo+"', "+sueldoCar+"");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        string mensajeCat = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                        MessageBox.Show(mensajeCat);
                    }
                    txtCargo.Clear();
                    txtDescCargo.Clear();
                    txtSueldoCargo.Clear();
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                }
            }
            catch
            {
                MessageBox.Show("Coloque Correctamente el sueldo del cargo");
            }
            

        }
    }
}
