namespace U3T3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre = "Caiman";
            var comida = "hamburguesas";
            int edad1 = 5;
            var edad2 = 7; // implícito
            DateTime ahora = DateTime.Now;

            Console.WriteLine("¡Soy un caiman!");
            Console.WriteLine("Me llaman " + nombre);
            Console.WriteLine("y me gusta comer " + comida);
            Console.WriteLine("vamos a sumar 23 + 44: " + (23 + 44));
            Console.WriteLine("La edad del caiman es: " + edad1);
            Console.WriteLine("La edad del caiman 2 años despues será: " + edad2); //concatenación intuitiva: facil, pero induce a errores
            ////////////////
            Console.WriteLine("Hola. Me llamo {0} y tengo {1} años.", nombre, edad1); // Formato de cadena con parámetros. Está anticuado
            Console.WriteLine("Si dibido {1, -12} entre {0,-5} el resultado es: {2,4:#,##0.00}", edad1, edad2, (double)edad2 / edad1); // Formato de cadena con interpolación, no mirar por ahora
            ////////////////
            ///
            Console.WriteLine($"Hola. Me llamo {nombre} y tengo {edad1} años"); // Mejor método para usar en ejemplos simples. Recomendado!! Se puede dar fomato como en el anterior
            ////////////////
            Console.WriteLine("Hoy es: {0:G}", ahora);                   // Formato de fecha y hora general
            Console.WriteLine("Hoy es: {0:dd/MM/yy}", DateTime.Now);            // Formato de fecha corta
            Console.WriteLine("Hoy es: {0:ddd, dd/MMM/yyyy}", DateTime.Now);    // Formato de fecha larga (dia abreviado)
            Console.WriteLine("Hoy es: {0:ddddddddd dd/MMM/yyyy}", ahora);    // Formato de fecha larga (dia completo, máximo miercoles)
                                                                              ////////////////
            Console.WriteLine($"Hoy es: {ahora:G}");                   // Formato de fecha y hora general
            Console.WriteLine($"Hoy es: {ahora:dd/MM/yy}");            // Formato de fecha corta
            Console.WriteLine($"Hoy es: {DateTime.Now:ddd, dd/MMM/yyyy}");    // Formato de fecha larga (dia abreviado)
            Console.WriteLine($"Hoy es: {ahora:ddddddddd dd/MMM/yyyy}");    // Formato de fecha larga (dia completo, máximo miercoles)


            // Usando un estándar:
            Console.WriteLine($"Fecha de inicio: {ahora:D}");
            // Salida: Fecha de inicio: jueves, 15 de octubre de 2026
            // Usando un formato personalizado:
            Console.WriteLine($"Registro: {ahora:dd/MM/yyyy a las HH:mm:ss}");
            // Salida: Registro: 15/10/2026 a las 14:30:05
            
            
            string s = "Esta es una cadena larga de más de 20 caracteres";
            string s1 = "Cadena más corta";
            Console.WriteLine("--------------------");
            Console.WriteLine("{0,200}", s);            // Justificado a la derecha con 200 caracteres de ancho
            Console.WriteLine("{0,-200}", s1);          // Justificado a la izquierda con 200 caracteres de ancho
            Console.WriteLine("--------------------");



            string cadena;
            cadena = Console.ReadLine();
        }
    }
}
