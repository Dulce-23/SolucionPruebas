using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NumerosDentroDeUnArchivo
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader lectura;
            String cadena;
            string[] campos = new string[3];
            char[] delimitador = { '_' };

            string archivo =@"C:\Data\archivo.txt";

            try{

                lectura = File.OpenText(archivo);
                cadena = lectura.ReadLine();
                while (cadena != null)
                {
                        campos = cadena.Split(delimitador);
                        Console.WriteLine(campos[1].Replace("Q","")  ); // Mostramos el campo que contiene los numero y replazamos la Q
                        cadena = lectura.ReadLine();
                 }

                lectura.Close();

               }
            catch (FileNotFoundException fe){
                Console.WriteLine("Error en archivo" + fe.Message);
            }
            catch( Exception e) {
                Console.WriteLine("Error" + e.Message);
            }

            Console.ReadKey();
        }
    }
}
