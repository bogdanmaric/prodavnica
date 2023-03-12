using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1.Klase
{
    public class Artikal
    {
        public int IdArtikla { get; set; }
        public string NazivArtikla { get; set; }
        public int CenaArtikla { get; set; }
        public string JedinicaPoMeriArtikla { get; set; }
        public string KategorijaArtikla { get; set; }

        public Artikal(int id, string nazivartikla, int cena_artikla, string jedinica_po_meri_artikla, string kategorija_artikla) {
            IdArtikla = id;
            NazivArtikla = nazivartikla;
            CenaArtikla = cena_artikla;
            JedinicaPoMeriArtikla = jedinica_po_meri_artikla;
            KategorijaArtikla = kategorija_artikla;
        }

        public override string ToString()
        {
            return $"{NazivArtikla} {CenaArtikla}/{JedinicaPoMeriArtikla} - {KategorijaArtikla}";
        }
    }

    
}
