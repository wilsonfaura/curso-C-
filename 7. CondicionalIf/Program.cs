using System;

namespace CondicionalIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string carnet = "no";
            Console.WriteLine("Vamos a evaluar si eres mayor de edad");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Tienes licencia de conduccion?");
                carnet = Console.ReadLine();
            }

            if (edad >= 18 && carnet == "si")
            {
                Console.WriteLine("Puedes conducir porque eres mayor de edad y tienes licencia de conduccion");
            }
            else
            {
                Console.WriteLine("Lo siento pero no puedes conducir vehiculos");
            }
            
            Console.WriteLine("Aqui termina el programa");

            //--------------------------------------------------------------------------------------------------------
            
            Console.WriteLine("Vamos a evaluar si eres mayor de edad");
            Console.WriteLine("Introduce tu edad, por favor");
            int edad2 = int.Parse(Console.ReadLine());

            if (edad2 < 18)
            {
                Console.WriteLine("Lo siento pero no puedes conducir vehiculos");
            }
            else
            {
                Console.WriteLine("Tienes licencia de conduccion?");
                string carnet2 = Console.ReadLine();
                int compara = String.Compare(carnet2, "si", true);


                if (compara == 0)
                {
                    Console.WriteLine("Puedes conducir porque eres mayor de edad y tienes licencia de conduccion");
                }
                else
                {
                    Console.WriteLine("Lo siento pero no puedes conducir vehiculos");
                }
            }                             

            Console.WriteLine("Aqui termina el programa");

            //------------------------------------------------------------------------------------------------

            Console.WriteLine("Introduce la nota del primer parcial");
            double nota1=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota del segundo parcial");
            double nota2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota del tercer parcial");
            double nota3 = Int32.Parse(Console.ReadLine());

            if (nota1>=5 || nota2>=5 || nota2>=5)
            {
                Console.WriteLine("La nota media es : " + (nota1 + nota2 + nota3) / 3);
            }
            else
            {
                Console.WriteLine("Vuelve en septiembre");
            }

            //----------------------------------------------------------------------------------------

            Console.WriteLine("Introduce tu edad");
            int edad3=Int32.Parse(Console.ReadLine());

            if (edad3 < 18) Console.WriteLine("Eres un niño");
            else if (edad3 < 30) Console.WriteLine("Eres joven");
            else if (edad3 < 60) Console.WriteLine("Eres maduro");
            else Console.WriteLine("Debes cuidarte");
        }
    }
}