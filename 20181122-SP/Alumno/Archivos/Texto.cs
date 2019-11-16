using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
    public class Texto : IArchivo<Queue<Patente>>
    {
        public void Guardar(string archivo, Queue <Patente> datos)
        {
            //try
            //{
                using (StreamWriter str = new StreamWriter(archivo, File.Exists(archivo)))
                {
                    str.WriteLine(datos);
                   // return true;
                }
            //}
            //catch (Exception innerException)
            //{
             //   throw new ArchivosException(innerException);
            //}
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            StreamReader sr = new StreamReader(archivo);
            datos = new Queue<Patente>();

            while (!sr.EndOfStream)
            {
                Patente patente = new Patente();
                patente.CodigoPatente = sr.ReadLine();
                datos.Enqueue(patente);
            }

            sr.Close();
        }
    }
}
