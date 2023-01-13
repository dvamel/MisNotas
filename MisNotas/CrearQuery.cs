using System.Data;
using System.Data.SqlClient;

namespace MisNotas
{
    internal class CrearQuery
    {
        private ConexionBd cx = new ConexionBd();
        SqlCommand sp = new SqlCommand();

        private int id;
        private string nombre = "";
        private string detalleTecnico;
        private string aplicaciones;
        private string observaciones = "";
        private int estadoId;
        private int tipoId;
        private string mensajeDeError = "";
        private int tipo;
        private int personaId;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string DetalleTecnico { get => detalleTecnico; set => detalleTecnico = value; }
        public string Aplicaciones { get => aplicaciones; set => aplicaciones = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int EstadoId { get => estadoId; set => estadoId = value; }
        public int TipoId { get => tipoId; set => tipoId = value; }
        public string MensajeDeError { get => mensajeDeError; set => mensajeDeError = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int PersonaId { get => personaId; set => personaId = value; }


        public bool ValidarDatos()
        {
            if (nombre == "" || TipoId < 1 || observaciones == "")
                return false;

            return true;
        }
        public void IngresarQuery()
        {
            try
            {
                if (!ValidarDatos())
                {
                    mensajeDeError = "Datos no validos";


                }
                else
                {


                    SqlCommand sp = new SqlCommand("CreacionDeQuerys", cx.AbrirConexionBd());


                    sp.CommandType = CommandType.StoredProcedure;
                    sp.Parameters.AddWithValue("@Nombre", nombre);
                    sp.Parameters.AddWithValue("@Observaciones", observaciones);
                    sp.Parameters.AddWithValue("@PersonaCreadoraId", personaId);
                    sp.Parameters.AddWithValue("@EstadoId", estadoId);
                    sp.Parameters.AddWithValue("@DetalleTecnico", detalleTecnico);
                    sp.Parameters.AddWithValue("@Aplicaciones", aplicaciones);
                    sp.Parameters.AddWithValue("@TipoDeQueryId", tipoId);
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


        public DataSet ConsultarListadoIngresarQuery()
        {


            SqlDataAdapter da = new SqlDataAdapter("listados", cx.AbrirConexionBd());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
            da.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);
            DataSet dt = new DataSet();
            da.Fill(dt);
            cx.CerrarConexionBd();
            return dt;



        }


        public void ConsultarQueryPorId()
        {


            SqlCommand da = new SqlCommand("listados", cx.AbrirConexionBd());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@Tipo", tipo);
            da.Parameters.AddWithValue("@Id ", id);
            SqlDataReader dt = da.ExecuteReader();

            if (dt.Read())
            {
                nombre = dt["Nombre"].ToString(); 
                observaciones = dt["Observaciones"].ToString();
                personaId = Int16.Parse(dt["PersonaCreadoraId"].ToString());
                estadoId = Int16.Parse(dt["EstadoId"].ToString());
                detalleTecnico = dt["DetalleTecnico"].ToString(); 
                aplicaciones = dt["Aplicaciones"].ToString(); 
                tipoId = Int16.Parse(dt["TipoDeQueryId"].ToString());
           
            }


            cx.CerrarConexionBd();




        }

    }
}
