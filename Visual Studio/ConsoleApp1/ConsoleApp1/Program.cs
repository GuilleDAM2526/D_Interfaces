using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Aparisi, Guillermo");

            string versionDotNet = RuntimeInformation.FrameworkDescription;
            Console.WriteLine("Versión de .NET en ejecución: " + versionDotNet);
            
            string versionVS = Environment.GetEnvironmentVariable("VisualStudioVersion");
            Console.WriteLine("Versión interna de Visual Studio detectada: " + versionVS);
        }
    }
}
