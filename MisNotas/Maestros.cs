using System.Data;
using System.Data.SqlClient;

namespace MisNotas
{
    internal class Maestros
    {
        private int tipo;
        private string nombre = "";
        private int id;
        private string mensajeDeError = "";
        private bool visible;
        private string codigo;
        private bool incluirEnListados;
        private int categoriaId;
        private ConexionBd cx = new ConexionBd();

        public int Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public int CategoriaId { get => categoriaId; set => categoriaId = value; }
        public string MensajeDeError { get => mensajeDeError; set => mensajeDeError = value; }
        public bool Visible { get => visible; set => visible = value; }

        public bool IncluirEnListados { get => incluirEnListados; set => incluirEnListados = value; }
        public string Codigo { get => codigo; set => codigo = value; }

        SqlCommand sp = new SqlCommand();



        public bool ValidarDatos()
        {
            if (tipo != 6)
            {
                if (nombre == "" || codigo == "")
                    return false;
            }


            return true;
        }
        public void CrearMaestro()
        {
            try
            {
                if (!ValidarDatos())
                {
                    mensajeDeError = "Datos no validos";


                }
                else
                {

                    sp.Connection = cx.AbrirConexionBd();
                    sp.CommandText = "CreacionDeMaestros";
                    sp.CommandType = CommandType.StoredProcedure;
                    sp.Parameters.AddWithValue("@Tipo", tipo);
                    sp.Parameters.AddWithValue("@Nombre", nombre);
                    sp.Parameters.AddWithValue("@Codigo", codigo);
                    sp.Parameters.AddWithValue("@Visible", visible);
                    sp.Parameters.AddWithValue("@IncluirEnListados", incluirEnListados);
                    sp.Parameters.AddWithValue("@CategoriaId", categoriaId);
                    sp.ExecuteNonQuery();
                    sp.Parameters.Clear();
                    sp.Connection = cx.CerrarConexionBd();

                }


            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

        public DataTable ListarMaestros()
        {
            if (tipo == 6)
                tipo = 13;

            SqlDataAdapter da = new SqlDataAdapter("listados", cx.AbrirConexionBd());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
            da.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cx.CerrarConexionBd();
            return dt;
        }

    }
}
