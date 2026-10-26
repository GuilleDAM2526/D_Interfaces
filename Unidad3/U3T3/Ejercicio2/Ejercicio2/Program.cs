using System.Timers;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String edad;
            Console.WriteLine("¿como se llama el caiman? ");
            nombre = Console.ReadLine();
            Console.WriteLine("¿cuantos años tiene el caiman? ");
                        edad = Console.ReadLine(); 
            Console.WriteLine("El caiman se llama {0} y tiene {1} años.", nombre, edad);

        }
    }
}
