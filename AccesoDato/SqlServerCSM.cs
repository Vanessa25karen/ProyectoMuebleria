using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient; // Debe agregarse en referencias y en using

// Tomado de http://geeks.ms/blogs/lfranco/archive/2011/10/20/howto-modificar-cadena-de-conexi-243-n-la-eterna-pregunta.aspx
namespace AccesoDato
{
    /// <summary>
    ///  SQL Server Connection String Manager:
    ///  Esta clase se usa para administrar las cadenas de conexión de la aplicación para que puedan modificarse dinamicamente cuando sea implementado.
    /// </summary>
    public class SqlServerCSM
    {
        /// <summary>
        /// Este metodo recupera una cadena de conexión mediante su nombre
        /// </summary>
        /// <param name="connectionStringName">Nombre de la cadena de conexión a recuperar</param>
        /// <returns>Cadena de conexión</returns>
        public static string GetConnectionString(string connectionStringName)
        {
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringSettings connStringSettings = appconfig.ConnectionStrings.ConnectionStrings[connectionStringName];
            return connStringSettings.ConnectionString;
        }
        /// <summary>
        /// Este metodo guarda una cadena de conexión
        /// </summary>
        /// <param name="connectionStringName">Nombre de la cadena de conexión</param>
        /// <param name="connectionString">Cadena de conexión</param>
        public static void SaveConnectionString(string connectionStringName, string connectionString)
        {
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            appconfig.ConnectionStrings.ConnectionStrings[connectionStringName].ConnectionString = connectionString;
            appconfig.Save();
        }
        /// <summary>
        /// Obtiene los nombres de las conexiones existentes
        /// </summary>
        /// <returns>Lista de nombres de las conexiones existentes</returns>
        public static List<string> GetConnectionStringNames()
        {
            List<string> cns = new List<string>();
            Configuration appconfig =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            foreach (ConnectionStringSettings cn in appconfig.ConnectionStrings.ConnectionStrings)
            {
                cns.Add(cn.Name);
            }
            return cns;
        }

        public static string GetFirstConnectionStringName()
        {
            return GetConnectionStringNames().FirstOrDefault();
        }

        public static string GetFirstConnectionString()
        {
            return GetConnectionString(GetFirstConnectionStringName());
        }

        //private void showSavedConnectionSettings()
        //{
        //    SqlConnectionStringBuilder builder =
        //        new SqlConnectionStringBuilder(ConnectionStringManager.GetFirstConnectionString());
        //    connectionServerComboBox.EditValue = builder.DataSource.ToUpper();
        //    connectionDatabaseComboBox.EditValue = builder.InitialCatalog.ToUpper();
        //    if (builder.IntegratedSecurity)
        //    {
        //        connectionAuthenticationModeRadioGroup.EditValue = 0;
        //        connectionUsernameTextEdit.Text = string.Empty;
        //        connectionPasswordTextEdit.Text = string.Empty;
        //    }
        //    else
        //    {
        //        connectionAuthenticationModeRadioGroup.EditValue = 1;
        //        connectionUsernameTextEdit.Text = builder.UserID;
        //        connectionPasswordTextEdit.Text = builder.Password;
        //    }
        //}

        public static string GetSqlServerServerName()
        {
            string cs = GetConnectionString(GetFirstConnectionStringName());
            if (cs != null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                return builder.DataSource;
            }
            else
                return null;
        }

        public static string GetSqlServerDatabaseName()
        {
            string cs = GetConnectionString(GetFirstConnectionStringName());
            if (cs != null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                return builder.InitialCatalog;
            }
            else
                return null;
        }

        public static string GetSqlServerUserName()
        {
            string cs = GetConnectionString(GetFirstConnectionStringName());
            if (cs != null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                return builder.UserID;
            }
            else
                return null;
        }

        public static string GetSqlServerPassword()
        {
            string cs = GetConnectionString(GetFirstConnectionStringName());
            if (cs != null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                return builder.Password;
            }
            else
                return null;
        }

        public static bool? GetSqlServerIntegratedSecurity()
        {
            string cs = GetConnectionString(GetFirstConnectionStringName());
            if (cs != null)
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(cs);
                return builder.IntegratedSecurity;
            }
            else
                return null;
        }

        //Guardar valores de propiedades en la cadena de conexión:

        public static string SetConnectionStringServerName(
            string connectionString, string serverName)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.DataSource = serverName;
            return builder.ConnectionString;
        }

        public static string SetConnectionStringAutenticationIntegrated(
            string connectionString)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.IntegratedSecurity = true;
            return builder.ConnectionString;
        }

        public static string SetConnectionStringAutenticationSQLServer(
            string connectionString, string username, string password)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.IntegratedSecurity = false;
            builder.UserID = username;
            builder.Password = password;
            return builder.ConnectionString;
        }

        public static string SetConnectionStringDatabaseName(
            string connectionString, string databaseName)
        {
            SqlConnectionStringBuilder builder =
                new SqlConnectionStringBuilder(connectionString);
            builder.InitialCatalog = databaseName;
            return builder.ConnectionString;
        }

    }
}