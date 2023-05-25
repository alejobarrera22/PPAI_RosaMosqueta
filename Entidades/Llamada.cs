using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class Llamada
    {
        private DateTime fechaActual;

        private List<CambioEstado> cambioEstado { get; set; }


        public Llamada(List<CambioEstado> cambioEstado)
        {
            this.cambioEstado = cambioEstado;
        }

        
        
        //El método EsDePeriodo() utiliza el método DeterminarEstadoInicial() para obtener la fecha inicial y luego verifica si está dentro del rango definido
        //por fechaInicio y fechaFin.
        public bool esDePerido(DateTime  fechaInicio, DateTime  fechaFin)
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

        /*
         *  //metodo llamado esDePeriodo() que valida si la llamada esta dentro de un periodo dado por 2 parametros date, preguntandole a todos sus "CambioEstado" si el primero esta dentro del periodo y de ese obtiene la fecha y hora
        public bool esDePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            // primero busca el primer cambio de estado de la llamada
            CambioEstado primerCambioEstado = cambiosDeEstados[0];
            // luego obtiene la fecha y hora de ese cambio de estado con el metodo get del cambio de estado
            DateTime fechaHoraPrimerCambioEstado = primerCambioEstado._fechaHoraInicio;
            // luego compara si la fecha y hora del primer cambio de estado esta dentro del periodo dado por los parametros\
            // si es asi devuelve true, sino false
            return fechaHoraPrimerCambioEstado >= fechaDesde && fechaHoraPrimerCambioEstado <= fechaHasta;
        }
         */


    }

}
