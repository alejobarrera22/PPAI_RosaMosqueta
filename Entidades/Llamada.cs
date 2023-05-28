using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class Llamada
    {
        private List<CambioEstado> cambioEstado { get; set; }
        private List<RespuestaCliente> repuestasDeEncuesta { get; set; }
        private Cliente cliente { get; set; }
        private string descripcionOperador { get; set; }
        private string detalleAccionRequerida { get; set; }
        private int duracion { get; set; }
        private bool encuestaEnviada { get; set; }
        private string observacionAuditor { get; set; }


        public Llamada(List<CambioEstado> cambioEstado, List<RespuestaCliente> repuestasDeEncuesta, Cliente cliente, string descripcionOperador, string detalleAccionRequerida,
            int duracion, bool encuestaEnviada, string observacionAuditor)
        {
            this.cambioEstado = cambioEstado;
            this.cliente = cliente;
            this.repuestasDeEncuesta = repuestasDeEncuesta;
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
        }


        //El método EsDePeriodo() utiliza el método DeterminarEstadoInicial() para obtener la fecha inicial y luego verifica si está dentro del rango definido
        //por fechaInicio y fechaFin.
        public bool esDePerido(DateTime fechaInicio, DateTime fechaFin)
        {
            DateTime fechaHorainicio = determinarEstadoInical();
            return (fechaHorainicio >= fechaInicio && fechaHorainicio <= fechaFin);
        }

        //El método DeterminarEstadoInicial() crea una lista de fechas cambiosEstado utilizando el método Select() para obtener
        //las fechas de inicio de cada elemento de CambioEstado. Luego, se utiliza el método Min() para obtener la fecha mínima de la lista.
        public DateTime determinarEstadoInical()
        {
            List<DateTime> fechasCreacion = this.cambioEstado.Select(fechaHoraInicio => fechaHoraInicio.getFechaHoraIncio()).ToList();
            return fechasCreacion.Min();
        }

        //devolvera True si la tiene repuestasDeEncuasta, es decir la lista de repuestas no esta vacia
        public bool tieneRtas()
        {
            return (repuestasDeEncuesta != null);
        }


        public string getNombreClienteDeLLamada()
        {
            return cliente.getNombre();
        }

        public int getDuracion()
        {
            return duracion;
        }

        public string determinarUltimoEstado()
        {
            //// Ordenar la lista en orden descendente según la fechaHoraInicio
            var ultimoEstado = cambioEstado.OrderByDescending(c => c.getFechaHoraIncio()).FirstOrDefault();
            if (ultimoEstado != null)
            {
                //// Se encontró el último estado
                // Accede a los atributos o propiedades del último estado si es necesario
                return ultimoEstado.getNombreEstado();
            }
            return null;

        }

        public string getRespuestas()
        {
            //List<RespuestaCliente> listadoRespuestas = new List<RespuestaCliente>();
            string resps = "";
            string concat = "";
            string nomEncuesta = "";
            foreach (RespuestaCliente respuesta in repuestasDeEncuesta)
            {
                RespuestaPosible respuestaPosible = respuesta.respuestaSeleccionada;
                Pregunta pregunta = respuestaPosible.pregunta;
                Encuesta encuesta = pregunta.encuesta;
                nomEncuesta = encuesta.getDescripcionEncuesta() + "\n\n\n RESPUESTAS SELECCIONADAS:\n";
                concat += "\n" + pregunta.getDescripcion() + "  ==>  " + respuestaPosible.getDrescripcionRta();
            }
            resps = nomEncuesta + concat;
            return resps;
        }
    }

}
