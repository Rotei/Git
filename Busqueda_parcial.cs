using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo_9
{
    class Busqueda_parcial
    {
        public void Lanzar()
      {
             public string letra = Console.ReadLine();
         Console.WriteLine("Escribe una letra : ");
           public string buscar = Console.ReadLine();
         do
         {
            Console.WriteLine("Lo siento, no has escrito nada");
            Console.WriteLine("Vuelve a introducir una letra");
            buscar = Console.ReadLine();
         }while (buscar == "");
            Console.WriteLine("Ahora le mostraré los datos revelados con su búsqueda: {0} ", buscar);
         for (int i = 0; i<contador; i++)
			{
                if(arrjuego[i].juego.titulo.ToLower().Contains(looking.ToLower()))
                   {
                     Console.WriteLine("Titulo : {0} ", arrjuego[contador].juego.titulo);
                     Console.WriteLine("Genero : {0} ", arrjuego[contador].juego.genero);
                     Console.WriteLine("Tamaño : {0} ", arrjuego[contador].juego.tamayo);
                     Console.WriteLine("Fecha : {0} ", arrjuego[contador].juego.fecha

                   }
			}
      break;
     }
          
   }
}
