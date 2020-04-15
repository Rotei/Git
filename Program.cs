using System;

namespace Grupo_9
{
    class Program
    {

        /*Prepara un programa que permita acceder a las siguientes funciones:
-    Menú de opciones:
-    Añadir un dato
-    Mostrar todos los datos
-    Mostrar datos a partir de un determinado dato de tamaño
-    Búsqueda parcial a partir de una letra o subconjunto de letras (en el caso de encontrar ese fichero deberá mostrar todos los datos que le pertenecen)
-    Mensaje de error, dato introducido incorrecto
-    Salir del menú*/
        struct datos_Generales
        {
            public Datos_juego Juego;
            public string Desarrolladores;
            public string Franquicia;
            public string Nacionalidad;
        }
        struct Datos_juego
        {
            public string titulo;
            public string genero;
            public int tamayo;
            public double fecha;
        }
        static void Main(string[] args)
        {
            int contador = 0;

            string palabra;
            Juego[] arrjuegos = new Juego[5];
            Desarrolladores[] arrdesarolladores = new Desarrolladores[5];
            Franquicia[] arrfranquicia = new Franquicia[5];
            Nacionalidad[] arrnacionalidad = new Nacionalidad[5];

            //MENU
            Console.WriteLine("MENÚ DE DATOS: ");
            Console.WriteLine("Si quiere añadir un dato pulse 1");
            Console.WriteLine("Si quiere mostrar todos los datos pulse 2");
            Console.WriteLine("Si quiere mostrar datos a partir de un determinado dato de tamaño pulse 3");
            Console.WriteLine("Si búsqueda parcial a partir de una letra o subconjunto de letras  pulse 4");
            Console.WriteLine("Si quiere salir de programa pulse 5");
            int menu = Convert.ToInt32(Console.ReadLine());


            switch (menu)

            {
                //AÑADIR DATO
                case 1:
                    {
                        Agregar();
                        break;
                    }
                //MOSTRAR DATOS
                case 2:
                    {
                        break;
                    }
                //MOSTRAR TAMAÑO
                case 3:
                    {
                        break;
                    }
                //BUSQUEDA PARCIAL
                case 4:
                    {
                        break;
                    }
                //SALIR
                case 5:
                    {
                        Console.WriteLine("Saliendo de la sesión");
                        break;
                    }

                default:
                    {
                        Console.WriteLine(" \n No te entiendo, has dado un valor que no coincide con el menú ");
                        break;
                    }
            }
        } 
    }
}
