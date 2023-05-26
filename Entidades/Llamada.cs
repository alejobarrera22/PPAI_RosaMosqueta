using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class Llamada
    {
        public string descripcionOperador { get; set; }
        public string detalleAccionRequerida { get; set; }
        public int duracionEnSegundos { get; set; }
        public Boolean encuestaEnviada { get; set; }
        public string observacionAuditor { get; set; }
        public List<string> respuestasDeEncueta { get; set; }
        public List<string> cambioEstado { get; set; }
        public string cliente { get; set; }

        public Llamada(int duracionEnSegundos, string cliente, string cambioEstadoNuevo)
        {
            this.duracionEnSegundos = duracionEnSegundos;
            this.cliente = cliente;
            this.cambioEstado = new List<string>();
            cambioEstado.Add(cambioEstadoNuevo);
            this.descripcionOperador = "No Data Yet";
            this.detalleAccionRequerida = "No Data Yet";
            this.encuestaEnviada = false;
            this.observacionAuditor = "No Data Yet";
            this.respuestasDeEncueta = new List<string>();
        }

        public int calcularDuracion(DateTime horaInicio, DateTime horaFin)
        {
            return this.duracionEnSegundos;
        }

        public Boolean esDePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {
            return true;
        }
    }
}
