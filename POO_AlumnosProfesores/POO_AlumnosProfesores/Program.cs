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

            Persona[] lista = new Persona[3];


            lista[0] = new Alumno("william HC", "Huamantoma Cardenas")
            {
                Id = 1,             
                Edad=56,
                teléfono ="11111111111",
                email="william7057@gmail.com"
            };
            lista[1] = new Profesor()
            {
                Id = 2,
                Nombre = "Miguel",
                Apellido = "Grau",
                Edad = 156,
                teléfono = "11111111111",
                Catedra="Programacion"
               
            };
            lista[2] = new Profesor()
            {
                Id = 3,
                Nombre = "William",
                Apellido = "Huamantoma",
                Edad = 32,
                teléfono = "11111111111",
                Catedra = "Algebra"

            };
            Console.WriteLine(Persona.ContadorPersonas);

            foreach (Persona item in lista)
            {
                Console.WriteLine($"Tipo{item.GetType()}");
                Console.WriteLine(item.ConstruirResumen());

            }






            Console.ReadLine();
            }
    }
}
