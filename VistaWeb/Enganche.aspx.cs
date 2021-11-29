using AccesoDato;
using MySql.Data.MySqlClient;
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
    public partial class Enganche : System.Web.UI.Page
    {

        BD bd = new BD();

        private void enviarMensaje(string titulo, string mensaje)
        {
            #region "Configuracion del modal"
            string modal = "<div class='modal fade' id='mimodal' data-backdrop='static' data-keyboard='false' tabindex='-1' aria-labelledby='staticBackdropLabel' aria-hidden='true'>"
                              + "<div class='modal-dialog'>"
                                + "<div class='modal-content'>"
                                  + "<div class='modal-header'>"
                                    + "<h5 class='modal-title' id='staticBackdropLabel'>" + titulo + "</h5>"
                                    + "<button type='button' class='close' data-dismiss='modal' aria-label='Close'>"
                                      + "<span aria-hidden='true'>&times;</span>"
                                    + "</button>"
                                  + "</div>"
                                  + "<div class='modal-body'>"
                                    + mensaje
                                  + "</div>"
                                  + "<div class='modal-footer'>"
                                  + "<button type='button' class='btn btn-secondary' data-dismiss='modal'>Aceptar</button>"
                                  + "</div>"
                                + "</div>"
                              + "</div>"
                            + "</div>";
            #endregion
            string script = "<script type='text/javascript'>$('#mimodal').modal();</script>";
            Literal1.Text = modal;
            ScriptManager.RegisterStartupScript(this, typeof(Page), modal, script, false);
        }
        private void enviarNotificacion(string titulo, string mensaje)
        {
            #region "Configuracion del toast"
            string toast = "<div class='position-fixed bottom-0 right-0 p-3' style='z-index: 5; right: 0; bottom: 0;'>"
                              + "<div id='notificacion' class='toast hide' role='alert' aria-live='assertive' aria-atomic='true' data-delay='5000'>"
                                + "<div class='toast-header'>"
                                  + "<img src='Imgs/logo.png' width='30' height='30' class='rounded mr-2' alt='...'>"
                                    + "<strong class='mr-auto'>" + titulo + "</strong>"
                                  + "<small>" + DateTime.Now.ToShortTimeString() + "</small>"
                                  + "<button type='button' class='ml-2 mb-1 close' data-dismiss='toast' aria-label='Close'>"
                                   + "<span aria-hidden='true'>&times;</span>"
                                  + "</button>"
                                + "</div>"
                                + "<div class='toast-body'>"
                                  + mensaje
                                + "</div>"
                              + "</div>"
                            + "</div>";
            #endregion
            string script = "<script type='text/javascript'>$('#notificacion').toast('show');</script>";
            Literal1.Text = toast;
            ScriptManager.RegisterStartupScript(this, typeof(Page), toast, script, false);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                rvInicioRenta.MinimumValue = DateTime.Today.ToShortDateString();
                rvInicioRenta.MaximumValue = DateTime.Today.AddYears(1).ToShortDateString();
            }
        }

        protected void btnValidarCliente_Click(object sender, EventArgs e)
        {

        }

        protected void btnValidarCliente_Click1(object sender, EventArgs e)
        {
            try
            {
                int resultado = bd.ValidarCliente(Convert.ToInt16(txtIdCliente.Text));
                SqlDataReader dr = bd.buscarCliente(Convert.ToInt16(txtIdCliente.Text));
                if (txtIdCliente.Text == "")
                {
                    Response.Write("<script> alert ('Ingrese un primero un id cliente, si no tiene favor de registrase en la seccion de clientes'); </script>");
                }
                else
                {
                    bool ban = false;
                    //string tipo = document.getElementsByName(rblTipo);

                    if (resultado == Convert.ToInt16(txtIdCliente.Text))
                    {
                        ban = true;
                    }
                    if (!ban)
                    {
                        Response.Write("<script> alert ('Ingrese un primero un id cliente, si no tiene favor de registrase en la seccion de clientes'); </script>");
                    }
                }
                if (dr.HasRows)
                {
                    MessageBox.Show("No se encontraron registros", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    enviarNotificacion("Salas", "Bienvenido");
                }
                else
                {
                    MessageBox.Show("No se encontraron registros", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    enviarNotificacion("Salas", "Cliente no registrado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontraron registros", "Módulo de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                enviarNotificacion("Salas", "Cliente no registrado");

            }
        }
     

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnRentar_Click(object sender, EventArgs e)
        {
            try
            {
                int res = bd.agregarVenta(Convert.ToInt32(txtIdCliente.Text), ddVehiculos.Text, Convert.ToInt32(txtInicioRenta.Text));

                if (Convert.ToBoolean(res))
                {
                    enviarMensaje("Renta de Unidades", "Se ha realizado la renta");
                }
                else
                {
                    enviarMensaje("Renta de Unidades", "No se ha podido realizar la renta");
                }
            }
            catch (Exception)
            { 
            }
            }
    }
}