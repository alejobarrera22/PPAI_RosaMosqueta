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

            //Falta obtener las preguntas y repuestas,etc
            string datosEncuesta = llamadaSeleccionada.getRespuestas();
            //Console.WriteLine(datosEncuesta);

            pantallaConsultarEncuesta.mostrarDatosLLamadaSeleccionada(nombreCliente, duracion, estadoActual, datosEncuesta);
        }
    }
}
