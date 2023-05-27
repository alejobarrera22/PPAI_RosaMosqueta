using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class CambioEstado
    {
        DateTime fechaHoraInicio;
        Estado estado;

        public CambioEstado(DateTime fechInicio, Estado estad)
        {
            this.fechaHoraInicio = fechInicio;
            this.estado = estad
        }

        public string getNombreEstado()
        {
            return estado.getNombre();
        }

        public DateTime getFechaHoraInicio()
        {
            return fechaHoraInicio;
        }
    }
}
