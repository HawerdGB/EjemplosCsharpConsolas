using System;

namespace Clases__BasicoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea un objeto desde mi clase, una instancia de humano
            Humano juan = new Humano();
           
            //llamando un metodo de la clase
           

            Humano Walter = new Humano("Walter", "Gutierrez", "Verdes");

            Humano hawerd = new Humano("Hawerd","Gutierrez","Azules", 45);
          
            hawerd.presentarme();
            Walter.presentarme();
            juan.presentarme();
            Console.Read();
        }
    }
}
