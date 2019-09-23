using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_AlumnosProfesores.Models
{
    interface IEnteInstituto
    {
         string CodigoInterno { get; set;
         string ConstruirLlaveSecreta(string nombreEnte);
    }
}
