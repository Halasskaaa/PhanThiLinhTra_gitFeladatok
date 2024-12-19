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

        static void Main(string[] args)
        {
            
        }
    }
}
