using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            for (sayi = 0; sayi <= 99; sayi++)
            {


                if ((sayi % 2 == 0) && (sayi % 4 == 0))
                {
                    Console.Write(sayi + " ");
                    Console.WriteLine("2 ve 4 e bölünebilir");
                }
                else if ((sayi % 2 == 0))
                {
                    Console.Write(sayi + " ");
                    Console.WriteLine("2 ye bölünebilir");

                }
                else if (sayi % 3 == 0)
                {
                    Console.Write(sayi + " ");
                    Console.WriteLine("3 e bölünebilir");

                }

            }
            Console.ReadLine();
        }

    }

}
    

