using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1.Klase
{
    class IzuzetakSelektovanaStavka : Exception
    {
        public override string ToString()
        {
            return $"Nije izabrana ni jedna stavka iz liste";
        }
    }
}
