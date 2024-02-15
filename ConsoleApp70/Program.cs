using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace klavyedengirilenortalamayagorebelge
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Lütfen ortalamanızı giriniz");
            int ortalama = Int32.Parse(Console.ReadLine());

            if (ortalama >= 85)
            {
                Console.WriteLine("Takdir Belgesi");
            }
            else if (ortalama >= 70)
            {
                Console.WriteLine("Teşekkür Belgesi");
            }
            else
            {
                Console.WriteLine("Hiçbir belge alamadınız");
            }

            Console.ReadLine();
        }
    }
}
