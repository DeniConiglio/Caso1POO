﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaInstrumentos.Models.Base;

namespace PracticaInstrumentos.Models.Derivada
{
    public abstract class Violin:InstrumentoMusical
    {
        public override string afinar(string Nombre)
        {
            return "Afinando Violin...";
        }
    }
}
