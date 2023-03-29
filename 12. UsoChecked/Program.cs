namespace UsoChecked
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // checked unchecked
            int numero = int.MaxValue;
            int resultado = unchecked(numero + 20);
            Console.WriteLine(numero);
            Console.WriteLine(resultado);
        }
    }
}