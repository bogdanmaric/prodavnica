using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1.Klase
{
    public class ArtikalRačun : Artikal
    {
        public int Količina { get; set; }
        public ArtikalRačun(int id, string naziv, int cena, string jedinica, int količina) : base(id, naziv, cena, jedinica, "") {
            Količina = količina;
        }

        public ArtikalRačun() : this(0, "", 0, "", 0) { }

        public int KonačnaCena() {
            return Količina * CenaArtikla;
        }

        public override string ToString()
        {
            return $"{NazivArtikla}({JedinicaPoMeriArtikla}), Cena: {KonačnaCena()}, Količina: {Količina}";
        }
    }
}
