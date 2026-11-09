namespace U3T7
{
    internal class Program
    {
        // Clase que representa una cuenta bancaria.
        public class CuentaBancaria
        {
            // Campo privado que guarda el saldo de la cuenta.
            private decimal _saldo;

            // Propiedad para consultar y modificar el saldo.
            public decimal Saldo
            {
                // Devuelve el valor actual del saldo.
                get { return _saldo; }
                // Asigna un nuevo valor al saldo si es distinto del actual.
                set
                {
                    if (_saldo != value)
                        _saldo = value;
                }
            }

            // Propiedad automática para guardar el nombre del titular.
            // Si no se asigna otro valor, comienza como "Sin asignar".
            public string Titular { get; set; } = "Sin asignar";

        }

        // Método principal: aquí comienza la ejecución del programa.
        static void Main(string[] args)
        {
            // Crea una nueva cuenta bancaria.
            CuentaBancaria cta = new CuentaBancaria();

            // Asigna el nombre del titular.
            cta.Titular = "Paul";

            // Asigna un valor al saldo.
            cta.Saldo = -1000;

            // Muestra el titular y el saldo en la consola.
            Console.WriteLine($"{cta.Titular}: {cta.Saldo}");
        }
    }
}
