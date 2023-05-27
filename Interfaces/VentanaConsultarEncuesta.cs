﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_RosaMosqueta.Gestor;

namespace PPAI_RosaMosqueta
{
    public partial class VentanaConsultarEncuesta : Form
    {
        private GestorConsultarEncuesta gestor { get; set; }
        public VentanaConsultarEncuesta()
        {
            InitializeComponent();
            gestor = new GestorConsultarEncuesta(this);
        }

        //Se puede cancelar cuando quieran
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Le indica al gestor que inicie el CU
        private void opcionConsultarEncuesta_Click(object sender, EventArgs e)
        {
            habilitarPantalla();
        }

        private void habilitarPantalla()
        {
            gBox_Periodo.Visible = true;
            buttonBuscar.Visible = true;
            gestor.consultarEncuesta();
            btn_Cancelar.Visible = true;
        }

        private void VentanaConsultarEncuesta_Load(object sender, EventArgs e)
        {

        }

        public void solicitarSeleccionPeriodo()
        {
            dateHasta.Visible = true;
            dateDesde.Visible = true;
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            //borrar el contenido de la dataGrindLlamadas
            //dataGrindLlamadas.Rows.Clear();
            gestor.periodoSeleccionado(dateDesde.Value, dateHasta.Value);
        }

        public void pedirSeleccionLLamada()
        {
            
            dataLlamadasEncontradas.Visible = true;
            //para agregar valores a la tabla 
            dataLlamadasEncontradas.Rows.Clear();
            for (int i = 0; i < 5; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                cell1.Value = "a";
                row.Cells.Add(cell1);

                dataLlamadasEncontradas.Rows.Add(row);
            }
        }

        private void date_Desde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
