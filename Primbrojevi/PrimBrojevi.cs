using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.Pood
{
    public class PrimBrojevi
    {
       static  int s; // duljina niza
       static bool[] f; // niz s primbrojevima

        // Primjer iz knjige  Robert C. Martin: "Agile Software Development"!!!
        public static int[] GenerirajPrimBrojeve(int max)
        {
            if (max < 2)
              return new int[0]; // vrati prazan niz
            

            s = max + 1; // duljina niza
            f = new bool[s]; // niz s primbrojevima
            

            // inicijaliziramo sve na true
            for (int i = 0; i < s; ++i)
                f[i] = true;

            // ukloni 0 i 1 koji su primbrojevi po definiciji
            f[0] = f[1] = false;

            // sito (ide do kvadratnog korijena maksimalnog broja)
           
            for (int i = 2; i < Math.Sqrt(s) + 1; ++i)
            {
                if (f[i]) // ako je i prekrižen, prekriži i višekratnike
                {
                    for (int j = 2 * i; j < s; j += i)
                        f[j] = false; // višekratnik nije primbroj
                }
            }

            // koliko je primbrojeva?
            int broj = 0;
            for (int i = 0; i < s; ++i)
            {
                if (f[i])
                    ++broj;
            }

            int[] primovi = new int[broj];

            // prebaci primbrojeve u rezultat
            for (int i = 0, j = 0; i < s; ++i)
            {
                if (f[i])
                    primovi[j++] = i;
            }
            return primovi; // vrati niz brojeva
            
        }
    }
}
