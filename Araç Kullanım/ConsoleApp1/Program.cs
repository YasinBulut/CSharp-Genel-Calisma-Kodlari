using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        Random rastgele = new Random(); // şu şekilde random degişkenini tanıyoruz
        İnt salla = rastgele.Next(3, 8);
        static void Main(string[] args)
        {
            int salla;
            int[] dizilerim = new int[5];
            int a = 0;

            for (int i = 0; i < 5; i++)
            {
                salla = rastgele.Next(1, 6);


                for (int j = 0; j < dizilerim.Length; j++)
                {
                    if (dizilerim[j] == salla)
                    {
                        a++;
                        i--;
                        break;

                    }

                }
                if (a == 0)
                {
                    dizilerim[i] = salla;
                }
                a = 0;


            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dizilerim[i]);
            }

            Console.ReadLine();
        }
    }
}
