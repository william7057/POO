using POO_AlumnosProfesores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AlumnosProfesores
{
    class Program
    {
        static void Main(string[] args)
        {//-------------------------------------------------
            Console.WriteLine("GESTION DE INSTITUCION");

            var alumno1 = new Alumno("william HC", "Huamantoma Cardenas")
            {
                Id = 1,             
                Edad=56,
                teléfono ="11111111111",
                email="william7057@gmail.com"
            };
            var profesor1 = new Profesor()
            {
                Id = 1,
                Nombre = "Miguel",
                Apellido = "Grau",
                Edad = 156,
                teléfono = "11111111111",
                Catedra="Programacion"
               
            };
            Console.WriteLine(Persona.ContadorPersonas);
            



            Console.ReadLine();
            }
    }
}
