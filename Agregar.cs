using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo_9
{
   public class Agregar
    {
       public void Lanzar()
        {
            if (contador < 5)
            {
                Console.WriteLine("Escribe el título del videojuego");
                arrjuegos[contador].Juego.titulo = Convert.ToString(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Escribe el desarrollador del videojuego");
                arrdesarolladores[contador].desarrollador = Convert.ToString(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Escribe la franquicia del videojuego");
                arrfranquicia[contador].franquicia = Convert.ToString(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Escribe la nacionalidad del videojuego");
                arrnacionalidad[contador].nacionalidad = Convert.ToString(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Escribe el género del videojuego");
                arrjuegos[contador].Juego.genero = Convert.ToString(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Escribe el tamaño del videojuego");
                arrjuegos[contador].Juego.tamaño = Convert.ToString(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Escribe el fecha del videojuego");
                arrjuegos[contador].Juego.fecha = Convert.ToString(Console.ReadLine());
                Console.WriteLine();
                contador++;
                Console.WriteLine("Juego añadido con éxito");

            }
            else
            {
                Console.WriteLine("No puedes añadir más juegos");
            }

        }

    }
}
