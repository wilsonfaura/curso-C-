using System;

namespace ambitos_metodos
{
    class Program
    {
        // Variables declaradas con ambito de clase o campos de clase osea afurea de los metodos
        static int numero1 = 5;
        static int numero2 = 7;

        static void Main(string[] args)
        {
            primerMetodo();
            Console.WriteLine(Suma(7,5.3));
        }
        
        static void primerMetodo()
        {
            Console.WriteLine(numero1+numero2);
        }

        // sobrecarga de metodos
        static int Suma(int operador1, int operador2) => operador1 + operador2;
        static int Suma(int numero1, double numero2) => numero1;
        static int Suma(int numero1, int numero2, int numero3, int numero4) => numero1 + numero2;

    }
}

