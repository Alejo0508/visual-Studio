using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class CEempleado
    {

        private int cod_empleado;
        private String nom_empleado;
        private int edad_empleado;
        private String sexo_empledo;
        private double sueldo_empl;

        public int Cod_empleado { get => cod_empleado; set => cod_empleado = value; }
        public string Nom_empleado { get => nom_empleado; set => nom_empleado = value; }
        public int Edad_empleado { get => edad_empleado; set => edad_empleado = value; }
        public string Sexo_empledo { get => sexo_empledo; set => sexo_empledo = value; }
        public double Sueldo_empl { get => sueldo_empl; set => sueldo_empl = value; }



    }
}
