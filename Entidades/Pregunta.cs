using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class Pregunta
    {
        private string pregunta { get; set; }
        private List<RespuestaPosible> repuestas { get; set; }


        //constructor
        public Pregunta(string pregunta, List<RespuestaPosible> repuestas)
        {
            this.pregunta = pregunta;
            this.repuestas = repuestas;
        }

        //faltan los metodos// 
    }
}
