using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _05FormulariosyEventos.views.Clientes;

namespace _05FormulariosyEventos.views.Dashboard
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Dahsboard_Load(object sender, EventArgs e)
        {

        }

        public void organizar()
        {
            int alto = Dashboard.ActiveForm.Height;
            int ancho = Dashboard.ActiveForm.Width;

            imagen.Left = (ancho - imagen.Width) / 2;
            imagen.Top = (alto - imagen.Width) / 2;
        }

        private void nuevoClienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NuevoEditarCliente _nuevoeditarcliente = new NuevoEditarCliente();
            _nuevoeditarcliente.ShowDialog();
        }

        private void listaDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClientes _listaClientes = new ListaClientes();
            _listaClientes.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportesClientes _respotesClientes = new ReportesClientes();
            _respotesClientes.ShowDialog();
        }

        private void Dashboard_SizeChanged(object sender, EventArgs e)
        {
            organizar();
        }
    }
}
