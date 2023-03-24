namespace BucleDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 10;

            do
            {
                Console.WriteLine("Impresion " + z);
                z++;
            } while (z < 15);

            //--------------------------------------------------------

            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int num;
            int intentos = 0;
            Console.WriteLine("Introduce un numero entero entre 0 y 100, por favor");

            do
            {
                num = int.Parse(Console.ReadLine());
                if (aleatorio < num)
                {
                    Console.WriteLine("El numero es menor");
                }
                if (aleatorio > num)
                {
                    Console.WriteLine("El numero es mayor");
                }
                intentos++;
            } while (aleatorio != num);

            Console.WriteLine($"Correcto acertaste, lo has logrado en {intentos} intentos ");

        }
    }
}