using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_RosaMosqueta
{
    public partial class VentanaConsultarEncuesta : Form
    {
        public VentanaConsultarEncuesta()
        {
            InitializeComponent();
        }

        //Se puede cancelar cuando quieran
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // filtrar por periodo
        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
