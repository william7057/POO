using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AlumnosProfesores.Models
{
    public abstract class  Persona:IEnteInstituto
    {
        public static int ContadorPersonas = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public short Edad { get; set; }
        public string teléfono { get; set; }
        public virtual string NombreCompleto
        {

            get {

                return $"{Nombre} {Apellido}";


            }
        }
         public abstract string ConstruirResumen();

        public Persona()
        {
            ContadorPersonas++;
        }



        public string CodigoInterno
        {
            get;
            set;
        }       

        public string ConstruirLlaveSecreta(string nombreEnte)
        {
            var rnd = new Random();
            
            return rnd.Next(1, 999915312).ToString();
        }
    }
}
