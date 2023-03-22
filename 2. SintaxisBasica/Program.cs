using System;

namespace SintaxisBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            int edadPersona1;
            int edadPersona2;
            int edadPersona3;
            int edadPersona4;

            edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;//Iniciacion de varias variables
            Console.WriteLine(edadPersona4);

            var edadPersona5 = 15;//Iniciacion inplicita usando var
            Console.WriteLine(edadPersona5);

            //casting o conversion explicita distintos tipos de variables 
            double temperatura = 34.5;//de double a int explicita pero de int a double se puede implicita
            int temperaturaMadrid;
            temperaturaMadrid = (int)temperatura;
            Console.WriteLine(temperaturaMadrid);

            //conversion inplicita, mismo tipo, distinta longitud variables 
            int habitantesCiudad = 10000000;
            long habitantesCiudad2018 = habitantesCiudad;
            Console.WriteLine(habitantesCiudad2018);

            float pesoMaterial = 5.78F;
            double pesoMaterialPrec = pesoMaterial;
            Console.WriteLine(pesoMaterialPrec);

            //conversion de string a int, double por medio del metodo Parse
            Console.WriteLine("Introduce el primer numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado es: {num1 + num2}");
        }
    }
}
