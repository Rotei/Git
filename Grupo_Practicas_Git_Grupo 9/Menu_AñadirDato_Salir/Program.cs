 using System
{
static void Main()
{ 
//MENU
 Console.WriteLine("MENÚ DE DATOS: ");
 Console.WriteLine("Si quiere añadir un dato pulse 1");
 Console.WriteLine("Si quiere mostrar todos los datos pulse 2");
 Console.WriteLine("Si quiere mostrar datos a partir de un determinado dato de tamaño pulse 3");
 Console.WriteLine("Si búsqueda parcial a partir de una letra o subconjunto de letras  pulse 4");
 Console.WriteLine("Si quiere salir de programa pulse 5");
 i = Convert.ToInt32(Console.ReadLine());
 
 //AÑADIR DATO
 if (i == 1)
 {
 Console.WriteLine("Escribe el título del videojuego");
 arrtitulo[cantidad].titulo = Convert.ToString(Console.ReadLine());
 Console.WriteLine();

 Console.WriteLine("Escribe el desarrollador del videojuego");
 arrdesarollador[cantidad].desarrollador = Convert.ToString(Console.ReadLine());
 Console.WriteLine();

 Console.WriteLine("Escribe la franquicia del videojuego");
 arrfranquicia[cantidad].franquicia = Convert.ToString(Console.ReadLine());
 Console.WriteLine();

 Console.WriteLine("Escribe la nacionalidad del videojuego");
 arrnacionalidad[cantidad].nacionalidad = Convert.ToString(Console.ReadLine());
 Console.WriteLine();

 Console.WriteLine("Escribe el género del videojuego");
 arrjuego[cantidad].genero = Convert.ToString(Console.ReadLine());
 Console.WriteLine();

 Console.WriteLine("Escribe el tamaño del videojuego");
 arrjuego[cantidad].tamaño = Convert.ToString(Console.ReadLine());
 Console.WriteLine();

 Console.WriteLine("Escribe el fecha del videojuego");
 arrjuego[cantidad].fecha = Convert.ToString(Console.ReadLine());
 Console.WriteLine();
 cantidad++;
 Console.WriteLine("Juego añadido con éxito");
}

// SALIR DEL MENU
else
 {
 Console.WriteLine("Capacidad máxima");
 i = 5;
}