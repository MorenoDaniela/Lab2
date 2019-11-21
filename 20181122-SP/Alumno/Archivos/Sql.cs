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
    public class Sql : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {

        }

        public void Guardar (string tabla, Queue<Patente> datos)
        {
            conexion = new SqlConnection(tabla);
            //comando = new SqlCommand();
            conexion.Open();
            StringBuilder cadena = new StringBuilder();
            
            foreach (Patente pat in datos)
            {
                cadena.AppendFormat("INSERT INTO patentes-sp-2018 (patente, tipo) VALUES ({0} {1})", pat.CodigoPatente, pat.TipoCodigo);
                comando = new SqlCommand(cadena.ToString(), conexion);
            }

            
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {

            conexion = new SqlConnection(tabla);
            //using (conexion = new SqlConnection(tabla))
            //{
                datos = new Queue<Patente>();
                string coman = "SELECT * FROM Patentes";
                comando = new SqlCommand(coman, conexion);
                conexion.Open();
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    
                    string patente = dataReader.GetString(0);
                    string tipo = dataReader.GetString(1);

                    Patente pat = PatenteStringExtension.ValidarPatente(patente);

                    datos.Enqueue(pat);

                }
            conexion.Close();
            //}

        }
    }
}
