using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AccesoDato;

namespace VistaEscritorio
{
    public partial class Muebles : Form
    {
        public Muebles()
        {
            InitializeComponent();
        }

        BD cbd = new BD();

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            TxtCodigoSala.Clear();
            TxtNombreSala.Clear();
            TxtDescSala.Clear();
            SalasMenor.Checked = false;
            TxtPrecioSillon.Clear();
            BuscarCodigoSala.Clear();
            BtnMostrarSalas.PerformClick();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombreSala.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtNombreSala.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtDescSala.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtPrecioSillon.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int res = 0;
                    string exito = "", error = "";
                    //if (editando == false)
                    {
                        //insert
                        res = cbd.agregarMuebles(Convert.ToInt16(TxtCodigoSala.Text), TxtNombreSala.Text, TxtDescSala.Text, SalasMenor.Checked, Convert.ToInt16(TxtPrecioSillon.Text));
                        exito = "Mueble guardado con exito";
                        error = "Mueble no guardado con exito";
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
                        MessageBox.Show(exito, "Módulo de Muebles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnMostrarSalas.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(error, "Módulo de Muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al guardar", "Módulo de Muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNombreSala.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtNombreSala.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtDescSala.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(TxtPrecioSillon.Text))
            {
                MessageBox.Show("Llene los campos vacios", "Módulo de muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int res = 0;
                    string exito = "", error = "";
                    //if (editando == false)
                    //{
                    //    //insert
                    //    res = cbd.agregarCompra(Convert.ToInt16(TxtCodigoVenta.Text), TxtNombreCliente.Text, Convert.ToDateTime(TxtFechaCompra.Text), Convert.ToInt16(TxtCodSala.Text), SalasMenor.Checked, Convert.ToInt16(TxtCantSillones.Text), Convert.ToInt32(TxtTotal.Text));
                    //    exito = "Venta realizada con exito";
                    //    error = "Venta no realizada";
                    //}
                    //else
                    {
                        //update
                        res = cbd.modificarSala(Convert.ToInt16(TxtCodigoSala.Text), TxtNombreSala.Text, TxtDescSala.Text, SalasMenor.Checked, Convert.ToInt16(TxtPrecioSillon.Text));
                        exito = "Datos de muebles modificados";
                        error = "No se pudo modificar los datos los muebles";
                        BtnNuevo.PerformClick();
                    }
                    if (res > 0)
                    {
                        MessageBox.Show(exito, "Módulo de Muebles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnMostrarSalas.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show(error, "Módulo de Muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al modificar", "Módulo de Muebles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtCodigoSala.Clear();
            TxtNombreSala.Clear();
            TxtDescSala.Clear();
            SalasMenor.Checked = false;
            TxtPrecioSillon.Clear();
            BuscarCodigoSala.Clear();
            BtnMostrarSalas.PerformClick();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dr = cbd.buscarSala(Convert.ToInt16(BuscarCodigoSala.Text));
                SqlDataReader sr = cbd.buscarSala(Convert.ToInt16(BuscarCodigoSala.Text));
                if (dr.HasRows && sr.Read())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    DGVSalas.DataSource = dt;
                    TxtCodigoSala.Text = sr[0].ToString();
                    TxtNombreSala.Text = sr[1].ToString();
                    TxtDescSala.Text = sr[2].ToString();
                    //SalasMenor.Checked = Convert.ToBoolean(dr[3]);
                    TxtPrecioSillon.Text = sr[4].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron registros", "Módulo de Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese el codigo a buscar", "Módulo de Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string exito = "Registro eliminado";
                string error = "No se pudo eliminar el registro";
                int res = cbd.eliminarSala(Convert.ToInt16(BuscarCodigoSala.Text));
                if (res > 0)
                {
                    MessageBox.Show(exito, "Módulo de Salas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BtnMostrarSalas.PerformClick();
                    BtnCancelar.PerformClick();
                }
                else
                {
                    MessageBox.Show(error, "Módulo de Salas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Busque el codigo a eliminar", "Módulo de Salas", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void TxtCodigoSala_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void TxtNombreSala_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtDescSala_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloLetras(e);
        }

        private void TxtPrecioSillon_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void BuscarCodigoSala_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones.SoloNumeros(e);
        }

        private void Muebles_Load(object sender, EventArgs e)
        {

        }
    }
}
