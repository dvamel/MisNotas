using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisNotas
{
    internal class CrearAdjuntos
    {
        private ConexionBd cx = new ConexionBd();
        SqlCommand sp = new SqlCommand();

        private int id;
        private string nombre = "";
        private DateTime fecha;
        private string observaciones = "";
        private int tipoId;
        private int tipo;
        private string ruta = "";
        private byte[] Documentos ;
        private string mensajeDeError = "";
        private int docuementoId;
        private int relacionId;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public int TipoId { get => tipoId; set => tipoId = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public byte[] Documento { get => Documentos; set => Documentos = value; }

        public string MensajeDeError { get => mensajeDeError; set => mensajeDeError = value; }

        public int DocuementoId { get => docuementoId; set => docuementoId = value; }

        public int RelacionId { get => relacionId; set => relacionId = value; }


        public void IngresarAdjuntos()
        {
            try
            {
                if (ValidarDatos())
                {

                    
                    SqlCommand da = new SqlCommand("CreacionDeAdjuntos", cx.AbrirConexionBd());
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.AddWithValue("@Nombre", nombre);
                    da.Parameters.AddWithValue("@Ruta", ruta);
                    da.Parameters.AddWithValue("@Fecha", fecha);
                    da.Parameters.AddWithValue("@Observaciones", observaciones);
                    da.Parameters.AddWithValue("@TipoDeAjuntoId", tipoId);
                    da.Parameters.AddWithValue("@Documento", Documentos);
                    SqlDataReader dt = da.ExecuteReader();
                    if (dt.Read())
                    {
                     
                        id = Int16.Parse(dt["Id"].ToString());
                      
                    }
                    da.Connection = cx.CerrarConexionBd();
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

        public bool ValidarDatos()
        {
            if (nombre != "" && nombre.Count() < 100 )
                return true;

            return false;
        }

        public DataSet ConsultarListadoAdjuntos()
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

        public DataTable ConsultarListadoAdjuntosEnTabla()
        {


            SqlDataAdapter da = new SqlDataAdapter("listados", cx.AbrirConexionBd());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
            da.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cx.CerrarConexionBd();
            return dt;



        }

        public DataSet ConsultarListadoAdjuntosEnTablaPorId()
        {


            SqlDataAdapter da = new SqlDataAdapter("listados", cx.AbrirConexionBd());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
            da.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);
            da.SelectCommand.Parameters.AddWithValue("@Id", id);
            DataSet dt = new DataSet();
            da.Fill(dt);
            cx.CerrarConexionBd();
            return dt;



        }

        public void IngresarRelacionAdjuntos()
        {
            try
            {
               

                    sp.Connection = cx.AbrirConexionBd();
                    sp.CommandText = "CreacionDeRelaciones";
                    sp.CommandType = CommandType.StoredProcedure;
                    sp.Parameters.AddWithValue("@Tipo", tipo);
                    sp.Parameters.AddWithValue("@DocumentoId", docuementoId);
                    sp.Parameters.AddWithValue("@RelacionId", relacionId);
                    sp.ExecuteNonQuery();
                    sp.Parameters.Clear();
                    sp.Connection = cx.CerrarConexionBd();

                

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }

}
