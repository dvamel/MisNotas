using System.Xml;

namespace MisNotas
{
    public class ReadXML
    {
        //https://decodigo.com/c-sharp-leer-archivo-xml

        XmlDocument documento = new XmlDocument();
        private string carpeta = Environment.CurrentDirectory + @"\Resources\Configuracion.xml";
        private string cadenaDeConexion="";
        private string carpetaDeAdjuntosTemporal="";

        public string CadenaDeConexion { get => cadenaDeConexion; set => cadenaDeConexion = value; }
        public string CarpetaDeAdjuntosTemporal { get => carpetaDeAdjuntosTemporal; set => carpetaDeAdjuntosTemporal = value; }


        public ReadXML()
        {
            XmlTextReader reader = new XmlTextReader(carpeta);

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element && reader.Name == "servidor")
                    cadenaDeConexion = reader.GetAttribute("conexion");

                else if (reader.NodeType == XmlNodeType.Element && reader.Name == "rutas")
                    carpetaDeAdjuntosTemporal = reader.GetAttribute("carpetadeadjuntostemporal");





            }
        }
    }
}
