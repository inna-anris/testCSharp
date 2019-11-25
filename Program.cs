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

            Zadatak1();
        }

        private static void Zadatak1()
        {
            Console.Write("Unesite prvi broj:");
            var prvi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite drugi broj:");
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
    }
}
