using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// se agregan librerias que estan conectando a la bd para poder verlas
using CapaEntidad;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CNempleados
    {

        // se instancias las clases que usaremos que tienen conexion en la bd

        CDempleados objdato = new CDempleados();

        public DataTable N_listado()
        {

            return objdato.D_listado(); // se crea un metodo public que retornara en la variable objdato la conexion que tiene el metodo D_listado de la clase CDempleado
        
        }


    }
}
