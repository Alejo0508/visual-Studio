using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using capaEntidad;
using System.Data;

namespace capaNegocio
{
    public class CNempleado
    {

        CDempleado odatempleado = new CDempleado();

        public bool guardar_empleado(CEempleado oentempleado)
        {

            return odatempleado.guardar_empleado(oentempleado);

        }



    }
}
