using System;

namespace ConexionSQL
{
    class Program
        {
            static void Main(string[] args)
            {
                // Cadena de conexión al servidor SQL
                string connectionString = "Data Source=PC17/SQLEXPRESS;Initial Catalog=Escuela;User ID=NombreUsuario;Password=Contraseña";

                // Crear una nueva conexión
                SqlConnection connection = new SqlConnection(connectionString);

                try
                {
                    // Abrir la conexión
                    connection.Open();
                    Console.WriteLine("Conexión establecida con éxito.");

                    // Aquí puedes realizar operaciones en la base de datos

                    // Cerrar la conexión
                    connection.Close();
                    Console.WriteLine("Conexión cerrada.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al establecer la conexión: " + ex.Message);
                }

                Console.ReadLine();
            }
        }
    }


