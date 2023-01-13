using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisNotas
{
    internal class ComboBox
    {
        private ConexionBd cx = new ConexionBd();
        private int tipo;
        private string nombre = "";
        private int id;

        public int Tipo { get => tipo; set => tipo = value; }
        public string Nombre { get => nombre; set => nombre = value; }

         public int Id { get => id; set => id = value; }

        public DataTable CargarCombo(string procedure)
        {

            SqlDataAdapter da = new SqlDataAdapter(procedure,cx.AbrirConexionBd());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
            da.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);
            da.SelectCommand.Parameters.AddWithValue("@Id", id);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cx.CerrarConexionBd();
            return dt;

        }

        public DataTable CargarAutoCompletar(string procedure)
        {

            SqlDataAdapter da = new SqlDataAdapter(procedure, cx.AbrirConexionBd());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
            da.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);
            da.SelectCommand.Parameters.AddWithValue("@Id", id);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cx.CerrarConexionBd();
            return dt;

        }

        public DataSet CargarAutoCompletarResultadoGeneral(string procedure)
        {

            SqlDataAdapter da = new SqlDataAdapter(procedure, cx.AbrirConexionBd());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Tipo", tipo);
            da.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);
            da.SelectCommand.Parameters.AddWithValue("@Id", id);
            DataSet dt = new DataSet();
            da.Fill(dt);
            cx.CerrarConexionBd();
            return dt;

        }

    }
}
