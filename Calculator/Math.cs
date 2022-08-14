using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Math
    {
        public void AddingwithoutTesting()
        {
            int ergebnis;

            Console.WriteLine("Bitte zwei Zahlen eingeben:");

            Console.Write("Zahl 1:");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Zahl 2:");
            int b = int.Parse(Console.ReadLine());

            ergebnis = a + b;

            Console.WriteLine(ergebnis);
        }

        //Diese Methode isoliert die eigentliche Logik
        //Sie beschäftigt sich weder mit Eingabe noch Ausgabe
        public int Adding(int a, int b)
        {
            int ergebnis;

            ergebnis = a + b;

            return ergebnis;
        }

        public int Subtracting(int a, int b)
        {
            int ergebnis;

            ergebnis = a - b;

            return ergebnis;
        }

        //Bei a = positiv und b = negativ gibt es ein Problem
        public int Multipling(int a, int b)
        {
            int ergebnis = 0;

            if (b < 0)
            {
                for (int i = b; i < 0; i++)
                {
                    ergebnis = ergebnis - a;
                }
            }
            else
            {
                for (int i = 0; i < b; i++)
                {
                    ergebnis = ergebnis + a;
                }
            }

            return ergebnis;
        }

        //Korrektes multiplizieren unter verwendung von * 
        //public int Multiplizieren(int a, int b)
        //{
        //    int ergebnis = 0;

        //    bool zweiteZahlNegativ = false;
        //    if (b < 0)
        //    {
        //        b = b * -1;
        //        zweiteZahlNegativ = true;
        //    }

        //    for (int i = 0; i < b; i++)
        //    {
        //        ergebnis = ergebnis + a;
        //    }

        //    if (zweiteZahlNegativ)
        //    {
        //        ergebnis = ergebnis * -1;
        //    }

        //    return ergebnis;
        //}
    }


}
