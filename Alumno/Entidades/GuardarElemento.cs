using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;

namespace Entidades
{
    public static class GuardarElemento
    {
        public static string Guardar(this Fruta fruta)
        {
            string archivoTxt = "datos.txt";
            string archivoXml = "datos.xml";
            string archivoBin = "datos.bin";
            XmlTextWriter writer = null;
            Stream stream = null;
            string aux = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


            try
            {
                using (StreamWriter str = new StreamWriter(aux + "\\" + archivoTxt, File.Exists(archivoTxt)))
                {
                    str.WriteLine(fruta.MostrarDatos());
                    
                }

                writer = new XmlTextWriter(archivoXml, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(Fruta));
                ser.Serialize(writer, fruta.MostrarDatos());//chequear si llamar a mostrardatos
                BinaryFormatter formatter = new BinaryFormatter();
                stream = new FileStream(archivoBin, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, fruta);//chequear si llamar a mostrardatos

                return fruta.MostrarDatos();
            }
            catch (Exception e)
            {
                throw new Exception("Error al guardar en alguno de los formatos", e);
            }
            finally
            {
                writer.Close();
                stream.Close();
            }

        }
        
    }
}
