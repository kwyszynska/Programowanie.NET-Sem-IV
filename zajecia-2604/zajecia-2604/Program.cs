using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zajecia_2604
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void RLE(ref string x, char y, int licznik)
            {
                if (licznik > 0)
                {
                    x += y;
                }

                if (licznik > 1)
                {
                    x += licznik.ToString();
                }
            }

            string Kompresja(string doSkompresowania)
            {
                string wynik = "";
                int licznik = 0;
                char y = doSkompresowania[0];
                for (int i = 0; i < doSkompresowania.Length; i++)
                {
                    if (doSkompresowania[i] == y)
                    {        
                        licznik++;
                    }
                    else
                    {
                        RLE(ref wynik, y, licznik);
                        y = doSkompresowania[i];
                        licznik = 1;
                    }
                }


                RLE(ref wynik, y, licznik);
                return wynik;
            }
                       
            Console.WriteLine(Kompresja("Unnnniiiiiwweeerrrekkkkk"));
            Console.ReadKey();
        }
    }
}
