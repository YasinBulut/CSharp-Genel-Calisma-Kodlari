using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metot_Yapici
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constructor
            //Ogrenci ogr = new Ogrenci();
            string blg;
            //Console.Write("Ad-Kulup:");
            //blg = Console.ReadLine();
            //Ogrenci ogr = new Ogrenci("Durum: "+blg);

            Kimlik kml = new Kimlik();
            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CİNSİYET);


            Console.ReadLine();
        }
    }
}
