using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Biblioteca
{
    //[Serializable] 
    public class Persona
    {
        public string nombre;
        public string apellido;

        public Persona ()
        {

        }
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static void Guardar(Persona p)
        {
            #region binario serialice
            /*
            FileStream fs = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "prueba.txt", FileMode.Create);
            BinaryFormatter ser = new BinaryFormatter();
            ser.Serialize(fs, p);
            fs.Close();*/
            #endregion 
            XmlTextWriter writer = new XmlTextWriter(AppDomain.CurrentDomain.BaseDirectory + "prueba.xml", Encoding.UTF8);
            XmlSerializer ser = new  XmlSerializer(typeof(Persona));
            ser.Serialize(writer, p);
            writer.Close();
        }

        public static Persona Leer (string path)
        {
            Persona persona = null;
            XmlTextReader reader = new XmlTextReader(path);
            //Se indica el tipo de objeto ha serializar.
            XmlSerializer ser = new XmlSerializer(typeof(Persona));
            persona = (Persona)ser.Deserialize(reader);
            reader.Close();
            return persona;
        }

        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("\nNombre: {0} Apellido: {1} \n", this.nombre, this.apellido);
            return cadena.ToString();

        }
    }
}
