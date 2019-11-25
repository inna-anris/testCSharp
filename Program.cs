using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Zadatak1();
            //Zadatak2();
            Zadatak3();
        }

        private static void Zadatak1()
        {
            Console.Write("Unesite prvi broj: ");
            var prvi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            var drugi = Convert.ToInt32(Console.ReadLine());

            var prviParan = false;
            if (prvi%2==0)
            {
                prviParan = true;
            }

            var drugiParan = false;
            if (drugi%2==0)
            {
                drugiParan = true;
            }

            if (prviParan && drugiParan)
            {
                Console.WriteLine("Oba broja su parna. Njiov proizvod je: {0}", prvi * drugi);
            } else if (prviParan || drugiParan) {
                List<int> brojevi = new List<int> { prvi, drugi };
                var kolicnik = Convert.ToDecimal(brojevi.Max()) / Convert.ToDecimal(brojevi.Min());
                Console.WriteLine("Jedan od projeva je paran a drugi neparan. Njihov kolicnik (manji/veci) je: {0}", kolicnik);
            } else
            {
                Console.WriteLine("Oba broja su neparna. Njiov zbir je: {0}", prvi + drugi);
            }

            Console.ReadKey();
        }

        private static void Zadatak2()
        {

            string unos = "";
            var noviBroj = 0;
            List<int> listaUnosa = new List<int>();
            while (noviBroj >= 0) 
            {
                Console.Write("Unesite novi broj: ");
                unos = Console.ReadLine();
                if (!string.IsNullOrEmpty(unos)) 
                {
                    noviBroj = Convert.ToInt32(unos);
                    if (noviBroj >= 0) listaUnosa.Add(noviBroj);
                } else
                {
                    noviBroj = 0;
                }

            }

            var suma = Convert.ToDecimal(IzracunajSumu(listaUnosa));
            IzracunajAritmetickuSredinu(suma, listaUnosa.Count());
            SortirajBrojeve(listaUnosa);

            Console.ReadKey();
        }

        private static int IzracunajSumu(List<int> listaUnosa)
        {
            var suma = 0;

            foreach(int broj in listaUnosa)
            {
                suma += broj;
            }


            Console.WriteLine("Suma unetih brojeva je: {0}", suma);

            return suma;
        }

        private static void IzracunajAritmetickuSredinu(decimal suma, int brojElemenata)
        {
            var aritmeticakSredina = suma / brojElemenata;
            Console.WriteLine("Aritmeticka sredina unosa je: {0}", aritmeticakSredina);
        }

        private static void SortirajBrojeve(List<int> listaUnosa)
        {
            for (int i = 0; i < listaUnosa.Count() - 1; i++)
            {
                for (int j = i+1; j < listaUnosa.Count(); j++)
                {
                    if (listaUnosa[i] < listaUnosa[j])
                    {
                        var temp = listaUnosa[i];
                        listaUnosa[i] = listaUnosa[j];
                        listaUnosa[j] = temp;
                    }
                }
            }

            Console.Write("Sortirana lista unetih brojeva:");
            foreach (int unos in listaUnosa)
            {
                Console.Write(" {0}", unos);
            }
        }

        private static void Zadatak3()
        {
            Console.Write("Unesite neki tekst: ");
            var unos = Console.ReadLine();
            StringFunctions.CountWords(unos);
            StringFunctions.CountSpaces(unos);
            StringFunctions.ShortestWord(unos);
            StringFunctions.LongestWord(unos);
            Console.ReadKey();
        }
    }
}
