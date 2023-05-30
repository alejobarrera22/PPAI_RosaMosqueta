using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI_RosaMosqueta.Entidades;
using PPAI_RosaMosqueta.Interfaces;

namespace PPAI_RosaMosqueta.Gestor
{
    public class GestorConsultarEncuesta
    {
        private VentanaConsultarEncuesta pantallaConsultarEncuesta { get; set;}
        private DateTime fechaDesde { get; set; }
        private DateTime fechaHasta { get; set; }
        private List<Llamada> llamadas { get; set; } //= new List<Llamada>(); polque?
        private List<Llamada> llamadasEncontradas { get; set; }
        private Llamada seleccionadaLlamada { get; set; }
        private string nombreCliente { get; set; }
        private string ultimoEstadoLlamada { get; set; }
        private string duracion { get; set; }
        
        public GestorConsultarEncuesta(VentanaConsultarEncuesta pantalla)
        {
            this.pantallaConsultarEncuesta = pantalla;
        }
        
        public void consultarEncuesta()
        {
            //Envia a la pantalla un mensaje para que ingrese un periodo
            pantallaConsultarEncuesta.solicitarSeleccionPeriodo();
        }
        
        public void periodoSeleccionado(DateTime fechaDesde, DateTime fechaHasta)
        {
            filtrarPorPeridoYRepuestas(fechaDesde, fechaHasta);
            
        }
        /*
         * Este método se encarga de filtrar una lista de llamadas por un período de tiempo y la presencia de respuestas. Primero,
         * se crea una lista vacía llamada "llamadasEncontradas" y otra lista vacía llamada "llamadasEncontradasMostrar". Luego,
         * se recorre cada llamada en la lista de llamadas existente. Si la llamada está dentro del período de tiempo especificado y tiene respuestas,
         * se agrega a la lista "llamadasEncontradas" (que servirá para seleccionar las llamadas más adelante) y se agrega una representación en forma de cadena de la llamada a
         * la lista "llamadasEncontradasMostrar" (que se utiliza para mostrar las llamadas). Finalmente, se llama a un método en la pantalla de consultar encuestas para solicitar
         * la selección de llamadas a partir de la lista de llamadas encontradas y mostradas.
         */
        public void filtrarPorPeridoYRepuestas(DateTime fechaDesde, DateTime fechaHasta)
        {
            llamadasEncontradas = new List<Llamada>();
            List<string> llamadasEncontradasMostrar = new List<string>();
            foreach (var llamada in Data.Data.listaDeLLamadas())
            {
                if (llamada.esDePerido(fechaDesde, fechaHasta) && llamada.tieneRtas())
                { 
                 //Me sirve para luego seleccionarla
                 llamadasEncontradas.Add(llamada);
                 //solo me sirve para mostralas
                 llamadasEncontradasMostrar.Add(llamada.ToString()); 
                }
            }
            pantallaConsultarEncuesta.solicitarSeleccionLLamada(llamadasEncontradasMostrar);
        }

        //lo invoca la ventana y le pasa como parametro el index de la fila seleccionada
        public void llamadaSeleccionada(int row)
        {
            //se auto invoca para obtener todos los datoas y de la lista antes creada llamadasEncontrada le pasa la especifica gracias al [index]
            getDatosLLamada(llamadasEncontradas[row]);
            this.seleccionadaLlamada = llamadasEncontradas[row];
        }

        //obtiene los datos necesarios de la Llamada selecionada
        public void getDatosLLamada(Llamada llamadaSeleccionada)
        {
            nombreCliente = llamadaSeleccionada.getNombreClienteDeLLamada();
            ultimoEstadoLlamada = llamadaSeleccionada.determinarUltimoEstado();
            duracion = llamadaSeleccionada.getDuracion().ToString();
            
            // GENERADOR DE DEPENDENCIAS
            Data.Data.ResPos1.pregunta = Data.Data.Preg1;
            Data.Data.ResPos2.pregunta = Data.Data.Preg1;
            Data.Data.ResPos3.pregunta = Data.Data.Preg2;
            Data.Data.ResPos4.pregunta = Data.Data.Preg2;
            Data.Data.ResPos5.pregunta = Data.Data.Preg4;
            Data.Data.ResPos6.pregunta = Data.Data.Preg4;
            Data.Data.ResPos7.pregunta = Data.Data.Preg5;
            Data.Data.ResPos8.pregunta = Data.Data.Preg5;
            Data.Data.ResPos9.pregunta = Data.Data.Preg7;
            Data.Data.ResPos10.pregunta = Data.Data.Preg7;
            Data.Data.ResPos11.pregunta = Data.Data.Preg8;
            Data.Data.ResPos12.pregunta = Data.Data.Preg8;
            Data.Data.ResPos13.pregunta = Data.Data.Preg9;
            Data.Data.ResPos14.pregunta = Data.Data.Preg9;
            Data.Data.ResPos15.pregunta = Data.Data.Preg9;
            Data.Data.ResPos16.pregunta = Data.Data.Preg3;
            Data.Data.ResPos17.pregunta = Data.Data.Preg3;
            Data.Data.ResPos18.pregunta = Data.Data.Preg3;
            Data.Data.ResPos19.pregunta = Data.Data.Preg6;
            Data.Data.ResPos20.pregunta = Data.Data.Preg6;
            Data.Data.ResPos21.pregunta = Data.Data.Preg6;
            Data.Data.ResPos22.pregunta = Data.Data.Preg6;
            Data.Data.Preg1.encuesta = Data.Data.Encuesta1;
            Data.Data.Preg2.encuesta = Data.Data.Encuesta1;
            Data.Data.Preg3.encuesta = Data.Data.Encuesta2;
            Data.Data.Preg4.encuesta = Data.Data.Encuesta2;
            Data.Data.Preg5.encuesta = Data.Data.Encuesta3;
            Data.Data.Preg6.encuesta = Data.Data.Encuesta3;
            Data.Data.Preg7.encuesta = Data.Data.Encuesta3;
            Data.Data.Preg8.encuesta = Data.Data.Encuesta1;
            Data.Data.Preg9.encuesta = Data.Data.Encuesta2;

            string datosEncuesta = llamadaSeleccionada.getRespuestas();
            //Console.WriteLine(datosEncuesta);

            pantallaConsultarEncuesta.mostrarDatosLLamadaSeleccionada(nombreCliente, duracion, ultimoEstadoLlamada, datosEncuesta);
            pantallaConsultarEncuesta.solicitarSeleccionFormaGeneracion();
        }

        public void seleccionGenerarCSV()
        {
            string datosEncabezado = nombreCliente + ";" + ultimoEstadoLlamada + ";" + duracion;
            string datosCSV = seleccionadaLlamada.getDatosCSV();
            ILlamadaCSV interfazCSV = new ILlamadaCSV(datosCSV, datosEncabezado);
            interfazCSV.generarCSV();
        }

        public void imprimir()
        {
            string datosImprimir = "Nombre del Cliente: " + nombreCliente + 
                "\nEstado Actual de la llamada: " + ultimoEstadoLlamada +
                "\nDuración de la llamada: " + duracion + " segundos\n\n\n RESPUESTAS SELECCIONADAS:\n\n" +
                seleccionadaLlamada.getRespuestasImprimir();
            PrintDocument p = new PrintDocument();
            p.DocumentName = "Datos de la encuesta de la llamada seleccionada";
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(datosImprimir, new Font("Times New Roman", 24), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
            };
            try
            {
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo imprimir", ex);
            }
        }
    }
}
