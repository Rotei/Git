using System;
using System.Collections.Generic;
using System.Text;

namespace Github_Compartido_Grupo_9
{
    class Bucar_por_tamaño
    {
        Console.WriteLine("\nDime un tamaño que quieres que busque y te mostrare los datos del juego con ese tamaño");
            string palabra = Console.ReadLine();
            for (int i = 0; i<contador; i++)
            {
                if (palabra == arrjuegos[i].juego.tamaño)
                {
                    Console.WriteLine("\nTitulo: {0} \nGenero: {1} \nTamaño: {2} \nFecha: {3} KB \nDesarrolladores: {4} \nFranquicia: {5} \nNacionalidad: {6}",
                        arrjuegos[i].juego.titulo, arrjuegos[i].juego.genero, arrjuegos[i].juego.tamaño, arrjuegos[i].juego.fecha, arrdesarrolladores[i].desarrolladores, arrfranquicia[i].franquicia, arrnacionalidad[i].nacionalidad);
                }
}
    }
}
