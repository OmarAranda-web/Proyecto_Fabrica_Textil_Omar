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
    public partial class VentaOmar : Form
    {
        public static string cliente_omar="";
        public static string idCategoria="";
        public static string modeloDePrenda="";
        public static string folioVenta="";
        public static int cantidad=0;
        public VentaOmar()
        {
            InitializeComponent();
        }

        private void VentaOmar_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
            lblCliente.Visible=false;
            lblnomCliente.Visible=false;
            lblCategorias.Visible=false;
            flpanelCategoria.Visible=false;
            lblDetaVenta.Visible=false;
            taaVentas.Visible=false;
            lblTotalVenta.Visible=false;
            lblcantiVenta.Visible=false;
            btnRegClientes.Visible=false;
            lblClientCate.Text = "CLIENTES";
            omar_mostrar_Clientes();
            
        }
        private void mostrarClientes(object sender, EventArgs e)
        {
            //CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbCliente, "Select CLIENTE_OMAR.RAZON_SOCIAL_CLIENTE_OMAR from CLIENTE_OMAR where CLIENTE_OMAR.STATUS_CLIENTE_OMAR=1");
        }

        public void omar_mostrar_Clientes()
        {
            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("select CLIENTE_OMAR.RAZON_SOCIAL_CLIENTE_OMAR, CLIENTE_OMAR.CLAVE_CLIENTE_OMAR from CLIENTE_OMAR ");
            while ( CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
            {
                creear_Botonoes_Cliente_omar(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(), CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[1].ToString());
            }
            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
        }
        public void creear_Botonoes_Cliente_omar(string omar_Cliente, string omar_clave_Cliente)
        {
            //omar_vector_boton = new Button[omar_contador+1];
            Button nuevo_Boton = new Button();
            nuevo_Boton.Text = omar_Cliente;
            nuevo_Boton.Tag = omar_clave_Cliente;
            nuevo_Boton.TextAlign = ContentAlignment.MiddleRight;
            nuevo_Boton.Width = 150;
            nuevo_Boton.Height = 150;
            nuevo_Boton.Image = Properties.Resources.camiseta;
            nuevo_Boton.ImageAlign = ContentAlignment.MiddleLeft;
            flPanelClientes.Controls.Add(nuevo_Boton);
            nuevo_Boton.Click += new EventHandler(eventos_btnClientes_omar);
        }
        public void eventos_btnClientes_omar(object sender, EventArgs e)
        {
            Button tagCliente = sender as Button;
            cliente_omar = Convert.ToString(tagCliente.Tag);
            DateTime thisDay = DateTime.Now;
            folioVenta = thisDay.ToString("ddMMyyyyhhmmssff");
            flPanelClientes.Controls.Clear();
            lblClientCate.Text = "Prendas";
            lblCliente.Visible = true;
            lblnomCliente.Text=tagCliente.Text;
            lblnomCliente.Visible = true;
            lblCategorias.Visible = true;
            flpanelCategoria.Visible = true;
            //label2.Visible = false;
            mostrar_categoriasPrenda();
            
        }
        public void mostrar_categoriasPrenda()
        {
            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("select CATEGORIA_OMAR.NOMBRE_CATEGORIA_OMAR, CATEGORIA_OMAR.ID_CATEGORIA_OMAR from CATEGORIA_OMAR");
            while (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
            {
                creear_Botones_Categotia(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(),CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[1].ToString());
            }
            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
        }
        public void creear_Botones_Categotia(string categoria_Prenda, string idCategoria)
        {
            Button btnCategoria = new Button();
            btnCategoria.Text = categoria_Prenda;
            btnCategoria.Tag = idCategoria;
            btnCategoria.TextAlign = ContentAlignment.MiddleRight;
            btnCategoria.Width = 100;
            btnCategoria.Height = 60;
            btnCategoria.Image = Properties.Resources.chamarra;
            btnCategoria.ImageAlign = ContentAlignment.MiddleLeft;
            flpanelCategoria.Controls.Add(btnCategoria);
            btnCategoria.Click += new EventHandler(eventos_btnCategorias_omar);
        }
        public void eventos_btnCategorias_omar(object sender, EventArgs e)
        {
            flPanelClientes.Controls.Clear();
            Button idCategorias = sender as Button;
            idCategoria = Convert.ToString(idCategorias.Tag);
            mostrarPrendas();
        }
        public void mostrarPrendas()
        {
            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select PRENDA_OMAR.NOMBRE_PRENDA_OMAR, PRENDA_OMAR.MODELO_PRENDA_OMAR from PRENDA_OMAR Where PRENDA_OMAR.ID_CATEGORIA_OMAR='" + idCategoria+"'");
            while (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
            {
                btnPrendas(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(),CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[1].ToString());
            }
            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
        }
        public void btnPrendas(string nomPrenda, string modeloPrenda)
        {
            Button btnPrendas = new Button();
            btnPrendas.Text = nomPrenda;
            btnPrendas.Tag = modeloPrenda;
            btnPrendas.TextAlign = ContentAlignment.MiddleRight;
            btnPrendas.Width = 100;
            btnPrendas.Height = 100;
            btnPrendas.Image = Properties.Resources.corbata;
            btnPrendas.ImageAlign = ContentAlignment.MiddleLeft;
            flPanelClientes.Controls.Add(btnPrendas);
            btnPrendas.Click += new EventHandler(eventoPrendas_Omar);
        }
        public void eventoPrendas_Omar(object sender, EventArgs e)
        {
            Button tagPrenda = sender as Button;
            modeloDePrenda = Convert.ToString(tagPrenda.Tag);
            lblDetaVenta.Visible = true;
            taaVentas.Visible = true;
            lblTotalVenta.Visible = true;
            lblcantiVenta.Visible = true;
            btnRegClientes.Visible = true;
            try
            {
                cantidad =Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Cantidad de las prendas","¿Cual es su Cantidado?"));
                if (cantidad<=0)
                {
                    MessageBox.Show("Coloca una canitidad Positivia");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_venta_dv'" + folioVenta + "','" + cliente_omar + "','" + modeloDePrenda + "', " + cantidad + "");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(taaVentas, "exec proc_consulta_mostrar_venta '" + folioVenta + "'");
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select VENTA_OMAR.TOTAL_VENTA_OMAR from VENTA_OMAR where VENTA_OMAR.FOLIO_VENTA_OMAR='"+folioVenta+"'");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        lblcantiVenta.Text = Convert.ToString(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0]);
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                }
            }
            catch
            {
                MessageBox.Show("Coloque una cantidad");
            }
            
        }
        private void btnRegresarMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 menu = new Form1();
            menu.Show();
        }

        private void btnRegClientes_Click(object sender, EventArgs e)
        {
            lblCliente.Visible = false;
            lblnomCliente.Visible = false;
            lblCategorias.Visible = false;
            flpanelCategoria.Visible = false;
            lblDetaVenta.Visible = false;
            taaVentas.Visible = false;
            lblTotalVenta.Visible = false;
            lblcantiVenta.Visible = false;
            btnRegClientes.Visible = false;
            flpanelCategoria.Controls.Clear();
            flPanelClientes.Controls.Clear();
            lblClientCate.Text = "CLIENTES";
            cliente_omar = "";
            idCategoria = "";
            modeloDePrenda = "";
            folioVenta = "";
            cantidad = 0;
            omar_mostrar_Clientes();
        }
    }
}
