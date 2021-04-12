using System;


namespace PropiedadesApp
{
    class Caja
    {
        //miembros variables
        private int largo;
        private int alto;
       // private int ancho;
        private int volumen;

        public Caja(int largo, int alto, int ancho)
        {
            this.largo =  largo;
            this.alto = alto;
            this.Ancho = ancho;

        }

        public int Volumen {
                            set {
                volumen = value;
                                }
            get
            {
                return Alto * Ancho * Largo;

            }
        }

        //Manera sin tener que utilizar las variables
        //propiedad auto-implementada
        public int Ancho { get; set; }

        //podemos manipular condicionando los get y set
        //como en el sgte ejemplo cuando se entra un numero negativo
        public int Alto {
            get 
            { return alto; }
            set
            {
                if (value < 0) value = -value;//o manejando el error: throw new Exception("El numero debe ser positivo")
                alto = value;
            }
        
        }


        //Manera utilizando variable. La linea anterior es lo mismo pero resumido
    /*    public int Largo// Se escribe con la primera mayuscula
        {
            get{
                return largo;
            }
            set {
                largo = value;
            }
        }*/

        //Otra manera de escribir lo de arriba 

            public int Largo
        {
            get => largo;
            set => largo = value;
        }


        public void MuestraInfo()
        {
            Console.WriteLine("El largo es {0}. La altura es {1}. El ancho es {2}, El volumen es {3}"
                , largo, Alto, Ancho, volumen = Alto * Ancho * largo);

        }
    }
}
