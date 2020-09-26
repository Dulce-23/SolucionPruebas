using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("===[ El siguiente programa calcula el promedio de 3 numeros ] ===\n");
            int num1, num2, num3, suma, promedio=0;

            Console.WriteLine(" -->Ingrese primer numero");
            num1= int.Parse(Console.ReadLine());

            Console.WriteLine(" -->Ingrese segungo numero");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" -->Ingrese tercer numero");
            num3 = int.Parse(Console.ReadLine());

            suma = num1 + num2 + num3;
            promedio = suma / 3;

            Console.WriteLine("El promedio basado en los numeros ingresados es =  " + promedio);

            Console.ReadKey();
        }
    }
}
