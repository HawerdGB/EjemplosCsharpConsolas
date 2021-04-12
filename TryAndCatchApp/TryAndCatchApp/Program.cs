using System;
using System.Linq.Expressions;

namespace TryAndCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Porfavor ingresa un numero");
            string valorIngresado = Console.ReadLine();


            int num1 = 5;
            int num2 = 0;
            int resultado;


            try
            {
                resultado = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir entre cero");
            }

           

            try
            {
                int valor = int.Parse(valorIngresado);
            }
            catch (FormatException)
            {
                Console.WriteLine("El formato del valor ingresado es incorrecto");
            }
            catch (OverflowException)
            {
                Console.WriteLine("El numero que ha entrado es muy largo o demasiado corto");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("No ha ingresado ningun valor");
            }
            finally
            {
                Console.WriteLine("Esta frase aparecera pase lo que pase");
            }

            Console.Read();
        }
    }
}
