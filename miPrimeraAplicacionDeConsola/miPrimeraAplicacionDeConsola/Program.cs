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

            double nota = 0;
            double promedio = 0;

            for (int i = 1; i <= 4; i++)
            {
                Console.WriteLine("Escriba la nota " + i.ToString());
                nota = double.Parse(Console.ReadLine());
                promedio += nota;
            }      

            promedio = promedio / 4;
       
            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine();
            Console.WriteLine("Toque una tecla para salir");
            Console.ReadLine();
        }
    }
}
