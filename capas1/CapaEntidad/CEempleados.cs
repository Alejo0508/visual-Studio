using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEempleados
    {

        // con esto se crean variables que seran referenciadas de la tabla empleado de sql

        public int cod_empleado { get; set; }

        public String nom_empleado { get; set; }

        public int edad_empleado { get; set; }

        public String sexo_empleado { get; set; }

        public double sueldo_empl { get; set; }

    }
}
