using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git
{
    internal class Program
    {
        static Random rnd = new Random();
        public static void F01(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = rnd.Next(1,51);
            }
        }
        public static int F02(int[] szamok)
        {
            int count = 0;
            for (int i = 0;i < szamok.Length;i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        public static double F03(int[] szamok)
        {
            double atlag = 0;
            for (int i = 0; i < szamok.Length; i++)
            {
                atlag += szamok[i];
            }
            atlag /= szamok.Length;
            return atlag;
        }
        public static int[] F04(int[] szamok)
        {
            int[] paratlanok = new int[10];
            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    szamok[i] += 1;
                }
                paratlanok[i] = szamok[i];
            }
            return paratlanok;
        }
        public static void F05(int[] szamok)
        {
            Console.WriteLine($"Ennyi db pozitív szám van a tömbben: {F02(szamok)}");
            Console.WriteLine($"A tömb elemeinek átlaga: {F03(szamok):0.####}");
            Console.WriteLine("A tömbből alkotott páratlan számok: ");
            int[] paratlanok = F04(szamok);

            foreach (int szam in paratlanok)
            {
                Console.Write(szam + ", ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            
        }
    }
}
