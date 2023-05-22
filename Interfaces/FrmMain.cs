using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_RosaMosqueta.Interfaces
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            //aca gena inicializa la seseion i le asigna 
        }

        private void habilitarPantalla()
        {
            var frmConsutarEncuesta = new VentanaConsultarEncuesta(); //aca ena le pasa el estado de la sesion
            frmConsutarEncuesta.Show();
            //this.Dispose(); //preguntar encuesta
        }

        private void button1_Click(object sender, EventArgs e)
        {
            habilitarPantalla();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
