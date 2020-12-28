using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNpiloto
    {

        CDpiloto objeto = new CDpiloto();

        public DataTable N_listado()
        {

            return objeto.D_listado();
        
        }

    }
}
