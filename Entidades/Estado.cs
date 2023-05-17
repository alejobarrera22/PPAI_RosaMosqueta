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

        //Tengo duda con el resto de los estados
        public bool esDescartada()
        {
            return nombre == "descartada";
        }

        public bool esCorrecta()
        {
            return nombre == "correcta";
        }

        public bool esObservacion()
        {
            return nombre == "observacion";
        }

        public string getNombre() { return nombre;}
    }
}
