using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Clases__BasicoApp
{
    class Humano
    {
        // Miembro variable 
        private string primerNombre;
        private string primerApellido;
        private string colorOjos;
        private int edad;

        //constructor no parametrizado (por defecto)
        public Humano()
        {
            Console.WriteLine("Hola, no tengo memoria , no se de mi");
        }


        //constructor parametrizado
        public Humano(string _primerNombre, string primerApellido, string colorOjos, int edad)
        {
            primerNombre = _primerNombre;
            //o utilizando this.
            this.primerApellido = primerApellido;
            this.colorOjos = colorOjos;
            this.edad = edad;
        }
        public Humano(string _primerNombre, string primerApellido, string colorOjos)
        {
            primerNombre = _primerNombre;
            this.primerApellido = primerApellido;
            this.colorOjos = colorOjos;

        }



        // miembro metodo
        public void presentarme()
        {
            if (primerNombre != null || primerApellido != null)
            { 
                if (edad != 0)
                    Console.WriteLine("Hola, me llamo {0} {1}, tengo los ojos {2} y mi edad es {3}", primerNombre, primerApellido, colorOjos, edad);
                else
                    Console.WriteLine("Hola, me llamo {0} {1}, tengo los ojos {2}", primerNombre, primerApellido, colorOjos);

            }
         

        }
    }
}