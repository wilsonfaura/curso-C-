using System;

namespace Practica_Metodos
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Llamado a metodos fuera del metodo principal Main
            mensajeEnPantalla();
            sumaNumeros(4,3);
            Console.WriteLine("La division de los numeros es " + divideNumeros(18,7));
            Console.WriteLine("La division de los numeros es " + divideNum(300, 7));
            Console.WriteLine("Mensaje desde el Main");
        }

       //metodo tipo void no devuelve valores, sin parametros
        static void mensajeEnPantalla()
        {
            Console.WriteLine("Mensaje desde el metodo mensaje en pantalla");
        }

        //metodo tipo void no devuelve valores, recibe parametros
        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine($"La suma de los numeros es: {num1+num2}");
        }

        //metodo tipo return devuelve valores, recibe parametros
        static double divideNumeros(double num1, int num2)
        {
            return num1 / num2;
        }

        //simplificacion de metodo cuando solo tiene una linea, sustituyendo las llaves por => y se prescinde del return
        static double divideNum(double num1, int num2) => num1 / num2;
    }
}
