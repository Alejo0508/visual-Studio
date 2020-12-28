using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaEntidad;
using CapaNegocio;

namespace aeropuerto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listarPiloto();
        }

        CEpiloto objetoentidad = new CEpiloto();
        CNpiloto objetonegocio = new CNpiloto();

         void listarPiloto()
        {

            DataTable tabla = objetonegocio.N_listado();

            dgvpilotos.DataSource = tabla;


        }
    }
}
