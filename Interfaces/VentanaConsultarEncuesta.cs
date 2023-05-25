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

        private void opcionConsultarEncuesta_Click(object sender, EventArgs e)
        {
            habilitarPantalla();
        }

        private void habilitarPantalla()
        {
            this.gBox_Periodo.Visible = true;
            this.buttonBuscar.Visible = true;
            this.dateTimePicker1.Visible = true;
            this.date_Desde.Visible = true;
            this.pan_Llamadas.Visible = true;
            this.btn_Cancelar.Visible = true;
        }

        private void VentanaConsultarEncuesta_Load(object sender, EventArgs e)
        {

        }
    }
}
