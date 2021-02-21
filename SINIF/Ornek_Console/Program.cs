using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mesaj msj = new Mesaj();
            //msj.metin();

            Kisiler ks = new Kisiler();
            string ads;
            Console.Write("İsim Girin: ");
            ads = Console.ReadLine();
            ks.kisilistesi(ads);

            //ks.kisilistesi("Yasin Bulut");
            //ks.kisilistesi("Muhammet Bulut");

            Console.ReadLine();
        }
    }
}
