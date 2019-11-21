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

            using (StreamWriter str = new StreamWriter(archivo, File.Exists(archivo)))
            {
                foreach (Patente p in datos)
                {
                    str.WriteLine(p);
                }
               
            }
            
        }

        public void Leer(string archivo, out Queue<Patente> datos)
        {
            StreamReader sr = new StreamReader(archivo);
            datos = new Queue<Patente>();

            while (!sr.EndOfStream)
            {
                Patente patente = new Patente();
                PatenteStringExtension.ValidarPatente(sr.ReadLine());
                datos.Enqueue(patente);
            }

            sr.Close();
        }
    }
}
