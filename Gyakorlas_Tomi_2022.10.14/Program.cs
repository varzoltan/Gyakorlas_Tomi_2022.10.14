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

            Console.Write("Adja meg az 1. oldalt: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Adja meg az 2. oldalt: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Adja meg az 3. oldalt: ");
            c = int.Parse(Console.ReadLine());

            int fsz = (a  *  b  +  b  *  c  +  a  *  c)  *  2;
            int tf = a * b *  c;

            Console.WriteLine($"A téglatest felszíne: {fsz}, és térfogata:{tf}");

            //Írj programot, mely beolvassa egy kör átmérőjét, és kiírja a kör kerületét és
            //területét! A pi értékének meghatározásához használd a Math.PI értéket!

            Console.Write("Adja meg a kor átmérőjét: ");
            int d = int.Parse(Console.ReadLine());
            double K = d   *   Math.PI;
            double T = (d   /   2)   *   (d   /   2)   *   Math.PI;
            Console.WriteLine($"A kör területe: {T}, kerülete: {K}");

            //Írj programot, mely beolvas egy pozitív egész számot, és kiírja az egész számokat a
            //képernyőre eddig a számig, egymástól szóközzel elválasztva!
            //Pl.:5 és kiírja a progi: 1 2 3 4 5
            Console.Write("Adjon meg egy pozitív egész számot: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i <= x; i++)
            {
                Console.Write(i+" ");
                //Console.Write(" ");
            }

            //Írj programot, mely beolvas egy pozitív egész számot, és kiírja az egész számokat
            //egymás alá a képernyőre eddig a számig!

            Console.Write("Adjon meg egy pozitív egész számot: ");
            x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine(i);
            }

            //Írj programot, mely beolvas egy pozitív egész számot, és kiírja az osztóit!

            Console.Write("Adjon meg egy pozitív egész számot: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("A szám osztói: ");
            for  (int i = 2; i  <  y; i++)
            {
                if (y % i==0)
                {
                    Console.Write(i + ", ");
                }
            }

            //Írj programot, mely beolvas egy pozitív egész számot, és kiírja az osztóinak az
            //összegét!

            Console.Write("Adjon meg egy pozitív egész számot: ");
            y = int.Parse(Console.ReadLine());
            int ossz = 0;//Összegzés törvénye
            for (int i = 2; i < y; i++)
            {
                if (y % i == 0)
                {
                    ossz += i;
                    
                }
            }
            Console.WriteLine(ossz);

            //Írj programot, mely beolvas egy pozitív egész számot, és megmondja, hogy
            //tökéletes szám-e!(A tökéletes számok azok, melyek osztóinak összege egyenlő a
            //szám kétszeresével.Ilyen szám pl.a 6, mert 2 * 6 = 1 + 2 + 3 + 6.)

            Console.Write("Adjon meg egy pozitív egész számot: ");
            y = int.Parse(Console.ReadLine());
            for (int i = 1; i <= y; i++)
            {
                if (y % i == 0)
                {
                    ossz  +=  i;
                }
            }

            if (ossz == 2*y)
            {
                Console.WriteLine("Tökéletes szám");
            }
            else
            {
                Console.WriteLine("Nem tökéletes szám");
            }

            //Írj programot, mely beolvassa a hatvány alapját és a kitevőt, és kiírja a
            //hatványértéket!
            Console.Write("Adjon meg a hatvány alapját: ");
            int al = int.Parse(Console.ReadLine());
            Console.Write("Adjon meg a hatvány kitevőjét: ");
            int kit = int.Parse(Console.ReadLine());
            int hat =  1;
            for(int i = 1;i<=kit;i++)
            {
                hat *= al;
            }

            Console.WriteLine(hat);

            //Írj programot, ami csak pozitív számot hajlandó beolvasni.

            Console.Write("Adjon meg egy pozitív egész számot: ");
            
            

            Console.ReadKey();
        }
    }
}
