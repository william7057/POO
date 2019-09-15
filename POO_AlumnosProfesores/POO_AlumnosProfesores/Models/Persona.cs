using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AlumnosProfesores.Models
{
    class Persona
    {
        public int Id { get; set; }
        public int Nombre { get; set; }
        public int Apellido { get; set; }
        public short Edad { get; set; }
        public string NombreCompleto { get {
                return $"{Nombre} {Apellido}";
            } }

        
       
    }
}
