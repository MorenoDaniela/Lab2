using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public static class Metodo_de_Extencion
    {
        /// <summary>
        /// Metodo de extencion para la clasa fruta Gaurdara archivo en archivo de texto como asi tambien serializa el elemento de forma XML y Binaria.
        /// Los 3 archivos son guardados en el escritorio de la máquina actual, con los nombres datos.txt, datos.xml y datos.bin
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="encoding"></param>
        /// <returns>devuelve los datos del objeto y guardar dicha información en un archivo de texto.</returns>
        public static string GuardarElemento(this object objeto, Encoding encoding)
        {
            try
            {


                StreamWriter SW = new StreamWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "datos.txt"), true);

                SW.WriteLine(objeto.ToString());

                SW.Flush();
                SW.Close();
                


                XmlTextWriter writer = new XmlTextWriter((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "datos.xml"), encoding);
                
                XmlSerializer ser = new XmlSerializer(typeof(string));

                ser.Serialize(writer, objeto.ToString());

                writer.Close();



                FileStream fs = new FileStream((Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + "datos.bin"), FileMode.Create);

                BinaryFormatter serB = new BinaryFormatter(); 

                ser.Serialize(fs, objeto.ToString());

                fs.Close();



                return objeto.ToString();

            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
