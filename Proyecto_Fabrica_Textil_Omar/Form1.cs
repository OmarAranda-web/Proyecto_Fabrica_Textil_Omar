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
            this.Hide();
            Incluir_Detalles_FabricaOmar formIncluir = new Incluir_Detalles_FabricaOmar();
            formIncluir.Show();
        }

        private void btnPrendas_Click(object sender, EventArgs e)
        {
            this.Hide();
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

        private void mosatrarImgDevolucion2(object sender, MouseEventArgs e)
        {
            btnDevoluciones.BackgroundImage = Properties.Resources.insertarDevoluciones2;
        }
        private void btnDevoluciones_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackgroundImage = Properties.Resources.insertarDevoluciones1;
        }
    }
}