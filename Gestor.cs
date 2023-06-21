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
                string strconn = configurationManager.ConnectString("BDlocal").ToString();
                using (ConexionSQL conn = new ConexionSQL(strconn))
                {
                    conn.Open();
                    sqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Alumno_all";
                    cmd.commandType = commandType.StoreProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();

                    while dr.Open())
                    {
                        int id = dr.GetInt32(0);
                        string nombre_alumno = (string)dr.GetString(1);
                                                 
                        string apellido_alumno = (string)dr.GetString(2);
                                                   
                        string email_alumno = (string)dr.GetString(3);
                        string telefono = (string)dr.GetString(4);
                                            


                        Alumno alumno = new Alumno(id, nombre_alumno, apellido_alumno, email_alumno, telefono);
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
                string strconn = configurationManager.ConnectString("BDlocal").ToString();
                using (conn = new sqlConexion(strconn));
                {
                    sqlCommand cmd = conn.CreateCommand();
                    sqlDataAdapter adapter = new sqlDataAdapter(cmd);
                    cmd.CommandText = "alumno_add";
                    cmd.commandType = commandType.StoreProcedure;

                    object  alumno = cmd.parameters.AddWithValues("@nombre_alumno", alumno.nombre_alumno);
                    object alumn = cmd.parameters.AddWithValues("@apellido_alumno", alumno.apellido_alumno);
                    cmd.parameters.AddWithValues("@email_alumno", alumno.email_alumno);
                    cmd.parameters.AddWithValues("@telefono", alumno.telefono);

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
                        object alumn = cmd.parameters.Clear();
                        conn.Close();
                    }
                    return res();

                }
            }
                    public bool Alumnos_update(int id, clsAlumno alumn)
        {
            set;
            {
                bool res = false;
                string strconn = configurationManager.ConnectString("BDlocal").ToString();
                using (conn = new sqlConexion(strconn));
                {
                    sqlCommand cmd = conn.CreateCommand();
                    sqlDataAdapter adapter = new sqlDataAdapter(cmd);
                    cmd.CommandText = "alumno_add";
                    cmd.commandType = commandType.StoreProcedure;

                    cmd.parameters.AddWithValues("@id", Alumno.id);
                    cmd.parameters.AddWithValues("@nombre_alumno", alumn.nombre_alumno);
                    cmd.parameters.AddWithValues("@apellido_alumno", alumn.apellido_alumn);
                    cmd.parameters.AddWithValues("@email_alumno", alumn.email_alumno);
                    cmd.parameters.AddWithValues("@telefono", alumn.telefono);

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
                        object alumno = cmd.parameters.Clear();
                        conn.Close();
                    }
                    return res;

                }
            }
        }
    }

    internal class commandType
    {
        public static object StoreProcedure { get; internal set; }
    }
}

        

