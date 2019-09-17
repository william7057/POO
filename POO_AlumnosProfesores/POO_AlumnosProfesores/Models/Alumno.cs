using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AlumnosProfesores.Models
{
    class Alumno : Persona
    {
        public string email { get; set; }
        private string Inasistencias { get; set; }

        public string ListaInasistencias() {
            return Inasistencias.ToString();
        }


        public Alumno(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}
