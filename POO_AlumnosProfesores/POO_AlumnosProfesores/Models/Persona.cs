﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AlumnosProfesores.Models
{
    class Persona
    {
        public static int ContadorPersonas = 0;
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public short Edad { get; set; }
        public string teléfono { get; set; }
        public string NombreCompleto
        {

            get {

                return $"{Nombre} {Apellido}";


            }
        }

        public Persona()
        {
            ContadorPersonas++;
        }
   
    }
}
