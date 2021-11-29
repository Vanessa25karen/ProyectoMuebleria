using AccesoDato;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace VistaWeb
{
    public partial class Clientes : System.Web.UI.Page
    {
        BD cbd = new BD();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter t = cbd.mostrarClientes();
            DataSet ds = new DataSet();

            t.Fill(ds, "Clientes");
            DgClientes.DataSource = ds;
            DgClientes.DataMember = "Clientes";
            DgClientes.DataBind();


            //}
            //else
            //{
            //    MessageBox.Show("No se encontraron registros", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        protected void DgClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnMostrar_Click1(object sender, EventArgs e)
        {
            SqlDataAdapter t = cbd.mostrarClientes();
            DataSet ds = new DataSet();
            //if (t.Rows.Count > 0)
            //{
            t.Fill(ds, "Clientes");
            DgClientes.DataSource = ds;
            DgClientes.DataMember = "Clientes";
            DgClientes.DataBind();

        }

        protected void btnValidarCliente_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter t = cbd.mostrarClientes();
                DataSet ds = new DataSet();

                t.Fill(ds, "Clientes");
                DgClientes.DataSource = ds;
                DgClientes.DataMember = "Clientes";
                DgClientes.DataBind();
            }
            catch (Exception)
            {
                MessageBox.Show("Busque el codigo a eliminar", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            try
            {
            SqlDataReader sr = cbd.mostrarClientesFiltro(Convert.ToInt32(txtidCliente.Text));
            if (sr.Read())
            {

                txtidCliente.Text = sr[0].ToString();
                txtNombre.Text = sr[1].ToString();
                txtTelefono.Text = sr[2].ToString();
            }
            }
            catch (Exception)
            {
                MessageBox.Show("Busque el codigo a eliminar", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        protected void BtnGuardar_Click1(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" && txtidCliente.Text == "" && txtTelefono.Text == "")
                {
                    int res = cbd.agregarCliente(Convert.ToInt32(txtidCliente.Text), txtNombre.Text, txtTelefono.Text);

                    if (Convert.ToBoolean(res))
                    {
                        Response.Write("<script> alert ('Cliente correctamente registrado'); </script>");
                        txtidCliente.Text = "";
                        txtNombre.Text = "";
                        txtTelefono.Text = "";
                    }
                    else
                    {
                        Response.Write("<script> alert ('Error al registrar'); </script>");
                    }
                }
                else
                {
                    Response.Write("<script> alert ('Error al registrar'); </script>");
                }
            }
            catch (Exception)
            {
                Response.Write("<script> alert ('Error al registrar'); </script>");
            }
        }

        protected void BtnActualizar_Click1(object sender, EventArgs e)
        {
            try
            {
                if (txtidCliente.Text == "" && txtNombre.Text == "" && txtTelefono.Text == "")
                {
                    int res = cbd.modificarCliente(Convert.ToInt32(txtidCliente.Text), txtNombre.Text, txtTelefono.Text);

                    if (Convert.ToBoolean(res))
                    {
                        Response.Write("<script> alert ('Cliente correctamente modificado'); </script>");
                        txtidCliente.Text = "";
                        txtNombre.Text = "";
                        txtTelefono.Text = "";

                    }
                    else
                    {
                        Response.Write("<script> alert ('Error al modificar'); </script>");
                    }
                }
                else
                {
                    Response.Write("<script> alert ('Error al modificar'); </script>");
                }
            }
            catch (Exception)
            {
                Response.Write("<script> alert ('Error al modificar'); </script>");
            }
        }
    }
}