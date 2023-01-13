using System.Data;
using System.Data.SqlClient;

namespace MisNotas
{
    internal class CrearPendientes
    {

        private ConexionBd cx = new ConexionBd();
        SqlCommand sp = new SqlCommand();

        private int id;
        private string nombre = "";
        private DateTime fecha;
        private DateTime fechaDeEntrega;
        private DateTime horaDeEntrega;
        private string observaciones = "";
        private int estadoId;
        private int tipoId;
        private string mensajeDeError = "";
        private int tipo;
        private string color;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime FechaDeEntrega { get => fechaDeEntrega; set => fechaDeEntrega = value; }

        public DateTime HoraDeEntrega { get => horaDeEntrega; set => horaDeEntrega = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int EstadoId { get => estadoId; set => estadoId = value; }
        public int TipoId { get => tipoId; set => tipoId = value; }

         public string MensajeDeError { get => mensajeDeError; set => mensajeDeError = value; }

        public int Tipo { get => tipo; set => tipo = value; }

        public string Color { get => color; set => color = value; }



        public bool ValidarDatos()
        {
            if (nombre == "" ||  TipoId < 1 || observaciones == "" )
                return false;

            return true;
        }


        public void IngresarPendientes()
        {
            try
            {
                if (!ValidarDatos())
                {
                    mensajeDeError = "Datos no validos";
                    

                }
                else
                {

                    
                    SqlCommand sp = new SqlCommand("CreacionDePendientes", cx.AbrirConexionBd());
                   
   
                    sp.CommandType = CommandType.StoredProcedure;
                    sp.Parameters.AddWithValue("@Nombre", nombre);
                    sp.Parameters.AddWithValue("@EstadoId", estadoId);
                    sp.Parameters.AddWithValue("@Fecha", fecha);
                    sp.Parameters.AddWithValue("@FechaEntrega", fechaDeEntrega);
                    sp.Parameters.AddWithValue("@HoraDeEntrega", horaDeEntrega);
                    sp.Parameters.AddWithValue("@Observaciones", observaciones);
                    sp.Parameters.AddWithValue("@TipoDePendienteId", tipoId);
                    sp.Parameters.AddWithValue("@Id", id);
                    SqlDataReader dt = sp.ExecuteReader();
                    if (dt.Read())
                    {

                        id = Int16.Parse(dt["Id"].ToString());

                    }
                    sp.Parameters.Clear();
                    sp.Connection = cx.CerrarConexionBd();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public DataSet ConsultarListadoPendiente()
        {
          

                SqlDataAdapter da = new SqlDataAdapter("listados", cx.AbrirConexionBd());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
                da.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);
                DataSet dt = new  DataSet ();
                da.Fill(dt);
                cx.CerrarConexionBd();
                return dt;

            

        }

        public void ConsultarPendientePorId()
        {


            SqlCommand da = new SqlCommand("listados", cx.AbrirConexionBd());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@Tipo", tipo);
            da.Parameters.AddWithValue("@Id ", id);
            SqlDataReader dt = da.ExecuteReader();

            if (dt.Read())
            {
                     nombre = dt["Nombre"].ToString();
                     fechaDeEntrega = DateTime.Parse(dt["FechaEntrega"].ToString());
                     horaDeEntrega = DateTime.Parse(dt["HoraDeEntrega"].ToString());
                     observaciones = dt["Observaciones"].ToString();
                     estadoId=Int16.Parse(dt["EstadoId"].ToString());
                     tipoId=Int16.Parse(dt["TipoDePendienteId"].ToString());
            }

          
            cx.CerrarConexionBd();
             



        }
    }
}
