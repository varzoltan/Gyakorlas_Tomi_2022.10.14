using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyakorlas_Tomi_2022._10._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Írj programot, mely beolvassa a másodfokú egyenlet együtthatóit, és kiírja, hogy az
            //egyenletnek van-e megoldása!

            Console.Write("Adja meg az 1. együtthatót: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a 2. együtthatót: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Adja meg a 3. együtthatót: ");
            int c = int.Parse(Console.ReadLine());

            if(Math.Pow(b,2) - (4*a*c) < 0)
            {
                Console.WriteLine("Nincs megoldás");
            }
            else
            {
                Console.WriteLine("Van megoldás");
            }

            //Írj programot, ami beolvassa a másodfokú egyenlet együtthatóit, és kiírja az
            //egyenlet megoldásait, ha vannak!

            double meg1 = ((-b + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / 2*a);
            double meg2 = ((-b - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c))) / 2*a);

            if (Math.Pow(b, 2) - (4 * a * c) < 0)
            {
                Console.WriteLine("Nincs megoldás");
            }

            else if (Math.Pow(b, 2) - (4 * a * c) == 0)
            {
                Console.WriteLine("A megoldás: " + meg1);
            }

            else
            {
                Console.WriteLine("Az 1. megoldás: " + meg1);
                Console.WriteLine("A 2. megoldás: " + meg2);
            }

            /*double diszkriminans = b * b - 4 * a * c;
            if (diszkriminans < 0)
            {
                Console.WriteLine("Az egyenletnek nincs megoldása");
            }
            else if (diszkriminans == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("Az egyenletnek két egybeeső gyöke van: " + x);
            }
            else
            {
                double x1 = -b + Math.Sqrt(diszkriminans) / 2 * a;
                double x2 = -b - Math.Sqrt(diszkriminans) / 2 * a;
                Console.WriteLine($"Az egyenlet egyik megoldáas: {x1}\nA másik megoldása: {x2}");
            }*/

            //Írj programot, mely beolvassa egy derékszögű háromszög két befogóját, és megadja
            //az átfogójának a hosszát!Az átfogót 2 tizedesjeggyel add meg!

            Console.WriteLine("Adja meg az 1. befogó hosszát: ");
            int bef1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Adja meg az 2. befogó hosszát: ");
            int bef2 = int.Parse(Console.ReadLine());

            int atfnz = (bef1  *  bef1)  +  (bef2  *  bef2);

            Console.WriteLine("Az átfogó hossza: " + Math.Round(Math.Sqrt(atfnz),2));

            //Írj programot, mely beolvassa a téglatest három élének hosszát, és kiírja a
            //felszínének és térfogatának mérőszámát!

            Console.ReadKey();
        }
    }
}
