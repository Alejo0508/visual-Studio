using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// se instancian la capa negocio y entidad

using CapaNegocio;
using CapaEntidad;

namespace capas1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // se crea metodo de listar para programarlo
            ListarEmpleado();

        }

        // se crean  objetos instanciados de las clases CEempleados y CNempleados
        CEempleados objentidad = new CEempleados();
        CNempleados objnego = new CNempleados();

         void ListarEmpleado()
        {

            DataTable dt = objnego.N_listado(); // en la variable dt se iguala al objeto instanciado de CNempleados del metodo N_listado()

            dgvlistado.DataSource = dt; // en el datagrid que se llama dgvlistado y se iguala al objeto que ya esta creado

        }
    }
}
