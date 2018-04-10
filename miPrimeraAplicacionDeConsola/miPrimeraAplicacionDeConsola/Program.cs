using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace miPrimeraAplicacionDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un caracter: ");

            char a = Console.Read().ToString()[0];

            if (char.IsDigit(a))
            {
                Console.WriteLine("Ingresaste un número");
            }
            else
            {
                if (char.IsLetter(a)) {
                    if (char.IsLower(a))
                    {
                        Console.WriteLine("Es una letra en minus");
                    }
                    else
                    {
                        Console.WriteLine("Es una letra en mayus");

                    }

                }
                else
                {
                    Console.WriteLine("No es ni letra ni número");
                }
            }
            

       
            
            Console.WriteLine();
            Console.WriteLine("Toque una tecla para salir");
            Console.ReadKey();
        }
    }
}
