using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class Estado
    {

        private string nombre { get; set; }

        public Estado(string nombre)
        {
            this.nombre = nombre;

        }

        public bool esFinalzada()
        {
            return nombre == "finalizada";
        }

        public string getNombre() { return nombre;}
    }
}
