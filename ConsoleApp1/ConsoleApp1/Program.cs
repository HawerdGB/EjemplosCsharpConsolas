using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  EscribeAlgo();
              EscibeAlgoEspecifico("Soy un argumento y sali de un metodo");
              Console.Read();*/

            Console.WriteLine(Sumar(10, 15));
            Console.Read();

        }

        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo sali de un metodo");
           
        }

        public static void EscibeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
        }

        public static int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
