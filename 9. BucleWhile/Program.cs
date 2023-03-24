using System;

namespace BucleWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" deseas entrar en el bucle while?");
            string respuesta = Console.ReadLine();

            while(respuesta != "no")
            {
                Console.WriteLine("Estas ejecutando el interior del bucle");
                Console.WriteLine("Introduce tu nombre por favor");
                string nombre = Console.ReadLine();
                Console.WriteLine($"{nombre} saldras del bucle cuando respondas no a la pregunta");
                Console.WriteLine("Deseas repetir otra vez?");
                respuesta = Console.ReadLine();
            }
            Console.WriteLine("has salido del bucle");
            //-------------------------------------------------------------

            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int num=101;
            int intentos = 0;
            Console.WriteLine("Introduce un numero entero entre 0 y 100, por favor");

            while (aleatorio != num)
            {                
                num = int.Parse(Console.ReadLine());
                if (aleatorio < num)
                {
                    Console.WriteLine("El numero es menor");
                }
                if(aleatorio > num)
                {
                    Console.WriteLine("El numero es mayor");
                }
                intentos++;
            }

            Console.WriteLine($"Correcto acertaste, lo has logrado en {intentos} intentos ");
        }
    }
}