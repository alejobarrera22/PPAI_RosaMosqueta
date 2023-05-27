using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class Cliente
    {
        public int dni;
        private string nombreCompleto;
        private int nroCelular;

        public Cliente(int dni, string nombre, int celu)
        {
            this.dni = dni;
            this.nombreCompleto = nombre;
            this.nroCelular = celu;
        }

        public string getNombreCompleto()
        { 
            return nombreCompleto; 
        }    
    }
}
