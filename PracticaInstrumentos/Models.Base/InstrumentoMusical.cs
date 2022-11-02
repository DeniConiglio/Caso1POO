using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PracticaInstrumentos.Models.Base
{
    public abstract class InstrumentoMusical
    {
        public  string Nombre { get; set; }
        public abstract string afinar(string nombre);
    }
}
