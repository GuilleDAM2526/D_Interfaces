namespace U3T5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("¿Qué día de la semana es hoy?");
            String dia = Console.ReadLine();
            switch (dia) { 
                case "1":
                    Console.WriteLine("Hoy es Lunes");
                    break;
                case "2":
                    Console.WriteLine("Hoy es Martes");
                    break;
                case "3":
                    Console.WriteLine("Hoy es Miércoles");
                    break;
                case "4":
                    Console.WriteLine("Hoy es Jueves");
                    break;
                case "5":
                    Console.WriteLine("Hoy es Viernes");
                    break;
                case "6":
                    Console.WriteLine("Hoy es Sábado");
                    break;
                case "7":
                    Console.WriteLine("Hoy es Domingo");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Escribe un número del 1 al 7.");
                    break;
                

            }

            Console.WriteLine("Pulsa Enter para salir.");
            Console.ReadLine();


        }
    }
}
