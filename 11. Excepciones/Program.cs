namespace Excepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int num;
            int intentos = 0;
            Console.WriteLine("Introduce un numero entero entre 0 y 100, por favor");

            do
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                }                
                catch (Exception e) when (e.GetType()!=typeof(FormatException))
                {
                    Console.WriteLine("Ha habido un error. se toma como numero introducido el 0");
                    //Console.WriteLine(e.Message);
                    num = 0;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Has introducido texto");
                    num = 0;
                }

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