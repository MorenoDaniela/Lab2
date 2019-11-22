using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IFiles<T>
    {
        public string GetDirectoryPath
        {
            get
            {
                return "agregar direct";
            }
        }

        public bool FileExists(string nombreArchivo)
        {
            bool retorno = false;
            StringBuilder cadena = new StringBuilder();
            cadena.Append(GetDirectoryPath);
            if (File.Exists(nombreArchivo))
            {
                cadena.Append(nombreArchivo);
                retorno = true;
            }
            return retorno; ;
        }

        public void Guardar (string nombreArchivo, T objeto)
        {
            XmlTextWriter writer = null;
            try
            {
                writer = new XmlTextWriter(nombreArchivo, Encoding.UTF8);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, objeto);
                
                
            }
            catch (Exception innerException)
            {
                throw new ErrorArchivosException("Error en archivos",innerException);
            }
            finally
            {
                writer.Close();
            }
        }

        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            this.Guardar(nombreArchivo, objeto);
        }

        public bool Leer(string nombreArchivo, out T objeto)
        {
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(nombreArchivo);
                XmlSerializer ser = new XmlSerializer(typeof(T));
                objeto = (T)ser.Deserialize(reader);
                return true;
            }
            catch (Exception innerException)
            {
                throw new ErrorArchivosException("Error en archivos",innerException);
            }
            finally
            {
                reader.Close();
            }
        }


        public bool Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            return this.Leer(nombreArchivo, out objeto, Encoding.UTF8);
        }
    }
}
