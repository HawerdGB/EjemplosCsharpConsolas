using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Entrada="";
            Console.WriteLine("Escibe tu nombre");
            Entrada=Console.ReadLine();
            Console.WriteLine("Hola {0}, como estas? ", Entrada);
        }
    }
}
