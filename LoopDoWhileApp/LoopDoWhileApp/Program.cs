using System;
using System.Runtime.ConstrainedExecution;

namespace LoopDoWhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // int contador = 0;//si pusiera el contador  igual a 15, me imprimer el 15 solamente
            int largoDeTexto = 0;
            string textoCompleto = "";
            

            do
            {
                Console.WriteLine("Ingresa el nombre de un amigo");
                string nombreAmigo = Console.ReadLine();
                int largoActual = nombreAmigo.Length;
                largoDeTexto += largoActual;
                textoCompleto += nombreAmigo;
            } while (largoDeTexto < 20);
            Console.WriteLine("Gracias, eso es todo" + textoCompleto);
            Console.Read();
        }
    }
}
