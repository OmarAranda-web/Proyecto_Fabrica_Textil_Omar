﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Button = System.Windows.Forms.Button;
using Excel = Microsoft.Office.Interop.Excel;

namespace Proyecto_Fabrica_Textil_Omar
{
    public partial class VentaOmar : Form
    {
        public static string cliente_omar="";
        public static string idCategoria="";
        public static string modeloDePrenda="";
        public static string folioVenta="";
        public static int cantidad=0;
        public static string folio_venta_selec="";
        public static string modelo_venta_selec = "";
        public static string nomPrenda_Selec = "";
        public static int eliminar_editar_venta;
        public static int cantidad_editar=0;
        public static int cantidad_seleccionada;
        private Worksheet hoja;

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
            lblOtra.Visible=false;
            btnExcel.Visible = false;
            lblgenFactura.Visible=false;
            lblClientCate.Text = "CLIENTES";
            
            omar_mostrar_Clientes();
            
        }
        private void mostrarClientes(object sender, EventArgs e)
        {
            //CONEXION_MAESTRA_OMAR_FA.llenar_Combox_Omar(cmbCliente, "Select CLIENTE_OMAR.RAZON_SOCIAL_CLIENTE_OMAR from CLIENTE_OMAR where CLIENTE_OMAR.STATUS_CLIENTE_OMAR=1");
        }

        public void omar_mostrar_Clientes()
        {
            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("select UPPER(CLIENTE_OMAR.RAZON_SOCIAL_CLIENTE_OMAR), CLIENTE_OMAR.CLAVE_CLIENTE_OMAR from CLIENTE_OMAR ORDER BY CLIENTE_OMAR.RAZON_SOCIAL_CLIENTE_OMAR");
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
            nuevo_Boton.TextAlign = ContentAlignment.BottomCenter;
            nuevo_Boton.Width = 150;
            nuevo_Boton.Height = 100;
            nuevo_Boton.Image = Properties.Resources.clientes;
            nuevo_Boton.ImageAlign = ContentAlignment.MiddleCenter;
            nuevo_Boton.BackColor = Color.PaleTurquoise;
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
            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("select UPPER(CATEGORIA_OMAR.NOMBRE_CATEGORIA_OMAR), CATEGORIA_OMAR.ID_CATEGORIA_OMAR from CATEGORIA_OMAR order by CATEGORIA_OMAR.NOMBRE_CATEGORIA_OMAR");
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
            btnCategoria.TextAlign = ContentAlignment.BottomCenter;
            btnCategoria.Width = 130;
            btnCategoria.Height = 100;
            btnCategoria.Image = Properties.Resources.aprenda1;
            btnCategoria.ImageAlign = ContentAlignment.MiddleCenter;
            btnCategoria.BackColor = Color.PaleTurquoise;
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
            btnPrendas.TextAlign = ContentAlignment.BottomCenter;
            btnPrendas.Width = 150;
            btnPrendas.Height = 100;
            btnPrendas.Image = Properties.Resources.aprenda2;
            btnPrendas.ImageAlign = ContentAlignment.MiddleCenter;
            btnPrendas.BackColor = Color.PaleTurquoise;
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
            lblOtra.Visible = true;
            btnExcel.Visible = true;
            lblgenFactura.Visible = true;
            try
            {
                cantidad =Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Cantidad de las prendas","¿Cual es su Cantidado?"));
                if (cantidad<=0)
                {
                    MessageBox.Show("COLOCA UNA CANITIDAD POSITIVIA","MENSAJE DE FABRICA");
                }
                else
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_insertar_venta_dv'" + folioVenta + "','" + cliente_omar + "','" + modeloDePrenda + "', " + cantidad + "");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString(),"MENSAJE DE FABRICA");
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
                MessageBox.Show("COLOQUE UNA CANTIDAD","MENSAJE DE FABRICA");
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

        private void btnBuscarPrend_Click(object sender, EventArgs e)
        {
            BusquedaOmar frmBusqueda = new BusquedaOmar();
            frmBusqueda.ShowDialog();
        }

        private void seleccionar_folios(object sender, DataGridViewCellEventArgs e)
        {
            int indice_fila = e.RowIndex;
            folio_venta_selec = taaVentas.Rows[indice_fila].Cells[0].Value.ToString();
            modelo_venta_selec = taaVentas.Rows[indice_fila].Cells[1].Value.ToString();
            nomPrenda_Selec = taaVentas.Rows[indice_fila].Cells[2].Value.ToString();
            try
            {
                eliminar_editar_venta = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("¿Que deseas Hacer?\n1.-Eliminar\n2.-Editar\n3.-Cancelar"));
                if (eliminar_editar_venta == 1)
                {
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_eliminarar_detalle_venta '"+folio_venta_selec+"', '"+modelo_venta_selec+"'");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select VENTA_OMAR.TOTAL_VENTA_OMAR from VENTA_OMAR where VENTA_OMAR.FOLIO_VENTA_OMAR='" + folioVenta + "'");
                    if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                    {
                        lblcantiVenta.Text = Convert.ToString(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0]);
                    }
                    CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                    CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(taaVentas, "exec proc_consulta_mostrar_venta '" + folioVenta + "'");
                }
                if (eliminar_editar_venta == 2)
                {
                    cantidad_editar = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Coloque cuantos prendas del modelo "+nomPrenda_Selec+" desea quitar"));
                    if (cantidad_editar <= 0)
                    {
                        MessageBox.Show("No Se edito ningun registro");
                    }
                    else
                    {
                        CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select DETALLE_VENTA_OMAR.CANTIDAD_PRENDAS_DV_OMAR from DETALLE_VENTA_OMAR where DETALLE_VENTA_OMAR.FOLIO_VENTA_OMAR='"+folio_venta_selec+"' and DETALLE_VENTA_OMAR.MODELO_PRENDA_OMAR='"+modelo_venta_selec+"'");
                        if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                        {
                            cantidad_seleccionada = Convert.ToInt32(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                        }
                        CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                        if (cantidad_editar>=cantidad_seleccionada)
                        {
                            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_eliminarar_detalle_venta '" + folio_venta_selec + "', '" + modelo_venta_selec + "'");
                            if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                            {
                                MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                            }
                            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select VENTA_OMAR.TOTAL_VENTA_OMAR from VENTA_OMAR where VENTA_OMAR.FOLIO_VENTA_OMAR='" + folioVenta + "'");
                            if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                            {
                                lblcantiVenta.Text = Convert.ToString(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0]);
                            }
                            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                            CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(taaVentas, "exec proc_consulta_mostrar_venta '" + folioVenta + "'");
                        }
                        else
                        {
                            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec proc_editar_detalleventa '"+folio_venta_selec+"', '"+modelo_venta_selec+"', "+cantidad_editar+"");
                            if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                            {
                                MessageBox.Show(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString());
                            }
                            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();

                            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select VENTA_OMAR.TOTAL_VENTA_OMAR from VENTA_OMAR where VENTA_OMAR.FOLIO_VENTA_OMAR='" + folioVenta + "'");
                            if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
                            {
                                lblcantiVenta.Text = Convert.ToString(CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0]);
                            }
                            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
                            CONEXION_MAESTRA_OMAR_FA.mostrar_Tabla_Omar(taaVentas, "exec proc_consulta_mostrar_venta '" + folioVenta + "'");
                        }
                    }
                }
            }
            catch {
                MessageBox.Show("Solo son admitidos numeros");
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string cliente="", direccionClien="", emailCli="", telefonoClien="",fecha="";
            int filas = 14;
            Excel.Application aplicacion = new Microsoft.Office.Interop.Excel.Application();
            Workbook libro = aplicacion.Workbooks.Add("Disenio_de_factuta");
            aplicacion.Visible = true;
            hoja = (Excel.Worksheet)libro.Worksheets.get_Item(1);
            hoja.Cells[4, 7]=folioVenta;
            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("Select VENTA_OMAR.FECHA_HORA_VENTA from VENTA_OMAR Where VENTA_OMAR.FOLIO_VENTA_OMAR='" + folioVenta+"'");
            if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
            {
                hoja.Cells[1, 7] = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
            }
            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("select CLIENTE_OMAR.RAZON_SOCIAL_CLIENTE_OMAR , CLIENTE_OMAR.DIRECCION_CLIENTE_OMAR, CLIENTE_OMAR.EMAIL_CLIENTE_OMAR, CLIENTE_OMAR.TELEFONO_CLIENTE_OMAR from CLIENTE_OMAR where CLIENTE_OMAR.CLAVE_CLIENTE_OMAR='"+cliente_omar+"'");
            if (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
            {
                cliente = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                direccionClien = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[1].ToString();
                emailCli = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[2].ToString();
                telefonoClien = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[3].ToString();
            }
            CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Close();
            hoja.Cells[7, 3] = cliente;
            hoja.Cells[10, 3] = direccionClien;
            hoja.Cells[10, 7] = emailCli;
            hoja.Cells[11,7] = telefonoClien;

            CONEXION_MAESTRA_OMAR_FA.ejecutar_Omar_Fa("exec consulta_detalle_venta '"+folioVenta+"'");
            while (CONEXION_MAESTRA_OMAR_FA.leer_omar_fa.Read())
            {
                hoja.Cells[filas, 3] = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[0].ToString();
                hoja.Cells[filas,6]=CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[2].ToString();
                hoja.Cells[filas, 7] = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[1].ToString();
                hoja.Cells[filas, 8] = CONEXION_MAESTRA_OMAR_FA.leer_omar_fa[3].ToString();
                filas++;
            }
            libro.SaveAs(@"C:\Users\omara\Documents\"+folioVenta+".xlsx");
            libro.PrintPreview();
            aplicacion.Quit();
        }
        /*
private void obtenerClave(object sender, KeyEventArgs e)
{
   if (e.KeyValue == 13)
   {
   MessageBox.Show("Se presiono el enter");
   //txtPrueba.Focus();
}
}
private void button1_Click(object sender, EventArgs e)
{
MessageBox.Show("Hola");
}

private void eventEnter1(object sender, KeyEventArgs e)
{
if (e.KeyValue == 13)
{
//MessageBox.Show("Se presiono el enter");
button1_Click(sender, e);

}
}
*/
    }
}
