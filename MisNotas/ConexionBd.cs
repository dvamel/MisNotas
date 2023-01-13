using System.Data;
using System.Data.SqlClient;

namespace MisNotas
{
    internal class ConexionBd
    {
       
        private SqlConnection cn;
        ReadXML xml = new ReadXML();

        public ConexionBd()
        {
            cn = new SqlConnection(xml.CadenaDeConexion);
        }
        
        public SqlConnection AbrirConexionBd()
        {

            try
            {
                if(cn.State == ConnectionState.Closed)
                   cn.Open();

                return cn;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public SqlConnection CerrarConexionBd()
        {
            
            try
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();

                return cn;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }




    }
}
