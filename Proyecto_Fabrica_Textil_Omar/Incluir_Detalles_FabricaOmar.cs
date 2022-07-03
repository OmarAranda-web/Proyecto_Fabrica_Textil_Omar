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
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbCategoriaMaq, "Select UPPER(CATEGORIA_MAQUINARIA_OMAR.CATEGORIA_MAQUINARIA_OMAR) FROM CATEGORIA_MAQUINARIA_OMAR GROUP BY CATEGORIA_MAQUINARIA_OMAR.CATEGORIA_MAQUINARIA_OMAR");
            if ( prendaOmar.detallesPrenda1== 1)
            {
                panelPersonal.Visible = false;
                panelMateria.Visible = false;
                btnMenu.Visible = false;
            }
            if(PersonalOmar.detaPersonal == 1)
            {
                panelMateria.Visible=false;
                panelPrendas.Visible=false;
                btnMenu.Visible=false;

            }
            if (MateriPrimaOmar.detaUni == 1)
            {
                panelPersonal.Visible=false;
                panelPrendas.Visible=false;
                btnMenu.Visible = false;
            }
            if(Form1.ocultaBotines == 1)
            {
                btnRegPersonal.Visible=false;
                btnRegPrenda.Visible=false;
                btnRegresarPrendas.Visible = false;
            }
        }

        private void btnInsertarColor_Click(object sender, EventArgs e)
        {
            String colorPrrenda;
            colorPrrenda = txtColor.Text;
            if (colorPrrenda=="")
            {
                MessageBox.Show("Coloque un color","MENSAJE DE FRABRICA");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_color '" + colorPrrenda + "'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeColor = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeColor,"MENSAJE DE FABRICA");
                }
                txtColor.Clear();
                CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1.ocultaBotines = 0;
            this.Close();
            //Form1 menu = new Form1();
            //menu.Show();
        }

        private void btnInsertarMaterial_Click(object sender, EventArgs e)
        {
            String material;
            material = txtMaterial.Text;
            if (material=="")
            {
                MessageBox.Show("COLOQUE UN MATERIAL","MENSAJE DE FABRICA");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Material '" + material + "'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeMa = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeMa,"MENSAJE DE FABRICA");
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
                MessageBox.Show("COLOQUE UNA CATEGORIA","MENSAJE DE FABRICA");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Categoria '" + categoria + "'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeCa = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeCa,"MENSAJE DE FABRICA");
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
                MessageBox.Show("COLOQUE UN UNIDAD O ABREVIATURA","MENSAJE DE FABRICA");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Unidad '"+unidad+"','"+abre+"'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeUni = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeUni,"MENSAJE DE FABRICA");
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
                MessageBox.Show("COLOQUE EL NOMBRE DEL AREA O CAPACIDAD", "MENSAJE DE FABRICA");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_area '"+nomArea+"', '"+capaArea+"'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeArea = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeArea, "MENSAJE DE FABRICA");
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
                MessageBox.Show("COLOQUE EL NOMBRE DE LA CATEGORIA DE MAQUINARIA", "MENSAJE DE FABRICA");
            }
            else
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_catMaq '"+catMaq+"'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    string mensajeCat = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    MessageBox.Show(mensajeCat,"MENSAJE DE FABRICA");
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
                    MessageBox.Show("LLENE LOS CAMPOS DE FORMA CORRECTA Y NO ES VALIDO CANTIDADES NEGATIVAS EN EL SUELDO","MENSAJE DE FABRICA");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_cargo '"+cargo+"', '"+actCargo+"', "+sueldoCar+"");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        string mensajeCat = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                        MessageBox.Show(mensajeCat,"MENSAJE DE FABRICA");
                    }
                    txtCargo.Clear();
                    txtDescCargo.Clear();
                    txtSueldoCargo.Clear();
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                }
            }
            catch
            {
                MessageBox.Show("COLOQUE CORRECTAMENTE EL SUELDO DEL CARGO","MENSAJE DE FABRICA");
            }
        }

        private void btnRegresarPrendas_Click(object sender, EventArgs e)
        {
            MateriPrimaOmar.detaUni = 0;
            this.Close();
        }
        private void btnRegPrenda_Click(object sender, EventArgs e)
        {
            prendaOmar.detallesPrenda1 = 0;
            this.Close();
        }

        private void btnRegPersonal_Click(object sender, EventArgs e)
        {
            PersonalOmar.detaPersonal = 0;
            this.Close();
        }

        private void btnInsertarNumMaquinaria_Click(object sender, EventArgs e)
        {
            string catMaqui;
            int numMaq;
            try
            {
                numMaq = Convert.ToInt32(txtNumMaquinaria.Text);
                catMaqui = cmbCategoriaMaq.Text;
                if (numMaq < 0)
                {
                    MessageBox.Show("EL VALOR DEBE SER POSITIVOS","MENSAJE DE FABRICA");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_numMaq "+numMaq+",'"+catMaqui+"'");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(),"MENSAJE DE FABRICA");
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    txtNumMaquinaria.Clear();
                    cmbCategoriaMaq.Items.Clear();
                }
            }
            catch
            {
                MessageBox.Show("SOLO SE ADMITEN VALORES ENTEROS", "MENSAJE DE FABRICA");
            }
        }
    }
}
