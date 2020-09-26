using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===[ El siguiente programa realiza la suma de los numeros del 1 al 10 ] ===\n");
           
            int suma = 0;

            for (int i = 0; i <= 10; i++)
            {

                suma = i *(i+1)/2;
            }

            Console.WriteLine("---> La sumatoria de los numeros es =  " + suma);

            Console.ReadKey();



        }
    }
}
