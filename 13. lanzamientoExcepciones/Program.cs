namespace lanzamientoExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce numero de mes");
            int NumeroMes = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(NombreDelMes(NumeroMes));
            }catch(Exception e)
            {
                Console.WriteLine("Mensaje de la excepcion: " + e.Message);
            }
            Console.WriteLine("Aqui continuaria la ejecucion del resto del programa");
        }

        public static string NombreDelMes(int mes)
        {
            switch(mes)
            {
                case 1:
                    return "enero";

                case 2:
                    return "febrero";

                case 3:
                    return "marzo";

                case 4:
                    return "abril";

                case 5:
                    return "mayo";

                case 6:
                    return "junio";

                case 7:
                    return "julio";

                case 8:
                    return "agosto";

                case 9:
                    return "septiembre";

                case 10:
                    return "octubre";

                case 11:
                    return "noviembre";

                case 12:
                    return "diciembre";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}