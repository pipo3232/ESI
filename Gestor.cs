using System;
using System.Collections.Generic;

namespace Escuela.Models
{
    class GestorAlumno
    {
        private string configuration;
        private clsAlumno alumno_add;
        private ConexionSQL conn;

        public List<clsAlumno> GetclsAlumno
        {
            get
            {
                List<clsAlumno> lista = List<clsAlumno>();
                string strconn = configurationManager.Connect("BDlocal").ToString();
                new Conexionsql(strconn) ;
                {
                    conn.Open();
                    sqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Alumno_all";
                    cmd.commandType = commandType.StoreProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr. Open()) 
                    {
                        int id = dr.GetInt32(0);
                        string nombre_alumno = (string)dr.GetString(1);

                        string apellido_alumno = (string)dr.GetString(2);

                        string email_alumno = (string)dr.GetString(3);
                        string telefono = (string)dr.GetString(4);



                        Alumno alumno = new alumn(id, nombre_alumno, apellido_alumno, email_alumno, telefono);
                        lista.Add(alumno_add);
                    }
                    dr.Close();
                    conn.Close();

                }
                return lista;

            }
        }

        private List<T> List<T>()
        {
            throw new NotImplementedException();
        }

        public bool Alumnos_add
        {
            set
            {
                bool res = false;
                string strconn = configurationManager.Connect("BDlocal").ToString();
                new  Conexionsql(strconn);
                {
                    sqlCommand cmd = conn.CreateCommand();
                    sqlDataAdapter adapter = new sqlDataAdapter(cmd);
                    cmd.CommandText = "alumno_add";
                    cmd.commandType = commandType.StoreProcedure;

                    object alumno = cmd.CommandText = "@nombre_alumno Models.alumno.nombre_alumno";
                    object alumn = cmd.CommandText ="@apellido_alumno alumno.apellido_alumno";
                    object lumno = cmd.CommandText = "@email_alumno alumno.email_alumno";
                    cmd.CommandText = "@telefono alumno.telefono";


                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        res = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        res = false;
                        throw;
                    }
                    finally
                    {
                        object Clese = cmd.parameters.GetHashCode();
                        conn.Close();
                    }
                    return ;
                    {
                        

                    }
                }
            }
        }

        public object Set { get; private set; }

        private object Alumnos_update(int id, clsAlumno alumn)
        // La función local se declara pero nunca se usa
        {
            object set = Set;
            {
                bool res = false;
                string strconn = configurationManager.Connect("BDlocal").ToString();
                new Conexionsql(strconn);
                {
                    sqlCommand cmd = conn.CreateCommand();
                    sqlDataAdapter adapter = new sqlDataAdapter(cmd);
                    cmd.CommandText = "alumno_add";
                    cmd.commandType = commandType.StoreProcedure;

                    cmd.CommandText ="@id id";
                    cmd.CommandText = "@nombre_alumno alumn.nombre_alumno";
                    cmd.CommandText ="@apellido_alumno alumn.apellido_alumn";
                    cmd.CommandText = "@email_alumno alumn.email_alumno";
                    cmd.CommandText = "@telefono alumn.telefono";

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        res = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        res = false;
                        throw;
                    }
                    finally
                    {
                        object Clear = cmd.parameters.GetHashCode();
                        conn.Close();
                    }
                    return res;


                }
            }
        }

        private object Alumnos_Delete( int id, clsAlumno alumn)
        // La función local se declara pero nunca se usa
        {
            object set = Set;
            {
                bool res = false;
                string strconn = configurationManager.Connect("BDlocal").ToString();
                new Conexionsql(strconn) ;
                {
                    sqlCommand cmd = conn.CreateCommand();
                    sqlDataAdapter adapter = new sqlDataAdapter(cmd);
                    cmd.CommandText = " Alumnos_Delete";
                    cmd.commandType = commandType.StoreProcedure;

                    cmd.CommandText = "@id id";


                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        res = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        res = false;
                        throw;
                    }
                    finally
                    {
                        object Clear = cmd.parameters.GetHashCode();
                        conn.Close();
                    }
                    return res;
                    

                }
            }





        }

        private static object Conexionsql(string strconn)
        {
            throw new NotImplementedException();
        }


        internal class commandType
        {
            public static object StoreProcedure { get; internal set; }
        }

    }
}
        

