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
        private RespuestaPosible repuestaSeleccionada { get; set;}

        public RespuestaCliente(DateTime fechaEncuesta, RespuestaPosible repuestaSeleccionada)
        {
            this.fechaEncuesta = fechaEncuesta;
            this.repuestaSeleccionada = repuestaSeleccionada;
        }

        public string getDescripcionRta()
        {
            return repuestaSeleccionada.getDrescripcionRta();
        }
    }
}

