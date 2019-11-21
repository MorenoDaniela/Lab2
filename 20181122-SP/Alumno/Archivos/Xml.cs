using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml <T>: IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            //try
            //{
                XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, datos);
                writer.Close();
                //return true;
            //}
            //catch (Exception innerException)
            //{
              //  throw new ArchivosException(innerException);
            //}
        }
        public void Leer(string archivo, out T datos)
        {
            
            datos = default(T);
            XmlTextReader reader = new XmlTextReader(archivo);
            XmlSerializer ser = new XmlSerializer(typeof(T));
            
            datos = (T)ser.Deserialize(reader);
            reader.Close();
            /*
            bool flag = false;
            datos = default(T);
            XmlSerializer ser = new XmlSerializer(typeof(T));
            StreamReader sr = new StreamReader(archivo);
            try
            {
                datos = (T)ser.Deserialize(sr);
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }
            finally
            {
                if (flag)
                    sr.Close();
            }*/
        }
    }
}
