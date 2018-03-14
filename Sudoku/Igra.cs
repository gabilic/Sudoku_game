using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Igra
    {
        public event popuniSlagalicuEventHandler popuniSlagalicu;
        public delegate void popuniSlagalicuEventHandler(String[,] brojevi, String tip);
        public event vratiOdgovorEventHandler vratiOdgovor;
        public delegate void vratiOdgovorEventHandler(IEnumerable<Rezultat> rezultat);

        private String[,] brojevi = new String[9, 9];

        public void novaIgra(int razina)
        {
            IEnumerable<Rezultat> rezultat = from element in new PlQuery("ispis_pocetna(X, " + razina.ToString() + ")").ToList()
                                             select new Rezultat { broj = (String)element["X"] };
            dodajBrojeve(rezultat, "pocetna");
        }

        public void rjesenje()
        {
            IEnumerable<Rezultat> rezultat = from element in new PlQuery("ispis_rjesenje(X)").ToList()
                                             select new Rezultat { broj = (String)element["X"] };
            dodajBrojeve(rezultat, "rjesenje");
        }

        public void provjera(String provjera)
        {
            IEnumerable<Rezultat> rezultat = from element in new PlQuery("provjeri_rjesenje(" + provjera + ", X)").ToList()
                                             select new Rezultat { broj = (String)element["X"] };
            vratiOdgovor(rezultat);
        }

        private void dodajBrojeve(IEnumerable<Rezultat> rezultat, String tip)
        {
            int i = 0;
            int j = 0;
            foreach (var element in rezultat)
            {
                brojevi[i, j++] = element.broj;
                if (j == 9)
                {
                    j = 0;
                    i++;
                }
            }
            popuniSlagalicu(brojevi, tip);
        }
    }
}
