using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1.Klase
{
    class IzuzetakPrazanInput : Exception
    {
        public override string ToString()
        {
            return "Niste uneli/izabrali potrebne podatke u polja";
        }
    }
}
