namespace exercício1DIA24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número : ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("Número PAR.");
            }
            else
            {
                Console.WriteLine("Número impar.");
            }
        }

    }
}