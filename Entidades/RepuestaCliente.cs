using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class RespuestaCliente
    {
        private DateTime fechaEncuesta { get; set; }
        public RespuestaPosible respuestaSeleccionada { get; set;}

        public RespuestaCliente(DateTime fechaEncuesta, RespuestaPosible respuestaSeleccionada)
        {
            this.fechaEncuesta = fechaEncuesta;
            this.respuestaSeleccionada = respuestaSeleccionada;
        }

        public string getDescripcionRta()
        {
            return respuestaSeleccionada.getDrescripcionRta();
        }
    }
}

