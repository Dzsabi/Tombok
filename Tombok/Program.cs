using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("1. Első lépések");
            int[] tomb1 = { 10, 20, 30, 40, 50 };
            Console.WriteLine($"Első elem: {tomb1[0]}");
            Console.WriteLine($"Harmadik elem: {tomb1[2]}");
            Console.WriteLine($"Utolsó elem: {tomb1[tomb1.Length - 1]}");
            Console.WriteLine($"A tömb hossza: {tomb1.Length}");
            Console.WriteLine();


            Console.WriteLine("2. Öt szám beolvasása");
            int[] tomb2 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Add meg a {i + 1}. számot: ");
                tomb2[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("A megadott számok: ");
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.Write(tomb2[i]);
                if (i < tomb2.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();


            Console.WriteLine("3. Fordított bejárás");
            int[] tomb3 = { 1, 4, 6 };
            Console.Write("Fordítva: ");
            for (int i = tomb3.Length - 1; i >= 0; i--)
            {
                Console.Write(tomb3[i] + " ");
            }
            Console.WriteLine();
            

            Console.WriteLine("4. Páros vagy páratlan?");
            int[] tomb4 = { 0, -3, 4, 7 };
            foreach (int szam in tomb4)
            {
                if (szam % 2 == 0)
                {
                    Console.WriteLine($"{szam} -> páros");
                }
                else
                {
                    Console.WriteLine($"{szam} -> páratlan");
                }
            }
            Console.WriteLine();


            Console.WriteLine("5. Tízes szorzás");
            int[] tomb5 = { 1, -2, 3 };
            for (int i = 0; i < tomb5.Length; i++)
            {
                tomb5[i] *= 10;
            }
            Console.Write("Új tömb (10-zel szorozva): ");
            foreach (int szam in tomb5)
            {
                Console.Write(szam + " ");
            }
            Console.WriteLine();


            Console.WriteLine("6. Pozitívak száma");
            int[] tomb6 = { -3, 0, 2, 8 };
            int darab = 0;
            for (int i = 0; i < tomb6.Length; i++)
            {
                if (tomb6[i] > 0)
                {
                    darab++;
                }
            }
            Console.WriteLine($"Pozitív számok száma: {darab} darab.");
            Console.WriteLine();


            Console.WriteLine("7. Összeg és átlag");
            int[] tomb7 = { 1, 2, 6 };
            if (tomb7.Length == 0)
            {
                Console.WriteLine("A tömb üres, nem számolható átlag!");
            }
            else
            {
                int osszeg = 0;
                for (int i = 0; i < tomb7.Length; i++)
                {
                    osszeg += tomb7[i];
                }
                double atlag = (double)osszeg / tomb7.Length;
                Console.WriteLine($"Összeg: {osszeg}, Átlag: {atlag}");
            }
            Console.WriteLine();


            Console.WriteLine("8. Minimum és maximum");
            int[] tomb8 = { -7, -2, -9 };
            if (tomb8.Length == 0)
            {
                Console.WriteLine("A tömb üres!");
            }
            else
            {
                int min = tomb8[0];
                int max = tomb8[0];
                for (int i = 1; i < tomb8.Length; i++)
                {
                    if (tomb8[i] < min) min = tomb8[i];
                    if (tomb8[i] > max) max = tomb8[i];
                }
                Console.WriteLine($"Minimum: {min}, Maximum: {max}");
            }
            Console.WriteLine();


            Console.WriteLine("9. Páros indexű elemek");
            int[] tomb9 = { 5, 9, 2, 4, 8 };
            Console.Write("Páros indexűek: ");
            for (int i = 0; i < tomb9.Length; i += 2)
            {
                Console.Write(tomb9[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("10. Keresett szám");
            int[] tomb10 = { 4, 7, 4, 9, 2 };
            Console.Write("Add meg a keresett számot: ");
            int keresett = int.Parse(Console.ReadLine());
            int index = -1;
            for (int i = 0; i < tomb10.Length; i++)
            {
                if (tomb10[i] == keresett)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine($"Az első előfordulás indexe: {index}");

            Console.WriteLine();
            Console.WriteLine("A kilépéshez nyomj meg egy gombot");
            Console.ReadKey();
        }
    }
}