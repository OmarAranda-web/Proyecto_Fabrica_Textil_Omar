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
        public prendaOmar()
        {
            InitializeComponent();
        }

        private void mostrarMateriales(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbMaterial, "Select upper(MATERIAL_OMAR.NOMBRE_MATERIAL_OMAR) from MATERIAL_OMAR where MATERIAL_OMAR.STATUS_MATERIAL_OMAR=1");
        }

        private void prenda_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
            CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabMostrarPrendas, "exec proc_consulta_mostrarPrendas");
            if (PedidoOmar.inserPrend == 1)
            {
                btnRegresarMenu.Visible = false;
            }
            if (Form1.ocultaRegPrendas==1)
            {
                btnRegPagAnterior.Visible = false;
            }

        }

        private void mostrarCategorias(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbCategoria, "Select UPPER(CATEGORIA_OMAR.NOMBRE_CATEGORIA_OMAR) from CATEGORIA_OMAR where CATEGORIA_OMAR.STATUS_CATEGORIA_OMAR=1");
        }

        private void mostrarColor(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbColor, "select upper(COLOR_OMAR.NOMBRE_COLOR_OMAR) from COLOR_OMAR");
        }

        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnInsertarPrenda_Click(object sender, EventArgs e)
        {
            String nombre, material, categoria, color;
            float precio;
            try
            {
                nombre = txtNombrePrenda.Text;
                material = cmbMaterial.Text;
                categoria = cmbCategoria.Text;
                color = cmbColor.Text;
                precio = (float)(Convert.ToDouble(txtPrecio.Text));
                if (nombre=="" || material=="" || categoria=="" || color=="" || precio<0)
                {
                    MessageBox.Show("Llene todos los campos de manera adecuada");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_Prenda  '"+nombre+"','"+material+"','"+categoria+"','"+color+"',"+precio+"");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    txtNombrePrenda.Clear();
                    txtPrecio.Clear();
                    cmbCategoria.Items.Clear();
                    cmbColor.Items.Clear();
                    cmbMaterial.Items.Clear();
                    CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(tabMostrarPrendas, "exec proc_consulta_mostrarPrendas");
                }
            }
            catch
            {
                MessageBox.Show("Coloque Valores Aceptados: ");
            }
        }

        private void btnDetallesPrenda_Click(object sender, EventArgs e)
        {
            Incluir_Detalles_FabricaOmar detaPrenda = new Incluir_Detalles_FabricaOmar();
            detallesPrenda1 = 1;
            detaPrenda.Show();
            
        }

        private void btnRegPagAnterior_Click(object sender, EventArgs e)
        {
            this.Close();
            PedidoOmar frmPedido = new PedidoOmar();
            PedidoOmar.inserPrend = 0;
            frmPedido.Show();
        }
    }
}
