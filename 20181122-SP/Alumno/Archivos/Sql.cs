using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
    public class Sql : IArchivo<T>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {

        }

        public void Guardar (string tabla, out Queue<Patente> datos)
        {

        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {

        }


    }
}
