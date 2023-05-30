﻿using System;
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
        //Constructor
        public Cliente(int documento, string nombre, int numero)
        {
            this.dni = documento;
            this.nombreCompleto = nombre;
            this.nroCelular = numero;
        }

        //retorna el nombre del cliente (atributo propio)
        public string getNombre() { return nombreCompleto; }
    }
}