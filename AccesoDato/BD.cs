using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDato
{
    public class BD
    {
        private SqlConnection conexion;
        private string cadcon;

        private void conectarBD()
        {
            //cadcon = SqlServerCSM.GetConnectionString("LocalSqlServer");
            cadcon = @"Server = JROMO\KAREN; Database = Muebleria; Trusted_Connection = True;";
            try
            {
                conexion = new SqlConnection();
                conexion.ConnectionString = cadcon;
                conexion.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void desconectarBD()
        {
            conexion.Close();
        }

        //ESCRITORIO
        public int agregarCompra(int CodigoVenta, string NombreCliente, DateTime FechaCompra, int CodSala, int CantSillones, int Total)
        {
            int resultado = 0;
            string instruccion = "INSERT INTO [dbo].[PuntoVen] ([CodigoVenta],[NombreCliente],[FechaCompra],[CodSala],[CantSillones],[Total]) VALUES (@CodigoVenta,@NombreCliente,@FechaCompra,@CodSala,@CantSillones,@Total);";
            SqlParameter pCodigoVenta = new SqlParameter("CodigoVenta", System.Data.SqlDbType.VarChar);
            SqlParameter pNombreCliente = new SqlParameter("NombreCliente", System.Data.SqlDbType.VarChar);
            SqlParameter pFechaCompra = new SqlParameter("FechaCompra", System.Data.SqlDbType.Date);
            SqlParameter pCodSala = new SqlParameter("CodSala", System.Data.SqlDbType.Int);
            SqlParameter pCantSillones = new SqlParameter("CantSillones", System.Data.SqlDbType.Int);
            SqlParameter pTotal = new SqlParameter("Total", System.Data.SqlDbType.Int);
            pCodigoVenta.Value = CodigoVenta;
            pNombreCliente.Value = NombreCliente;
            pFechaCompra.Value = FechaCompra;
            pCodSala.Value = CodSala;
            pCantSillones.Value = CantSillones;
            pTotal.Value = Total;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(pCodigoVenta);
                cmd.Parameters.Add(pNombreCliente);
                cmd.Parameters.Add(pFechaCompra);
                cmd.Parameters.Add(pCodSala);
                cmd.Parameters.Add(pCantSillones);
                cmd.Parameters.Add(pTotal);
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int modificarVenta(int CodigoVenta, string NombreCliente, DateTime FechaCompra, int CantSillones, int Total)
        {
            int resultado = 0;
            string instruccion = "UPDATE [dbo].[PuntoVen] SET [NombreCliente] = @NombreCliente,[FechaCompra] = @FechaCompra,[CantSillones] = @CantSillones,[Total] = @Total WHERE [CodigoVenta] = @CodigoVenta;";
            SqlParameter pCodigoVenta = new SqlParameter("CodigoVenta", System.Data.SqlDbType.Int);
            SqlParameter pNombreCliente = new SqlParameter("NombreCliente", System.Data.SqlDbType.VarChar);
            SqlParameter pFechaCompra = new SqlParameter("FechaCompra", System.Data.SqlDbType.DateTime);
            SqlParameter pCantSillones = new SqlParameter("CantSillones", System.Data.SqlDbType.Int);
            SqlParameter pTotal = new SqlParameter("Total", System.Data.SqlDbType.Int);
            pCodigoVenta.Value = CodigoVenta;
            pNombreCliente.Value = NombreCliente;
            pFechaCompra.Value = FechaCompra;
            pCantSillones.Value = CantSillones;
            pTotal.Value = Total;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(pCodigoVenta);
                cmd.Parameters.Add(pNombreCliente);
                cmd.Parameters.Add(pFechaCompra);
                cmd.Parameters.Add(pCantSillones);
                cmd.Parameters.Add(pTotal);
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int eliminarVenta(int CodigoVenta)
        {
            int resultado = 0;
            string instruccion = "DELETE FROM [dbo].[PuntoVen] WHERE [CodigoVenta]=@CodigoVenta;";
            SqlParameter pCCodigoVenta = new SqlParameter("CodigoVenta", System.Data.SqlDbType.Int);
            pCCodigoVenta.Value = CodigoVenta;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(pCCodigoVenta);
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public int eliminarSala(int CodigoSala)
        {
            int resultado = 0;
            string instruccion = "DELETE FROM [dbo].[Muebles] WHERE [CodigoSala]=@CodigoSala;";
            SqlParameter pCodigoSala = new SqlParameter("CodigoSala", System.Data.SqlDbType.Int);
            pCodigoSala.Value = CodigoSala;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(pCodigoSala);
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public SqlDataReader buscarVenta(int CodigoVenta)
        {
            SqlDataReader dr;
            string instruccion = "SELECT [CodigoVenta],[NombreCliente],[FechaCompra],[CodSala],[CantSillones],[Total] FROM [dbo].[PuntoVen] WHERE [CodigoVenta]=@CodigoVenta;";
            SqlParameter PcCodigoVenta = new SqlParameter("CodigoVenta", System.Data.SqlDbType.Int);
            PcCodigoVenta.Value = CodigoVenta;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(PcCodigoVenta);
                dr = cmd.ExecuteReader();


            }
            catch (Exception)
            {

                throw;
            }

            return dr;
        }

        public SqlDataReader buscarVentaVentas(int CodSala)
        {
            SqlDataReader dr;
            string instruccion = "SELECT [CodigoVenta],[NombreCliente],[FechaCompra],[CodSala],[CantSillones],[Total] FROM [dbo].[PuntoVen] WHERE [CodSala]=@CodSala;";
            SqlParameter PcCodSala = new SqlParameter("CodSala", System.Data.SqlDbType.Int);
            PcCodSala.Value = CodSala;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(PcCodSala);
                dr = cmd.ExecuteReader();


            }
            catch (Exception)
            {

                throw;
            }

            return dr;
        }

        public SqlDataReader buscarSala(int CodigoSala)
        {
            SqlDataReader dr;
            string instruccion = "SELECT [CodigoSala],[NombreSala],[DescSala],[SalaMenor],[PrecioSillon] FROM [dbo].[Muebles] WHERE [CodigoSala]=@CodigoSala;";
            SqlParameter PcCodigoSala = new SqlParameter("CodigoSala", System.Data.SqlDbType.Int);
            PcCodigoSala.Value = CodigoSala;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(PcCodigoSala);
                dr = cmd.ExecuteReader();


            }
            catch (Exception)
            {

                throw;
            }

            return dr;
        }

        public int modificarSala(int CodigoSala, string NombreSala, String DescSala, bool SalaMenor, int PrecioSillon)
        {
            int resultado = 0;
            string instruccion = "UPDATE [dbo].[Muebles] SET [NombreSala] = @NombreSala,[DescSala] = @DescSala,[SalaMenor] = @SalaMenor,[PrecioSillon] = @PrecioSillon WHERE [CodigoSala] = @CodigoSala;";
            SqlParameter pCodigoSala = new SqlParameter("CodigoSala", System.Data.SqlDbType.Int);
            SqlParameter pNombreSala = new SqlParameter("NombreSala", System.Data.SqlDbType.VarChar);
            SqlParameter pDescSala = new SqlParameter("DescSala", System.Data.SqlDbType.VarChar);
            SqlParameter pSalaMenor = new SqlParameter("SalaMenor", System.Data.SqlDbType.Bit);
            SqlParameter pPrecioSillon = new SqlParameter("PrecioSillon", System.Data.SqlDbType.Int);
            pCodigoSala.Value = CodigoSala;
            pNombreSala.Value = NombreSala;
            pDescSala.Value = DescSala;
            pSalaMenor.Value = SalaMenor;
            pPrecioSillon.Value = PrecioSillon;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(pCodigoSala);
                cmd.Parameters.Add(pNombreSala);
                cmd.Parameters.Add(pDescSala);
                cmd.Parameters.Add(pSalaMenor);
                cmd.Parameters.Add(pPrecioSillon);
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public DataTable mostrarSalas()
        {
            DataTable t = new DataTable();
            string instruccion = "SELECT [CodigoSala],[NombreSala],[DescSala],[SalaMenor],[PrecioSillon] FROM [dbo].[Muebles];";

            try
            {
                conectarBD();
                SqlDataAdapter da = new SqlDataAdapter(instruccion, conexion);
                da.Fill(t);

            }
            catch (Exception)
            {

                throw;
            }

            return t;
        }

        public DataTable mostrarSalasMenores()
        {
            DataTable t = new DataTable();
            string instruccion = "SELECT [CodigoSala],[NombreSala],[DescSala],[SalaMenor],[PrecioSillon] FROM [dbo].[Muebles] WHERE [SalaMenor] = '1';";

            try
            {
                conectarBD();
                SqlDataAdapter da = new SqlDataAdapter(instruccion, conexion);
                da.Fill(t);

            }
            catch (Exception)
            {

                throw;
            }

            return t;
        }

        public DataTable mostrarSalasMayores()
        {
            DataTable t = new DataTable();
            string instruccion = "SELECT [CodigoSala],[NombreSala],[DescSala],[SalaMenor],[PrecioSillon] FROM [dbo].[Muebles] WHERE [SalaMenor] = '0';";

            try
            {
                conectarBD();
                SqlDataAdapter da = new SqlDataAdapter(instruccion, conexion);
                da.Fill(t);

            }
            catch (Exception)
            {

                throw;
            }

            return t;
        }

        public int agregarMuebles(int CodigoSala, string NombreSala, String DescSala, bool SalaMenor, int PrecioSillon)
        {
            int resultado = 0;
            string instruccion = "INSERT INTO [dbo].[Muebles] ([CodigoSala],[NombreSala],[DescSala],[SalaMenor],[PrecioSillon]) VALUES (@CodigoSala,@NombreSala,@DescSala,@SalaMenor,@PrecioSillon);";
            SqlParameter pCodigoSala = new SqlParameter("CodigoSala", System.Data.SqlDbType.Int);
            SqlParameter pNombreSala = new SqlParameter("NombreSala", System.Data.SqlDbType.VarChar);
            SqlParameter pDescSala = new SqlParameter("DescSala", System.Data.SqlDbType.VarChar);
            SqlParameter pSalaMenor = new SqlParameter("SalaMenor", System.Data.SqlDbType.Bit);
            SqlParameter pPrecioSillon = new SqlParameter("PrecioSillon", System.Data.SqlDbType.Int);
            pCodigoSala.Value = CodigoSala;
            pNombreSala.Value = NombreSala;
            pDescSala.Value = DescSala;
            pSalaMenor.Value = SalaMenor;
            pPrecioSillon.Value = PrecioSillon;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(pCodigoSala);
                cmd.Parameters.Add(pNombreSala);
                cmd.Parameters.Add(pDescSala);
                cmd.Parameters.Add(pSalaMenor);
                cmd.Parameters.Add(pPrecioSillon);
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }

        public DataTable mostrarVentas()
        {
            DataTable t = new DataTable();
            string instruccion = "SELECT * FROM [dbo].[PuntoVen];";

            try
            {
                conectarBD();
                SqlDataAdapter da = new SqlDataAdapter(instruccion, conexion);
                da.Fill(t);

            }
            catch (Exception)
            {

                throw;
            }

            return t;
        }





        //WEB
        public int ValidarCliente(int idCliente)
        {
            int resultado = 0;
            string instruccion = "select * from clientes where WHERE idCliente =@idCliente ;";
            SqlParameter PidCliente = new SqlParameter("idCliente", System.Data.SqlDbType.Int);
            PidCliente.Value = idCliente;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(PidCliente);
                resultado = cmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }
        public SqlDataReader buscarCliente(int idCliente)
        {
            SqlDataReader dr;
            string instruccion = "select * from clientes where WHERE idCliente =@idCliente ;";
            SqlParameter PidCliente = new SqlParameter("idCliente", System.Data.SqlDbType.Int);
            PidCliente.Value = idCliente;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(PidCliente);
                dr = cmd.ExecuteReader();


            }
            catch (Exception)
            {

                throw;
            }

            return dr;

        }
        public int agregarVenta(int idCliente, string sala, int enganche)
        {
            int resultado = 0;
            string instruccion = "INSERT INTO [dbo].[Ventas] ([idCliente],[sala],[enganche])VALUES(@idCliente,@sala, @enganche);";
            SqlParameter pidCliente = new SqlParameter("idCliente", System.Data.SqlDbType.Int);
            SqlParameter psala = new SqlParameter("sala", System.Data.SqlDbType.VarChar);
            SqlParameter penganche = new SqlParameter("enganche", System.Data.SqlDbType.Int);
            pidCliente.Value = idCliente;
            psala.Value = sala;
            penganche.Value = enganche;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(pidCliente);
                cmd.Parameters.Add(psala);
                cmd.Parameters.Add(penganche);
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }
        public SqlDataAdapter mostrarClientes()
        {
            DataTable t = new DataTable();
            //DataSet ds = new DataSet();
            string instruccion = "SELECT * FROM [dbo].[Clientes];";
            SqlDataAdapter da;
            try
            {
                conectarBD();
                da = new SqlDataAdapter(instruccion, conexion);
                //DataSet ds = new DataSet();
                da.Fill(t);
            }
            catch (Exception)
            {
                throw;
            }

           return da;
        }
        public SqlDataReader mostrarClientesFiltro(int idCliente)
        {
            SqlDataReader dr;
            string instruccion = "SELECT * FROM [dbo].[Clientes] WHERE [idCliente]=@idCliente;";
            SqlParameter PidCliente = new SqlParameter("idCliente", System.Data.SqlDbType.Int);
            PidCliente.Value = idCliente;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(PidCliente);
                dr = cmd.ExecuteReader();


            }
            catch (Exception)
            {

                throw;
            }

            return dr;
        }
        public int agregarCliente(int idCliente, string Nombre, string Telefono)
        {
            int resultado = 0;
            string instruccion = "INSERT INTO [dbo].[Clientes] ([idCliente],[Nombre],[Telefono])VALUES(@idCliente,@Nombre,@Telefono);";
            SqlParameter pidCliente = new SqlParameter("idCliente", System.Data.SqlDbType.Int);
            SqlParameter pNombre = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar);
            SqlParameter pTelefono = new SqlParameter("Telefono", System.Data.SqlDbType.VarChar);
            pidCliente.Value = idCliente;
            pNombre.Value = Nombre;
            pTelefono.Value = Telefono;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(pidCliente);
                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pTelefono);
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }
        public int modificarCliente(int idCliente, string Nombre, string Telefono)
        {
            int resultado = 0;
            string instruccion = "UPDATE [dbo].[Clientes] SET [Nombre] =@Nombre,[Telefono] =@Telefono  WHERE [idCliente] =@idCliente;";
            SqlParameter pidCliente = new SqlParameter("idCliente", System.Data.SqlDbType.Int);
            SqlParameter pNombre = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar);
            SqlParameter pTelefono = new SqlParameter("Telefono", System.Data.SqlDbType.VarChar);
            pidCliente.Value = idCliente;
            pNombre.Value = Nombre;
            pTelefono.Value = Telefono;
            try
            {
                conectarBD();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandText = instruccion;
                cmd.Parameters.Add(pidCliente);
                cmd.Parameters.Add(pNombre);
                cmd.Parameters.Add(pTelefono);
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;
        }


    }
}