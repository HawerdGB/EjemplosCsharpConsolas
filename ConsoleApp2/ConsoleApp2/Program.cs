using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La suma de estos 2 numeros es: "+ Calcular());
            Console.Read();
        }

        public static int Calcular()
        {
            Console.WriteLine("Entre un numero");
            string numero1Input = Console.ReadLine();
            Console.WriteLine("Entre otro numero");
            string numero2Input = Console.ReadLine();

            int num1 = int.Parse(numero1Input);
            int num2 = int.Parse(numero2Input);

            int resultado = num1 + num2;
            return resultado;
        }
    }
}
