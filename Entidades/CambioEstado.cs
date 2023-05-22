using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI_RosaMosqueta.Entidades
{
    public class CambioEstado
    {
        private DateTime  fechaHoraInicio { get; set; }
        private DateTime? fechaHoraHasta { get; set; }
        private Estado estado { get; set; }

        public CambioEstado(DateTime fechaHoraInicio,DateTime fechaHoraHasta ,Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.fechaHoraHasta = fechaHoraHasta;
            this.estado = estado;

        }

        //para mi tendria que ir por parte de que la llamada este finalizada
        public bool esEstadoIncial()
        {
            if (estado.esIniciada())
            {
                return true;
            }
            return false;
        }

        //Indica si es el cambio de estado actual
        public bool esUltimoEstado()
        {
            if (fechaHoraHasta == null)
            {
                return true;
            }
            return false;
        }

        //muestra el nombre de su estado asociado
        public string getNombreEstado()
        {
            return estado.getNombre();
        }

   

        //para filtar por perido necesito obtener la hora actual del estado
        public string getFechaHoraIncio(string fechaHoraInicio)
        {
            return fechaHoraInicio;
        }
    }

    
}
