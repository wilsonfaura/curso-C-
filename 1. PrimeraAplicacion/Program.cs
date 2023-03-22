using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos al curso de programacion en C#"); //imprime un mensaje en consola

            int edad;
            edad = 28;
            edad += 3;//incremento o decremento
            Console.WriteLine(edad);//Declaracion e iniciacion de una variable

            Console.WriteLine(5 / 2);
            Console.WriteLine(5.0 / 2.0);
            Console.WriteLine(5 * 2 * 3);
            Console.WriteLine(9 % 4);//Uso de operadores aritmetricos

            int edad2 = 19;
            edad2++;//incremento o decremento como sufijo
            Console.WriteLine("Tienes una edad de " + edad2 + " años");//Concatenacion de string e int
            Console.WriteLine($"Tienes una edad de {edad2} años");//Interpolacion de strings
            Console.WriteLine($"Tienes una edad de {--edad2} años");//operador incremento o decremento como prefijo
        }
    }
}