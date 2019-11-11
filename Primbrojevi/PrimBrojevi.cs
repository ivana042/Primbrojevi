using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.Pood
{
    public class PrimBrojevi
    {
       static  int s; // duljina niza
       static bool[] eliminirani; // niz s primbrojevima

        // Primjer iz knjige  Robert C. Martin: "Agile Software Development"!!!
        public static int[] GenerirajPrimBrojeve(int max)
        {
            if (max < 2)
                return new int[0]; // vrati prazan niz

            InicijalizirajSito(max);

            Prosijaj();

            return IspisiPrimBrojeve();

        }

        private static int[] IspisiPrimBrojeve()
        {
            // koliko je primbrojeva?
            int broj = 0;
            for (int i = 0; i < s; ++i)
            {
                if (eliminirani[i]==false)
                    ++broj;
            }

            int[] primovi = new int[broj];

            // prebaci primbrojeve u rezultat
            for (int i = 0, j = 0; i < s; ++i)
            {
                if (eliminirani[i]==false)
                    primovi[j++] = i;
            }
            return primovi; // vrati niz brojeva
        }

        private static void Prosijaj()
        {
            // sito (ide do kvadratnog korijena maksimalnog broja)

            for (int i = 2; i < Math.Sqrt(s) + 1; ++i)
            {
                if (eliminirani[i]==false) // ako je i prekrižen, prekriži i višekratnike
                {
                    for (int j = 2 * i; j < s; j += i)
                        eliminirani[j] = true; // višekratnik nije primbroj
                }
            }
        }

        private static void InicijalizirajSito(int max)
        {
            s = max + 1; // duljina niza
            eliminirani = new bool[s]; // niz s primbrojevima

            // ukloni 0 i 1 koji su primbrojevi po definiciji
            eliminirani[0] = eliminirani[1] = true;

            // inicijaliziramo sve na true
            for (int i = 2; i < s; ++i)
                eliminirani[i] = false;

            
        }
    }
}
