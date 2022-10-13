using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet =0,sayi;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Değeri Giriniz.");
                sayi = Convert.ToInt32(Console.ReadLine());
                if ((sayi > 100) && (sayi < 200))
                    adet++;
            } 
            Console.WriteLine(adet);
            Console.ReadKey();
        }
    }
}
 
                







































































































































































































