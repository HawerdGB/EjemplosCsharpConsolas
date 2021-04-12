using System;

namespace OperadoresApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            num3 = -num1;
            Console.WriteLine("El valor negativo de num1 es {0}", num3);
            

            bool haySol = true;
            Console.WriteLine("Hay Sol?{0}", haySol);//respuesta seria true
            Console.WriteLine("Hay Sol?{0}", !haySol);//respuesta seria false

            //Operadores de adicion

            int num = 0;
            num++;

            Console.WriteLine("num es {0}", num);
            Console.WriteLine("num es {0}", num++);
            Console.WriteLine("num es {0}", num);
            //Operadores de sustracion
            num--;
            Console.WriteLine("num es {0}", num);
            Console.WriteLine("num es {0}", --num);
            Console.WriteLine("num es {0}", num);

            //Operadores matematicos
            int resultado = num1 + num2;
            Console.WriteLine("el resultado de " +num1+ " + "+num2+" es igual a "+resultado);
            resultado = num1 - num2;
            Console.WriteLine("el resultado de " + num1 + " - " + num2 + " es igual a " + resultado);
            resultado = num1 * num2;
            Console.WriteLine("el resultado de " + num1 + " * " + num2 + " es igual a " + resultado);
            resultado = num1 / num2;
            Console.WriteLine("el resultado de " + num1 + " / " + num2 + " es igual a " + resultado);

            //Operdador modular
            resultado = num1 % num2;
            Console.WriteLine("el resultado de " + num1 + " % " + num2 + " es igual a " + resultado);

            //Operadores Relacionales
            bool esMenor;
            esMenor = num1 < num2;
            Console.WriteLine("el resultado de " + num1 + " < " + num2 + " es igual a " + esMenor);

            //Operadores de igualdad
            bool esIgual;
            esIgual = num1 == num2;
            Console.WriteLine("el resultado de " + num1 + " == " + num2 + " es igual a " + esIgual);

            esIgual = num1 != num2;
            Console.WriteLine("el resultado de " + num1 + " != " + num2 + " es igual a " + esIgual);

            //Operadores Condicionales
            //Y
            bool esMenorYSoleado;
            esMenorYSoleado = esMenor && haySol;
            Console.WriteLine("el resultado de " + esMenor + " && " + haySol + " es igual a " + esMenorYSoleado);

            //O
            esMenorYSoleado = esMenor || haySol;
            Console.WriteLine("el resultado de " + esMenor + " || " + haySol + " es igual a " + esMenorYSoleado);


            Console.Read();
        }
    }
}
