using System.Data;
using System.Data.SqlClient;

namespace MisNotas
{
    internal class Personas
    {
        private ConexionBd cx = new ConexionBd();
        SqlCommand sp = new SqlCommand();


        private int id;
        private int tipo;
        private int tipoId;
        private int estadoId;
        private string nombre = "";
        private string observaciones = "";
        private string nombreUsuario = "";
        private string password = "";
        private bool activo;
        private string correo = "";
        private string detalleTecnico = "";
        private string aplicaciones = "";
        private string contactos = "";
        private string mensajeDeError = "";

       
        public int Id { get => id; set => id = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public int TipoId { get => tipoId; set => tipoId = value; }
        public int EstadoId { get => estadoId; set => estadoId = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public bool Activo { get => activo; set => activo = value; }
        public string Correo { get => correo; set => correo = value; }
        public string DetalleTecnico { get => detalleTecnico; set => detalleTecnico = value; }
        public string Aplicaciones { get => aplicaciones; set => aplicaciones = value; }
        public string Contactos { get => contactos; set => contactos = value; }
        public string MensajeDeError { get => mensajeDeError; set => mensajeDeError = value; }

        public bool ValidarDatos()
        {
            if (nombre != "" || nombre.Count() < 50)
                return true;

            else if (tipoId > 0 )
                return true;

            else if (estadoId > 0)
                return true;

            else if (observaciones.Count() <  1000)
                return true;
            else if (nombreUsuario.Count() < 20)
                return true;

            else if (correo.Count() < 200)
                return true;

            return false;
        }
        public void CrearMaestro()
        {
            try
            {
                if (ValidarDatos())
                {

                    sp.Connection = cx.AbrirConexionBd();
                    sp.CommandText = "CreacionDePersonas";
                    sp.CommandType = CommandType.StoredProcedure;
                    sp.Parameters.AddWithValue("@Tipo", tipo);
                    sp.Parameters.AddWithValue("@TipoId", tipoId);
                    sp.Parameters.AddWithValue("@EstadoId", estadoId);
                    sp.Parameters.AddWithValue("@Nombre", nombre);
                    sp.Parameters.AddWithValue("@Observaciones", observaciones);
                    sp.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                    sp.Parameters.AddWithValue("@Password", password);
                    sp.Parameters.AddWithValue("@Activo", activo);
                    sp.Parameters.AddWithValue("@Correo", correo);
                    sp.Parameters.AddWithValue("@DetalleTecnico", detalleTecnico);
                    sp.Parameters.AddWithValue("@Aplicaciones", aplicaciones);
                    sp.Parameters.AddWithValue("@Contactos", contactos);

                    sp.ExecuteNonQuery();
                    sp.Parameters.Clear();
                    sp.Connection = cx.CerrarConexionBd();

                }
                else
                {

                    mensajeDeError = "Datos no validos";
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public void ConsultarPersonaPorId()
        {

            
            SqlCommand da = new SqlCommand("listados", cx.AbrirConexionBd());
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@Tipo", tipo);
            da.Parameters.AddWithValue("@Id ", id);
            SqlDataReader dt = da.ExecuteReader();

            if (dt.Read())
            {
                tipoId = Int16.Parse(dt["TipoId"].ToString());
                estadoId = Int16.Parse(dt["EstadoId"].ToString());
                nombre = dt["Nombre"].ToString();
                observaciones = dt["Observaciones"].ToString();
                nombreUsuario = dt["NombreUsuario"].ToString(); 
                password = dt["Password"].ToString();
                activo = Boolean.Parse(dt["Activo"].ToString());
                correo  = dt["Correo"].ToString();
                detalleTecnico = dt["DetalleTecnico"].ToString();
                aplicaciones = dt["Aplicaciones"].ToString();
                contactos = dt["Contactos"].ToString();

               
            }


            cx.CerrarConexionBd();




        }

    }
}

