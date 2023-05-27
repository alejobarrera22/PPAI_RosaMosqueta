using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class RespuestaPosible
    {
        private string descripcion { get; set; }
        //No estoy seguro de que tipo tendria que ser el valor y como utilizarlo
        private int valor { get; set; }
        public RespuestaPosible(String descripcion, int valor)
        {
            this.descripcion = descripcion;
            this.valor = valor;

        }
        public string getDrescripcionRta()
        {
            return descripcion;
        }

        
    }
}
