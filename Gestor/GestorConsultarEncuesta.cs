using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_RosaMosqueta.Entidades;

namespace PPAI_RosaMosqueta.Gestor
{
    public class GestorConsultarEncuesta
    {
        private VentanaConsultarEncuesta pantallaConsultarEncuesta { get; set;}
        private DateTime fechaDesde { get; set; }
        private DateTime fechaHasta { get; set; }
        private List<Llamada> llamadas { get; set; } //= new List<Llamada>(); polque?
        private List<Llamada> llamadasEncontradas { get; set; }
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

        public void filtrarPorPeridoYRepuestas(DateTime fechaDesde, DateTime fechaHasta)
        {
            llamadasEncontradas = new List<Llamada>();
            //no se me ocurrio otra forma para mostrala osino no me deja pasarle como parametro
            List<string> llamadasEncontradasMostrar = new List<string>();
            //aca saco del data la lista de llamadas
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


            //aca en verdad tendrian que pasarle como parametro las llamadas, para que solamente cuente cuantas hay y mostrarlas en la grilla
            pantallaConsultarEncuesta.pedirSeleccionLLamada(llamadasEncontradasMostrar);
        }
        //lo invoca la ventana y le pasa como parametro el index de la fila seleccionada
        public void llamadaSeleccionada(int row)
        {
            //se auto invoca para obtener todos los datoas y de la lista antes creada llamadasEncontrada le pasa la especifica gracias al [index]
            getDatosLLamada(llamadasEncontradas[row]);
        }

        //obtiene los datos necesarios de la Llamada selecionada
        public void getDatosLLamada(Llamada llamadaSeleccionada)
        {
            string nombreCliente = llamadaSeleccionada.getNombreClienteDeLLamada();
            Console.WriteLine(nombreCliente);
            string duracion = llamadaSeleccionada.getDuracion().ToString();
            Console.WriteLine(duracion);
            string estadoActual = llamadaSeleccionada.determinarUltimoEstado();
            Console.WriteLine(estadoActual);
            //Falta obtener las preguntas y repuestas,etc
            //List<RespuestaCliente> respuestasSeleccionadas = llamadaSeleccionada.getRespuestas(listadoPreguntas);

            pantallaConsultarEncuesta.mostrarDatosLLamadaSeleccionada(nombreCliente, duracion, estadoActual);
        }
    }
}
