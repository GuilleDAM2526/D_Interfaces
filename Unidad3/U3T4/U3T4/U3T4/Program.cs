using System.Text;

namespace U3T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Caráter o texto:
            char c = 'a';
            string palabra = "palabra";

            Console.WriteLine($"string: {palabra}.");
            Console.WriteLine($"char: {c}.");

            //Numérico enteros con signo:
            sbyte n = 100;      //El valor máximo de sbyte en C# es 127. Su rango completo es de −128 a 127.
            short nu = 32_000;  //El valor máximo de short en C# es 32 767. Su rango va de −32 768 a 32 767.
            int num = 1_123_000_000;      //El valor máximo de int en C# es 2 147 483 647. Su rango va de −2 147 483 648 a 2 147 483 647.
            long numero = 0x5F;

            Console.WriteLine($"sbyte n: {n}. Su rango completo es de −128 a 127.");
            Console.WriteLine($"short nu: {nu}. Su rango va de −32 768 a 32 767.");
            Console.WriteLine($"int num: {num}. Su rango va de −2 147 483 648 a 2 147 483 647.");
            Console.WriteLine($"long numero: {numero}");
            // sin signo:
            //byte
            //ushort
            //uint
            //ulong

            // Real:
            float f = 2.2F;     // 32bits, como el int
            double d = 12.9;     // 64 bits
            decimal D = 10.54898796m;  // 128 bits . especificar con 'm' que es un decimal

            //Moneda(C - currency): Añade el símbolo de la moneda y dos decimales.
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine($"El precio es {f:C}");
            Console.WriteLine($"El precio es {d:C}");
            Console.WriteLine($"El precio es {D:C}");

            double resultado = d / f;
            Console.WriteLine($"{resultado}");






        }
    }
}
