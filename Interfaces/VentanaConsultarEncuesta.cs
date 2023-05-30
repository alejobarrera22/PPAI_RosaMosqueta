using System;
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
            btn_Cancelar.Visible = true;
            lbl_Hasta.Visible = true;
            lbl_Desde.Visible = true;
            gestor.consultarEncuesta();
           
        }

        public void solicitarSeleccionPeriodo()
        {
            dateHasta.Visible = true;
            dateDesde.Visible = true;
        }
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            gestor.periodoSeleccionado(dateDesde.Value, dateHasta.Value);
        }

        /*
         * Este método se encarga de solicitar la selección de una llamada de una lista de llamadas encontradas. Recibe como parámetro la lista de llamadas encontradas representadas como cadenas.
            En primer lugar, se hace visible un control de datos llamado "dataLlamadasEncontradas" y otro control de selección llamado "seleccioneLlamada". Luego, 
            se limpian todas las filas del control de datos.
            A continuación, se itera a través de la lista de llamadas encontradas. Para cada elemento, se crea una nueva fila en el control de datos. Se crea una celda de texto y se le asigna 
            el valor de "Llamada" seguido del índice actual. Esta celda se agrega a la fila, y finalmente la fila se agrega al control de datos.
            De esta manera, se muestra una lista numerada de llamadas encontradas en el control de datos para que el usuario pueda seleccionar una de ellas.
         */
        public void solicitarSeleccionLLamada(List<string> llamadasEncontradas)
        {
            
            dataLlamadasEncontradas.Visible = true;
            seleccioneLlamada.Visible = true;
            dataLlamadasEncontradas.Rows.Clear();
            for (int i = 0; i < llamadasEncontradas.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell cell1 = new DataGridViewTextBoxCell();
                cell1.Value = "Llamada "+i;
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
            tomarSeleccionLlamada(dataLlamadasEncontradas.CurrentRow.Index);
        }

        private void tomarSeleccionLlamada(int row)
        {
            gestor.llamadaSeleccionada(row);
        }

        public void mostrarDatosLLamadaSeleccionada(string nombreCliente, string duracion, string estadoActual, string respuestas)
        {
            gBox_Llamada.Visible = true;
            labelNombreCompleto.Visible = true;
            textNombreCompleto.Visible = true;
            textNombreCompleto.Text = nombreCliente;
            labelDuracionLlamada.Visible = true;
            textBoxDuracionLLamada.Visible = true;
            textBoxDuracionLLamada.Text = duracion;
            labelEstadoActualLlamada.Visible =true;
            textBoxEstadoActualLLamada.Visible = true;
            textBoxEstadoActualLLamada.Text = estadoActual;
            

            gBox_Encuesta.Visible = true;
            label2.Visible = true;
            label2.Text = "Nombre de la encuesta: " + respuestas;
            
        }

        public void solicitarSeleccionFormaGeneracion()
        {
            btn_CSV.Visible = true;
            btn_imprimir.Visible = true;
        }

        private void btn_CSV_Click(object sender, EventArgs e)
        {
            tomarSeleccionGenerarCSV();
            
        }

        private void tomarSeleccionGenerarCSV()
        {
            gestor.seleccionGenerarCSV();
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            gestor.imprimir();
        }
    }
}
