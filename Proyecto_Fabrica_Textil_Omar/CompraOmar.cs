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
        public static int calidad=0;
        public static float cantidad=0;
        public static string respuesta;

        private void CompraOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
            mostrar_clientes();
        }
        public void mostrar_clientes()
        {
            btnOtraCompra.Visible = false;
            lblotraCom.Visible = false;
            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select UPPER(PROVEEDOR_OMAR.RAZON_SOCIAL_PROVE_OMAR), PROVEEDOR_OMAR.CLAVE_PROVEEDOR_OMAR from PROVEEDOR_OMAR order by PROVEEDOR_OMAR.RAZON_SOCIAL_PROVE_OMAR");
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
            btn_proveedores.TextAlign = ContentAlignment.BottomCenter;
            btn_proveedores.Width = 150;
            btn_proveedores.Height = 100;
            btn_proveedores.Image = Properties.Resources.clientes;
            btn_proveedores.ImageAlign = ContentAlignment.MiddleCenter;
            btn_proveedores.BackColor = Color.PaleTurquoise;
            flpanelProveedores.Controls.Add(btn_proveedores);
            btn_proveedores.Click += new EventHandler(eventos_btnProvedores);
        }
        public void eventos_btnProvedores(object sender, EventArgs e)
        {
            Button tagProve = sender as Button;
            clave_provee = Convert.ToString(tagProve.Tag);
            string proveedorSelect =Convert.ToString(tagProve.Text);
            try
            {
                folio_compra=txtFolioCompra.Text;
                if (folio_compra=="")
                {
                    MessageBox.Show("COLOQUE EL FOLIO DE COMPRA", "MENSAJE DE FABRICA");
                }
                else
                {
                    
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Compra " + folio_compra + ", " + clave_provee + "");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        respuesta = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    if (respuesta == "El folio ya existe escribalo de forma adecuada")
                    {
                        MessageBox.Show(respuesta,"MENSAJE DE FABRICA");
                    }
                    else
                    {
                        txtFolioCompra.Enabled = false;
                        lblnomProvedor.Text = proveedorSelect;
                        flpanelProveedores.Controls.Clear();
                        mostrar_materiasPrimas();
                    }
                        
                }
            }
            catch
            {
                MessageBox.Show("EL FOLIO DE LA COMPRA DEBE SER DE 10 CARACTERES COMO MAXIMO", "MENSAJE DE FABRICA");
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
            btn_materias.TextAlign = ContentAlignment.BottomCenter;
            btn_materias.Width = 150;
            btn_materias.Height = 100;
            btn_materias.Image = Properties.Resources.amaterias;
            btn_materias.ImageAlign = ContentAlignment.MiddleCenter;
            btn_materias.BackColor = Color.PaleTurquoise;
            flpanelProveedores.Controls.Add(btn_materias);
            btn_materias.Click += new EventHandler(eventos_btnMaterias);
        }
        public void eventos_btnMaterias(object sender, EventArgs e)
        {
            Button tagMateria = sender as Button;
            clave_materias = Convert.ToString(tagMateria.Tag);
            try
            {
                cantidad = (float)Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Coloque la cantidad"));
                calidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("En una escala del 1 al 10 coloque la calidad"));
                if (cantidad < 0 || calidad<0)
                {
                    MessageBox.Show("Coloque valores positivos","MENSAJE DE FABRICA");
                }
                else
                {
                    if (calidad>10)
                    {
                        MessageBox.Show("La calidad solo acepta valores entre 1 y el 9","MENSAJE DE FABRICA");
                    }
                    else
                    {
                        CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec porc_insertar_detalleCompra "+clave_materias+", "+cantidad+", "+respuesta+"");
                        CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                        CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("EXEC proc_insertar_Materia_Proveedor "+clave_provee+","+clave_materias+",'"+calidad+"'");
                        CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                        MessageBox.Show("Se inserto Compra","MENSAJE DE FABRICA");
                        btnOtraCompra.Visible=true;
                        lblotraCom.Visible=true;
                        CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabCompras, "exec proc_consulta_compra "+respuesta+"");
                        CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select COMPRA_OMAR.TOTAL_COMPRA_OMAR from COMPRA_OMAR where COMPRA_OMAR.ID_COMPRA_OMAR="+respuesta+"");
                        if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                        {
                            lblTotal.Text = Convert.ToString(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0]);
                        }
                        CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    }
                }

            }
            catch
            {
                MessageBox.Show("LLene los campos de manera correcta","MENSAJE DE FABRICA");
            }
            

            //flpanelProveedores.Controls.Clear();
            //MessageBox.Show(clave_materias);
        }


        private void btnRegMenOmar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnOtraCompra_Click(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabCompras, "Select '' as 'NOMBRE DEL MATERIAL', '' as 'CANTIDAD DE LA MATERIA','' as 'PRECIO POR UNIDAD',''as 'TOTAL DE CADA MATERIA' ");
            flpanelProveedores.Controls.Clear();
            txtFolioCompra.Enabled = true;
            lblnomProvedor.Text = "";
            txtFolioCompra.Text = "";
            lblTotal.Text = "0";
            clave_provee = "";
            clave_materias = "";
            folio_compra = "";
            calidad = 0;
            cantidad = 0;
            respuesta="";
            mostrar_clientes();
        }
    }
}
