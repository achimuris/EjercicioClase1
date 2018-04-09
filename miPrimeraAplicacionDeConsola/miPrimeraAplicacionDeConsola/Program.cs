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

            double nota1=0, nota2=0, nota3=0, nota4=0;
            double promedio = 0;
            
            /*
                int soyUnINT;
                DateTime soyUnDATE;
                bool soyUnBOOL;
                char soyUnCHAR;
                string soyUnSTRING;
            */


           

            Console.WriteLine("Escriba la primera nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escriba la segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escriba la tercer nota: ");
            nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escriba la cuarta nota: ");
            nota4 = double.Parse(Console.ReadLine());


            promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("El promedio es: " + promedio);
            Console.WriteLine();
            Console.WriteLine("Toque una tecla para salir");
            Console.ReadLine();
        }
    }
}
