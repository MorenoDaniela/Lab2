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
            conexion.Open();
            StringBuilder cadena = new StringBuilder();
            foreach (Patente pat in datos)//datos deberia tener una propiedad para acceder a la lista
            {
                //cadena.AppendFormat("INSERT INTO Votaciones(nombreLey,afirmativos,negativos,abstenciones,nombreAlumno) VALUES('{0}',{1},{2},{3},'DanielaMoreno')", datos.NombreLey, datos.Afirmativo, datos.Negativo, datos.Abstencion);
                //aca fijarse pat. algo
            }

            comando = new SqlCommand(cadena.ToString(), conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            /*
             *  public static List<Cliente> LeerClientes()
            {
                using (SqlConnection connection = new SqlConnection(DAO.connectionString))
                {
                    string comando = "SELECT id, nombre, apellido, dni, fecha_nacimiento FROM CLIENTES;";
                    SqlCommand command = new SqlCommand(comando, connection);
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    List<Cliente> clientes = new List<Cliente>();

                    while (dataReader.Read())
                    {
                        int id = dataReader.GetInt32(0);
                        string nombre = dataReader.GetString(1);
                        string apellido = dataReader.GetString(2);
                        string dni = dataReader.GetString(3);
                        DateTime? fechaNacimiento = null;
                        if (!dataReader.IsDBNull(4))
                        {
                            fechaNacimiento = dataReader.GetDateTime(4);
                        }

                        Cliente cliente = new Cliente(id, nombre, apellido, dni, fechaNacimiento);
                        clientes.Add(cliente);
                    }
                    return clientes;
                }                
            }
            */
            datos = null;
        }


    }
}
