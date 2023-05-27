using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class RepuestaCliente
    {
        private DateTime fechaEncuesta { get; set; }
        private RepuestaPosible repuestaSeleccionada { get; set;}

        public RepuestaCliente(DateTime fechaEncuesta, RepuestaPosible repuestaSeleccionada)
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
