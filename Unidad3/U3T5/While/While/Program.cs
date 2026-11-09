namespace While
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            bool seguir = true;
            int[] numeros = { 12, 23, 45, 23, 5, 2, 8 };
            int x = 0;
            int mayor = 0;
            while (seguir)
            {
                if (numeros[x] > mayor)
                    mayor = numeros[x];
                if (x == numeros.Length - 1)
                    seguir = false;
                x++;
            }
            Console.WriteLine(mayor);
            Console.WriteLine("Pulsa Enter para salir.");
            Console.ReadLine();
        }
    }
}
