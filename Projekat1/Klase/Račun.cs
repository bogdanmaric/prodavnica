using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1.Klase
{
    [Serializable]
    public class Račun : ISerializable
    {
        public List<ArtikalRačun> Artikli { get; set; }
        public DateTime DatumKreiranjaRačuna { get; set; }

        public Račun(DateTime vreme_trenutno, List<ArtikalRačun> artikli) {
            Artikli = artikli;
            DatumKreiranjaRačuna = vreme_trenutno;
        }


        public Račun() : this(new DateTime(), new List<ArtikalRačun>()) { }


        public override string ToString()
        {
            return $"Račun";
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Artikli", Artikli);
            info.AddValue("DatumKreiranjaRačuna", DatumKreiranjaRačuna);
        }

        public Račun(SerializationInfo info, StreamingContext context)
        {
            Artikli = (List<ArtikalRačun>)info.GetValue("Artikli", typeof(List<ArtikalRačun>));
            DatumKreiranjaRačuna = (DateTime)info.GetValue("DatumKreiranjaRačuna", typeof(DateTime));
        }
    }
}
