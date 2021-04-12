using System;

namespace FibonaciApp
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine(numFibo());
            Console.Read();
           
        }

        public static string numFibo()
        {
            Console.WriteLine("Escriba el numero de inicio de esta serie: ");
            int number = int.Parse(Console.ReadLine());
            int n1 = number - 1;
            int n2 = number;
            string nSerie = (n1 + " " + n2 + " ");
            for (int i = 0; i < 3; ++i)
            {
                int n3 = n1 + n2;
                nSerie = nSerie + (n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            return nSerie;
        }
    }
}
