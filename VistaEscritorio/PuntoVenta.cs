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
    public partial class PuntoVenta : Form
    {
        public PuntoVenta()
        {
            InitializeComponent();
        }

        BD cbd = new BD();
        Total tt = new Total();
        bool editando = false;
        Validaciones validar = new Validaciones();

        private void PuntoVenta_Load(object sender, EventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            editando = false;
            TxtCodigoVenta.Clear();
            TxtNombreCliente.Clear();
            TxtFechaCompra.Clear();
            TxtCodSala.Clear();
            TxtCantSillones.Clear();
            TxtPrecioSillon.Clear();
            TxtTotal.Clear();
            BuscarVenta.Clear();
            BtnMostrarVentas.PerformClick();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigoVenta.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtNombreCliente.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtFechaCompra.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtCodSala.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtPrecioSillon.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtTotal.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int res = 0;
                    string exito = "", error = "";
                    if (editando == false)
                    {
                        //insert
                        res = cbd.agregarCompra(Convert.ToInt16(TxtCodigoVenta.Text), TxtNombreCliente.Text, Convert.ToDateTime(TxtFechaCompra.Text), Convert.ToInt16(TxtCodSala.Text), Convert.ToInt16(TxtCantSillones.Text), Convert.ToInt32(TxtTotal.Text));
                        exito = "Venta realizada con exito";
                        error = "Venta no realizada";
                        BtnNuevo.PerformClick();
                    }
                    //else
                    //{
                    //    //update
                    //    res = cbd.modificarVenta(Convert.ToInt16(TxtCodigoVenta.Text), TxtNombreCliente.Text, Convert.ToDateTime(TxtFechaCompra.Text), SalasMenor.Checked, Convert.ToInt16(TxtCantSillones.Text), Convert.ToInt16(TxtTotal.Text));
                    //    exito = "Datos del vehículo modificados";
                    //    error = "No se pudo modificar los datos del vehículo";
                    //}
                    if (res > 0)
                    {
                        MessageBox.Show(exito, "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnMostrarVentas.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(error, "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al guardar", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCodigoVenta.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtNombreCliente.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtFechaCompra.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtCodSala.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtPrecioSillon.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtTotal.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int res = 0;
                    string exito = "", error = "";
                    if (editando == false)
                    //{
                    //    //insert
                    //    res = cbd.agregarCompra(Convert.ToInt16(TxtCodigoVenta.Text), TxtNombreCliente.Text, Convert.ToDateTime(TxtFechaCompra.Text), Convert.ToInt16(TxtCodSala.Text), SalasMenor.Checked, Convert.ToInt16(TxtCantSillones.Text), Convert.ToInt32(TxtTotal.Text));
                    //    exito = "Venta realizada con exito";
                    //    error = "Venta no realizada";
                    //}
                    //else
                    {
                        //update
                        res = cbd.modificarVenta(Convert.ToInt16(TxtCodigoVenta.Text), TxtNombreCliente.Text, Convert.ToDateTime(TxtFechaCompra.Text), Convert.ToInt16(TxtCantSillones.Text), Convert.ToInt16(TxtTotal.Text));
                        exito = "Datos de ventas modificados";
                        error = "No se pudo modificar los datos de ventas";
                        BtnNuevo.PerformClick();
                    }
                    if (res > 0)
                    {
                        MessageBox.Show(exito, "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnMostrarVentas.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(error, "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al guardar", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            editando = false;
            TxtCodigoVenta.Clear();
            TxtNombreCliente.Clear();
            TxtFechaCompra.Clear();
            TxtCodSala.Clear();
            TxtCantSillones.Clear();
            TxtPrecioSillon.Clear();
            TxtTotal.Clear();
            BuscarVenta.Clear();
            BtnMostrarVentas.PerformClick();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = cbd.buscarVenta(Convert.ToInt16(BuscarVenta.Text));
                SqlDataReader sr = cbd.buscarVenta(Convert.ToInt16(BuscarVenta.Text));

                if (dr.HasRows && sr.Read())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    DGVSalas.DataSource = dt;
                    TxtCodigoVenta.Text = sr[0].ToString();
                    TxtNombreCliente.Text = sr[1].ToString();
                    TxtFechaCompra.Text = sr[2].ToString();
                    TxtCodSala.Text = sr[3].ToString();
                    TxtCantSillones.Text = sr[4].ToString();
                    TxtTotal.Text = sr[5].ToString();
                    //TxtTotal.Text = sr[6].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese codigo a buscar", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMostrarVentas_Click(object sender, EventArgs e)
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string exito = "Registro eliminado";
                string error = "No se pudo eliminar el registro";
                int res = cbd.eliminarVenta(Convert.ToInt16(BuscarVenta.Text));
                if (res > 0)
                {
                    MessageBox.Show(exito, "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnMostrarVentas.PerformClick();
                    BtnCancelar.PerformClick();
                }
                else
                {
                    MessageBox.Show(error, "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Busque el codigo a eliminar", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnbb_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = cbd.buscarSala(Convert.ToInt16(TxtCodSala.Text));
                if (dr.Read())
                {
                    TxtPrecioSillon.Text = dr[4].ToString();
                    //DataTable dt = new DataTable();
                    //dt.Load(dr);
                    //DGVSalas.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros", "Módulo de Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese codigo a buscar", "Módulo de Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int Precio = Convert.ToInt16(TxtPrecioSillon.Text);
                int Cant = Convert.ToInt16(TxtCantSillones.Text);
                int to;
                to = tt.Totales(Precio, Cant);
                TxtTotal.Text = Convert.ToString(to);
            }
            catch (Exception)
            {
                MessageBox.Show("Porfavor llene todo los campos", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnMostrarSalas_Click(object sender, EventArgs e)
        {
            DataTable t = cbd.mostrarSalas();
            if (t.Rows.Count > 0)
            {

                DGVSalas.DataSource = t;
            }
            else
            {
                MessageBox.Show("No se encontraron registros", "Módulo de Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBuscarSala_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = cbd.buscarSala(Convert.ToInt16(BuscarSala.Text));
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    DGVSalas.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No se encontraron registros", "Módulo de Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese codigo a buscar", "Módulo de Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCancelar2_Click(object sender, EventArgs e)
        {
            BuscarSala.Clear();
            BtnMostrarSalas.PerformClick();
        }

        private void TxtCodigoVenta_TextChanged(object sender, EventArgs e)
        {
      

        }

        private void TxtCodSala_TextChanged(object sender, EventArgs e)
        {
       

        }

        private void TxtCantSillones_TextChanged(object sender, EventArgs e)
        {


        }

        private void BuscarSala_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void BuscarVenta_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCodigoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtFechaCompra_TextChanged(object sender, EventArgs e)
        {
            //tb.Text = String.Format("{0:dd/MM/yyyy}", dt);
            //TxtFechaCompra.Text = string.Format()

        }

        private void TxtCodSala_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtPrecioSillon_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrecioSillon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtCantSillones_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void BuscarSala_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void BuscarVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void aaaa_Load(object sender, EventArgs e)
        {

        }
    }
}
