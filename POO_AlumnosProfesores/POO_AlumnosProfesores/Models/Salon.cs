﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AlumnosProfesores.Models
{
    class Salon : IEnteInstituto
    {
        public int Id { get; set; }
        public string  Nombre { get; set; }
        public string CodigoInterno
        {
            get ;
            set ;
        }

        public string ConstruirLlaveSecreta(string nombreEnte)
        {
            return "SAL ON";
        }
    }
}
