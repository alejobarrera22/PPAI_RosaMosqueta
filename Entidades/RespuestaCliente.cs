using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class RespuestaCliente
    {
        private string FechaEncuesta;
        
        public RespuestaCliente(string fecEncuesta)
        {
            FechaEncuesta = fecEncuesta;
        }

        public string FechaDeEncuesta;
        {
            get => FechaEncuesta; set => FechaEncuesta = value;
        }


        public string DescripcionRta;
        {
            get => DescripcionRta;
        }
    }   
}
