using System;

namespace constantes
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Declaracion e iniciacion de constantes
            const int VALOR = 2;
            const int VALOR2 = 56;
            Console.WriteLine("El valor de la constante es: {0}", VALOR, VALOR2);

            //Uso de constantes
            const double PI = 3.1416;
            Console.WriteLine("Introduce a medida del radio");
            double radio = double.Parse(Console.ReadLine());

            //Area usando constantes y operadores aritmeticos          
            double area = radio * radio * PI;
            Console.WriteLine($"El area del circulo es {area}");

            // Area usando constantes y el metodo Pow de la clase Math
            double area1 = Math.Pow(radio, 2)*PI;
            Console.WriteLine($"El area del circulo es {area1}");

        }
    }
}
