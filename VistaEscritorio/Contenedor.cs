using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaEscritorio
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        ReportesPDF repo = new ReportesPDF();

        private void puntoDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PuntoVenta Pv = new PuntoVenta();
            Pv.MdiParent = this;
            Pv.Show();
        }

        private void registrosDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Este apartado es para uso informativo, si desea realizar una modificacion es en la ventana 'Punto de Venta'",
                   "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Ventas v = new Ventas();
            v.MdiParent = this;
            v.Show();
        }

        private void funcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Muebles Mb = new Muebles();
            Mb.MdiParent = this;
            Mb.Show();
        }

        private void todasLasSalasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                repo.reporteSalas();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar el archivo.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salasConPrecioMayorA1000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                repo.reporteSalasMayor();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar el archivo.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salasConPrecioMenorA1000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                repo.reporteSalasMenor();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar el archivo.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                repo.Ventas();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo guardar el archivo.", "Reportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void basesDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfBD configBD = new ConfBD();
            configBD.MdiParent = this;
            configBD.Show();
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {

        }
    }
}
