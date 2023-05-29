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
        private int valor { get; set; }
        public Pregunta pregunta { get; set; }


        public RespuestaPosible(string descripcion, int valor, Pregunta pregunta)
        {
            this.descripcion = descripcion;
            this.valor = valor;
            this.pregunta = pregunta;
        }

        public string getDrescripcionRta()
        {
            return descripcion;
        }
    }
}
