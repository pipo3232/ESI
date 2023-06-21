using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Models
{
    class alumn
    {
        public int id_alumno { set; get; }
        public string nombre_alumno { set; get; }

        private string apellido_alumno1;

        public string Getapellido_alumno()
        {
            return apellido_alumno1;
        }

        public void Setapellido_alumno(string value)
        {
            apellido_alumno1 = value;
        }

        public string email_alumno { set; get; }
        public string telefono { set; get; }

        internal apellido_alumno Email_alumno
        {
            get
            {
                return this.Email_alumno;
            }
        }

        internal nombre_alumno Apellido_alumno => this.Apellido_alumno;

        internal apellido_alumno Email_alumno1 { get => this.Email_alumno; set => this.email_alumno = value; }

        internal nombre_alumno Apellido_alumno1 => this.Apellido_alumno;

        public alumn(int id, string nombre_alumno, string apellido_alumno, string email_alumno, string telefono)
        {
            nombre_alumno = nombre_alumno;
            apellido_alumno = apellido_alumno;
            email_alumno = email_alumno;
            telefono = telefono;
    }
        public class apellido_alumno
        {
            public apellido_alumno()
            {
            }

            public static implicit operator string(apellido_alumno v)
            {
                throw new NotImplementedException();
            }

            private string GetDebuggerDisplay()
            {
                return ToString();
            }
        }

        public alumn(string nombre_alumno, string apellido_alumno, string email_alumno, string telefono) { }



}
}
