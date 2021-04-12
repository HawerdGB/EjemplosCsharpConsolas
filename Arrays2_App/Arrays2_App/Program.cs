using System;

namespace Arrays2_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sumar total del array y l amedia, multiplicar el array por un numero
            //ordenar el array.
            //Max y Min de un array

            int[] valores = { 10,40,30,20};

            Array.Sort(valores);
            int min = valores[0];
            int max = valores[valores.Length - 1];
            int suma = 0;

            for(int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
                suma += valores[i];

            }

            double media = (double)(suma / valores.Length);
            Console.WriteLine("El valor minimo es " + min);
            Console.WriteLine("El valor maximo es " + max);
            Console.WriteLine("La suma de todos los valores es " + suma);
            Console.WriteLine("La media es " + media);
            

            Console.ReadLine();
        }
    }
}
//Otra  forma de sacar el max o min es recorriendo el array y comparando el numero
/*
 int maximo = valores[0];
 int minimo = valores[0];

    for(int i = 0; i < valores.Length; i++)
    {
       if (valores[i] > maximo){
                maximo = valores[i]
                    }
       if (valores[i] < minimo){
                miniimo = valores[i]
                        }
    }
     */
