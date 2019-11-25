using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCsharp
{
    class StringFunctions
    {
        public static void CountWords(string unos)
        {
            var reci = unos.Trim().Split(' ');
            var brojReci = 0;
            foreach (string rec in reci)
            {
                if (rec.Length > 0) brojReci++;
            }
            Console.WriteLine("Broj reci u unetom tekstu je: {0}", brojReci);

            // Ovo ne radi kako treba, u slucaju duplih razmaka izmedju reci
            //var brojReci = unos.Trim().Split(' ').Length;
        }

        public static void CountSpaces(string unos)
        {
            // Nacin 1
            var brojRazmaka = unos.Trim().Count(Char.IsWhiteSpace);

            //Nacin 2
            //var brojRazmaka = 0;
            //foreach (char karakter in unos)
            //{
            //    if (karakter.Equals(' ')) brojRazmaka++;
            //}

            Console.WriteLine("Broj razmaka u unetom tekstu je: {0}", brojRazmaka);
        }

        public static void ShortestWord(string unos)
        {
            var words = unos.Trim().Split(' ');
            if (unos.Length > 0)
            {
                var najkraca = words[0];
                foreach (string rec in words)
                {
                    if (najkraca.Length > rec.Length && rec.Length > 0)
                    {
                        najkraca = rec;
                    }
                }

                Console.WriteLine("Najkraca rec u unetom tekstu je: {0}", najkraca);
            } else
            {
                Console.WriteLine("Vas uneti tekst nema najkracu rec, zato sto nema reci.");
            }
        }

        public static void LongestWord(string unos)
        {
            var words = unos.Split(' ');
            if (unos.Length > 0)
            {
                var najduza = words[0];
                foreach (string rec in words)
                {
                    if (najduza.Length < rec.Length)
                    {
                        najduza = rec;
                    }
                }

                Console.WriteLine("Najduza rec u unetom tekstu je: {0}", najduza);
            }
            else
            {
                Console.WriteLine("Vas uneti tekst nema najduzu rec, zato sto nema reci.");
            }
        }
    }
}
