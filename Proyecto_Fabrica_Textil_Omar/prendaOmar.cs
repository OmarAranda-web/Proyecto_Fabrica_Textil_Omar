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
    public partial class prendaOmar : Form
    {
        public static int detallesPrenda1 = 0;
        public static string material="";
        public static string nombre = "";
        public static string categoria = "";
        public static string color = "";
        public static float precio = 0;

        public static string folio = "";
        public static string id_materia = "";
        public static float cantidad = 0;
        public static string unidad = "";

        public prendaOmar()
        {
            InitializeComponent();
        }
        

        private void mostrarMateriales(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbMaterial, "Select upper(MATERIAL_OMAR.NOMBRE_MATERIAL_OMAR) from MATERIAL_OMAR where MATERIAL_OMAR.STATUS_MATERIAL_OMAR=1 Group by MATERIAL_OMAR.NOMBRE_MATERIAL_OMAR");
        }

        private void prenda_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
            //CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabMostrarPrendas, "exec proc_consulta_mostrarPrendas");
            btnOtraPrendaIn.Visible=false;
            lblOtraPrenda1.Visible=false;
            if (PedidoOmar.inserPrend == 1)
            {
                btnRegresarMenu.Visible = false;
                lblRegMen.Visible = false;

            }
            if (Form1.ocultaRegPrendas == 1)
            {
                btnRegPagAnterior.Visible = false;
                lblReg.Visible = false;
            }

        }

        private void mostrarCategorias(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbCategoria, "Select UPPER(CATEGORIA_OMAR.NOMBRE_CATEGORIA_OMAR) from  CATEGORIA_OMAR where CATEGORIA_OMAR.STATUS_CATEGORIA_OMAR=1 Group by CATEGORIA_OMAR.NOMBRE_CATEGORIA_OMAR");
        }

        private void mostrarColor(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbColor, "select upper(COLOR_OMAR.NOMBRE_COLOR_OMAR) from COLOR_OMAR Group by COLOR_OMAR.NOMBRE_COLOR_OMAR");
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnInsertarPrenda_Click(object sender, EventArgs e)
        {
            try
            {
                nombre = txtNombrePrenda.Text;
                material = cmbMaterial.Text;
                categoria = cmbCategoria.Text;
                color = cmbColor.Text;
                precio = (float)(Convert.ToDouble(txtPrecio.Text));
                if (nombre == "" || material == "" || categoria == "" || color == "" || precio < 0)
                {
                    MessageBox.Show("Llene todos los campos de manera adecuada", "MENSAJE DE FABRICA");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Prenda  '" + nombre + "','" + material + "','" + categoria + "','" + color + "'," + precio + "");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        //MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(), "MENSAJE DE FABRICA");
                        folio=CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    if (folio== "YA EXISTE ESA PRENDA EN EL SISTEMA")
                    {
                        MessageBox.Show(folio);
                    }
                    else
                    {
                        txtNombrePrenda.Enabled = false;
                        txtPrecio.Enabled = false;
                        cmbCategoria.Enabled = false;
                        cmbColor.Enabled = false;
                        cmbMaterial.Enabled = false;
                        btnDetallesPrenda.Enabled = false;
                        btnInsertarPrenda.Enabled = false;
                        btnRegPagAnterior.Enabled = false;
                        btnRegresarMenu.Enabled = false;
                        mostrarMaterias();
                    }
                    //CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabMostrarPrendas, "exec proc_consulta_mostrarPrendas");
                }
            }
            catch
            {
                MessageBox.Show("Coloque Valores Aceptados:", "MENSAJE DE FABRICA");
            }
        }

        private void btnDetallesPrenda_Click(object sender, EventArgs e)
        {
            Incluir_Detalles_FabricaOmar detaPrenda = new Incluir_Detalles_FabricaOmar();
            detallesPrenda1 = 1;
            detaPrenda.ShowDialog();

        }

        private void btnRegPagAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
            PedidoOmar frmPedido = new PedidoOmar();
            PedidoOmar.inserPrend = 0;
            frmPedido.Show();
        }
        public void mostrarMaterias()
        {

            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select MATERIAS_PRIMAS_OMAR.NOMBRE_MATERIAPRIMA_OMAR, MATERIAS_PRIMAS_OMAR.ID_MATERIA_PRIMA_OMAR from MATERIAS_PRIMAS_OMAR");
            while (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
            {
                creear_botones_materias_omar_prenda(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(), CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[1].ToString());
            }
            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
        }
        public void creear_botones_materias_omar_prenda(string nommbre_Materia_Omar, string id_materia)
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
            flpanelMaterias.Controls.Add(btn_materias);
            btn_materias.Click += new EventHandler(eventos_btnMaterias1);
        }
        public void eventos_btnMaterias1(object sender, EventArgs e)
        {
            Button tagMateria = sender as Button;
            id_materia = Convert.ToString(tagMateria.Tag);
            try
            {
                CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("select UNIDAD_MEDIDA_OMAR.NOMBRE_MEDIDA_OMAR from UNIDAD_MEDIDA_OMAR inner join MATERIAS_PRIMAS_OMAR on UNIDAD_MEDIDA_OMAR.ID_MEDIDA_OMAR = MATERIAS_PRIMAS_OMAR.ID_MATERIA_PRIMA_OMAR where ID_MATERIA_PRIMA_OMAR='"+id_materia+"'");
                if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                {
                    unidad=CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                }
                CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                cantidad =(float)Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Coloque la cantidad de la Materia Prima "+tagMateria.Text+" con una unidad de medida de :"+unidad));
                if (cantidad < 0 )
                {
                    MessageBox.Show("Coloque valores positivos", "MENSAJE DE FABRICA");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_formulaPrenda '"+folio+"','"+id_materia+"',"+cantidad+"");
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabMateriasAgregadas, "exec proc_consulta_formula '"+folio+"'");
                    btnInsertarPrenda.Enabled = true;
                    btnRegPagAnterior.Enabled = true;
                    btnRegresarMenu.Enabled = true;
                    btnOtraPrendaIn.Visible = true;
                    lblOtraPrenda1.Visible = true;
                    cantidad = 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("SOLO SE ADMITEN NUMEROS", "MENSAJE DE FABRICA "+ex);
            }
        }
        private void btnOtraPrendaIn_Click(object sender, EventArgs e)
        {
            txtNombrePrenda.Clear();
            txtPrecio.Clear();
            cmbCategoria.Items.Clear();
            cmbColor.Items.Clear();
            cmbMaterial.Items.Clear();
            txtNombrePrenda.Enabled = true;
            txtPrecio.Enabled = true;
            cmbCategoria.Enabled = true;
            cmbColor.Enabled = true;
            cmbMaterial.Enabled = true;
            btnDetallesPrenda.Enabled = true;
            folio = "";
            id_materia = "";
            cantidad = 0;
            unidad = "";
            btnOtraPrendaIn.Visible = false;
            lblOtraPrenda1.Visible = false;
            flpanelMaterias.Controls.Clear();
            CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabMateriasAgregadas, "Select '' as 'MODELO DE PRENDA', '' as 'MATERIAS PRIMAS','' AS 'CANIDAD DE LA MATERIA'");
        }
    }
}
