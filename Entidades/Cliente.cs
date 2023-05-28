using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class Cliente
    {
        private int dni { get; set; }
        private string nombreCompleto { get; set; }
        private int nroCelular { get; set; }

        public Cliente(int documento, string nombre, int numero)
        {
            this.dni = documento;
            this.nombreCompleto = nombre;
            this.nroCelular = numero;
        }

    }
}