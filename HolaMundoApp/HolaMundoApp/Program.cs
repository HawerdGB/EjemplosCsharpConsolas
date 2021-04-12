using System;

namespace HolaMundoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Porpiedades que cambia el color de la consola
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            //Metodos de System.Console
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Mi nombre es Hawerd Gutierrez"); 
            Console.Read();
        }
    }
}
