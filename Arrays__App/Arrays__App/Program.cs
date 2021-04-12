using System;

namespace Arrays__App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = {3,4,7,5,9,8,4,5 };

            for(int i = 0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
           // Console.ReadLine();

            //ejemplo array entrando dato y luego leyendolo

            int[] array2 = new int[10];

            for(int i = 0; i< array2.Length; i++)
            {
                Console.WriteLine("escribe un numero en la pos " + i);
                int num = Convert.ToInt32(Console.ReadLine());
                array2[i] = num;

            }

            Console.WriteLine("Mostrar datos");
            for(int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }
            Console.ReadLine();

        }
    }
}
