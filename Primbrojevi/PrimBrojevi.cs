﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.Pood
{
    public class PrimBrojevi
    {
      

        // Primjer iz knjige  Robert C. Martin: "Agile Software Development"!!!
        public static int[] GenerirajPrimBrojeve(int max)
        {
            if (max < 2)
                return new int[0]; // vrati prazan niz

            bool [] brojevi = InicijalizirajNizIntegera(max);

            EliminirajVišekratnike(brojevi);

            return SakupiNeeliminiraneBrojeve(brojevi);

        }

        private static int[] SakupiNeeliminiraneBrojeve(bool [] eliminirani)
        {
            // koliko je primbrojeva?
            int broj = 0;
            for (int i = 0; i < eliminirani.Length; ++i)
            {
                if (eliminirani[i]==false)
                    ++broj;
            }

            int[] primovi = new int[broj];

            // prebaci primbrojeve u rezultat
            for (int i = 0, j = 0; i < eliminirani.Length; ++i)
            {
                if (eliminirani[i]==false)
                    primovi[j++] = i;
            }
            return primovi; // vrati niz brojeva
        }

        private static void EliminirajVišekratnike(bool[] eliminirani)
        {
            // sito (ide do kvadratnog korijena maksimalnog broja)

            for (int i = 2; i < DajGornjuGranicuIteracije(eliminirani); ++i)
            {
                if (eliminirani[i] == false) // ako je i prekrižen, prekriži i višekratnike
                    EliminirajVišekratnikeOd(eliminirani,i);

            }
        }

        private static int DajGornjuGranicuIteracije(bool[] eliminirani)
        {
            return (int)(Math.Sqrt(eliminirani.Length) + 1);
        }

        private static void EliminirajVišekratnikeOd(bool[] eliminirani, int i)
        {
            for (int j = 2 * i; j < eliminirani.Length; j += i)
                eliminirani[j] = true; // višekratnik nije primbroj
        }

        private static bool[] InicijalizirajNizIntegera(int max)
        {
            bool [] eliminirani = new bool[max+1]; // niz s primbrojevima

            // ukloni 0 i 1 koji su primbrojevi po definiciji
            eliminirani[0] = eliminirani[1] = true;

            // inicijaliziramo sve na true
            for (int i = 2; i < eliminirani.Length; ++i)
                eliminirani[i] = false;
            return eliminirani;
            
        }
    }
}
