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
        private Estado estado { get; set; }

        //constructor
        public CambioEstado(DateTime fechaHoraInicio,Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;

        }

        //muestra el nombre de su estado asociado
        public string getNombreEstado()
        {
            return estado.getNombre();
        }


        //para filtar por perido necesito obtener la hora actual del estado
        public DateTime getFechaHoraIncio()
        {
            return fechaHoraInicio;
        }
    }

    
}
