using System;
using System.Collections.Generic;
using System.Text;

namespace Github_Compartido_Grupo_9
{
    class Mostrar_datos
    {
        Console.Write("\nLos juegos que hay guardados son: \n");
            for (int i = 0; i<contador; i++)
            {
                Console.WriteLine("\nTitulo: {0} \nGenero: {1} \nTamaño: {2} \nFecha: {3} KB \nDesarrolladores: {4} \nFranquicia: {5} \nNacionalidad: {6}",
                        arrjuegos[i].juego.titulo, arrjuegos[i].juego.genero, arrjuegos[i].juego.tamaño, arrjuegos[i].juego.fecha, arrdesarrolladores[i].desarrolladores, arrfranquicia[i].franquicia, arrnacionalidad[i].nacionalidad);
                Console.WriteLine("\n");
            }
    }
}
