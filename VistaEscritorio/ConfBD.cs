using AccesoDato;
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
    public partial class ConfBD : Form
    {
        public ConfBD()
        {
            InitializeComponent();
        }

        private void lsCadCon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCadCon.Text = SqlServerCSM.GetConnectionString(lsCadCon.SelectedItem.ToString());

        }

        private void ConfBD_Load(object sender, EventArgs e)
        {
            List<string> listaCadCon = SqlServerCSM.GetConnectionStringNames();
            //lsCadCon.DataSource = listaCadCon;
            lsCadCon.Items.Clear();
            lsCadCon.Items.Add("Seleccione");
            foreach (string elemento in listaCadCon)
            {
                lsCadCon.Items.Add(elemento);
            }
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadcon = @"Server = {0}; Database = {1}; Trusted_Connection = True;";
                cadcon = string.Format(cadcon, txtServidor.Text, txtEsquema.Text);
                SqlServerCSM.SaveConnectionString(lsCadCon.SelectedItem.ToString(), cadcon);
                MessageBox.Show("Catálogo de Muebles", "Configuración de Base de Datos completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCadCon.Text = SqlServerCSM.GetConnectionString(lsCadCon.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Catálogo de Muebles", "Error al configurar la Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
