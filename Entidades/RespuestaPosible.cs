﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_RosaMosqueta.Entidades
{
    public class RespuestaPosible
    {
        private string Descripcion;
        private int Valor;

        public RespuestaPosible(string desc, string val)
        {
            Descripcion = desc;
            Valor = val;

        }
        public string getDescripcionRta()
        {
            return Descripcion;
        }
    }
}
