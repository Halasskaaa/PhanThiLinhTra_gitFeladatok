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

        static void Main(string[] args)
        {
            
        }
    }
}
