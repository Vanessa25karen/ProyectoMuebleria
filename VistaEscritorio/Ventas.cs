using AccesoDato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaEscritorio
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        BD cbd = new BD();

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtBuscarMueble.Clear();
            TxtBuscarVenta.Clear();
            BtnMostrar.PerformClick();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = cbd.buscarVentaVentas(Convert.ToInt16(TxtBuscarMueble.Text));
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    DGVSalas.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Busque el codigo a eliminar", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            DataTable t = cbd.mostrarVentas();
            if (t.Rows.Count > 0)
            {

                DGVSalas.DataSource = t;
            }
            else
            {
                MessageBox.Show("No se encontraron registros", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBuscar2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = cbd.buscarVenta(Convert.ToInt16(TxtBuscarVenta.Text));
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    DGVSalas.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Busque el codigo a eliminar", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TxtBuscarMueble_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtBuscarVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }
    }
}
