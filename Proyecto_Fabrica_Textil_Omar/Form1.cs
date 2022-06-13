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
    public partial class Form1 : Form
    {
        public static int ocultaBotines = 0;
        public static int ocultaRegCliente = 0;
        public static int ocultaRegPrendas = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CONEXION_MAESTRA_OMAR_FA.ConectarBDFabrica();
        }

        private void btnIngresarDetalles_Click(object sender, EventArgs e)
        {
            Incluir_Detalles_FabricaOmar formIncluir = new Incluir_Detalles_FabricaOmar();
            ocultaBotines = 1;
            formIncluir.Show();
        }

        private void btnPrendas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ocultaRegPrendas = 1;
            prendaOmar fomrPrenda = new prendaOmar();
            fomrPrenda.Show();
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            PedidoOmar formPedido = new PedidoOmar();
            formPedido.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ocultaRegCliente = 1;
            ClienteOmar formCliente = new ClienteOmar();
            formCliente.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentaOmar formVenta = new VentaOmar();
            formVenta.Show();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            DevolucionesOmar formdevoluciones = new DevolucionesOmar();
            formdevoluciones.Show();
        }

        private void btnMateriaPrima_Click(object sender, EventArgs e)
        {
            this.Hide();
            MateriPrimaOmar formmateriPrima = new MateriPrimaOmar();
            formmateriPrima.Show();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            this.Hide();
            CompraOmar fomrcompra = new CompraOmar();
            fomrcompra.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProveedorOmar formproveedor = new ProveedorOmar();
            formproveedor.Show();
        }

        private void btnPerdida_Click(object sender, EventArgs e)
        {
            this.Hide();
            PerdidasOmar formperdidas = new PerdidasOmar();
            formperdidas.Show();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalOmar formpersonal = new PersonalOmar();
            formpersonal.Show();
        }

        private void btnAsitencias_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsitenciasOmar frasitencias = new AsitenciasOmar();
            frasitencias.Show();
        }

        private void imagen2MoInsertar(object sender, MouseEventArgs e)
        {
            btnPrendas.BackgroundImage = Properties.Resources.insertarPrenda21;
        }

        private void imagen1MoiNSERTAR(object sender, EventArgs e)
        {
            btnPrendas.BackgroundImage = Properties.Resources.insertarPrenda11;
        }

        private void mostrarPedido2(object sender, MouseEventArgs e)
        {
            btnPedido.BackgroundImage = Properties.Resources.insertarPedido2;
        }

        private void mostarPedido1(object sender, EventArgs e)
        {
            btnPedido.BackgroundImage = Properties.Resources.insertarPedido1;
        }

        private void mosatrarImgCliente2(object sender, MouseEventArgs e)
        {
            btnCliente.BackgroundImage = Properties.Resources.insertarCliente21;
        }

        private void mostrarImgCliente1(object sender, EventArgs e)
        {
            btnCliente.BackgroundImage = Properties.Resources.insertarCliente1;
        }

        private void btnDevoluciones_MouseMove(object sender, MouseEventArgs e)
        {
            btnDevoluciones.BackgroundImage = Properties.Resources.insertarDevoluciones2;
        }

        private void btnDevoluciones_MouseLeave(object sender, EventArgs e)
        {
            btnDevoluciones.BackgroundImage = Properties.Resources.insertarDevoluciones1;
        }

        private void btnMateriaPrima_MouseMove(object sender, MouseEventArgs e)
        {
            btnMateriaPrima.BackgroundImage = Properties.Resources.insertarMateria2;
        }

        private void btnMateriaPrima_MouseLeave(object sender, EventArgs e)
        {
            btnMateriaPrima.BackgroundImage = Properties.Resources.insertarMateria1;
        }

        private void btnProveedor_MouseMove(object sender, MouseEventArgs e)
        {
            btnProveedor.BackgroundImage = Properties.Resources.insertarProveedor2;
        }

        private void btnProveedor_MouseLeave(object sender, EventArgs e)
        {
            btnProveedor.BackgroundImage = Properties.Resources.insertarProveedor;
        }

        private void btnPerdida_MouseMove(object sender, MouseEventArgs e)
        {
            btnPerdida.BackgroundImage = Properties.Resources.insertarPerdida2;
        }

        private void btnPerdida_MouseLeave(object sender, EventArgs e)
        {
            btnPerdida.BackgroundImage = Properties.Resources.insertarPerdida1;
        }

        private void btnAsitencias_MouseMove(object sender, MouseEventArgs e)
        {
            btnAsitencias.BackgroundImage = Properties.Resources.insertarAsistencia2;
        }

        private void btnAsitencias_MouseLeave(object sender, EventArgs e)
        {
            btnAsitencias.BackgroundImage = Properties.Resources.insertarAsistencia1;
        }

        private void btnPersonal_MouseMove(object sender, MouseEventArgs e)
        {
            btnPersonal.BackgroundImage = Properties.Resources.insertarPersonal2;
        }

        private void btnPersonal_MouseLeave(object sender, EventArgs e)
        {
            btnPersonal.BackgroundImage = Properties.Resources.insertarPersonal1;
        }

        private void btnVenta_MouseMove(object sender, MouseEventArgs e)
        {
            btnVenta.BackgroundImage = Properties.Resources.insertarVenta2;
        }

        private void btnVenta_MouseLeave(object sender, EventArgs e)
        {
            btnVenta.BackgroundImage = Properties.Resources.insertarVenta1;
        }

        private void btnCompra_MouseMove(object sender, MouseEventArgs e)
        {
            btnCompra.BackgroundImage = Properties.Resources.insertarCompra2;
        }

        private void btnCompra_MouseLeave(object sender, EventArgs e)
        {
            btnCompra.BackgroundImage = Properties.Resources.insertarCompra1;
        }

        private void btnIngresarDetalles_MouseMove(object sender, MouseEventArgs e)
        {
            btnIngresarDetalles.BackgroundImage = Properties.Resources.insertarDetalle2;
        }

        private void btnIngresarDetalles_MouseLeave(object sender, EventArgs e)
        {
            btnIngresarDetalles.BackgroundImage= Properties.Resources.insertarDetalle1;
        }
    }
}