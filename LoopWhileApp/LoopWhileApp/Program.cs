using System;

namespace LoopWhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            string textoIngresado = "";
            
            while(textoIngresado.Equals(""))
            {
                Console.WriteLine("Porfavor Presione enter para seguir ingresando"+
                    ". Para finalizar ingrese otro valor");
                textoIngresado = Console.ReadLine();
                contador++;
                Console.WriteLine("Numeros ingresados:{0}", contador);
            }
            Console.Read();
        }
    }
}
