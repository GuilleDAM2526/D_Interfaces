using System;
using System.Collections.Generic;
using System.Text;

namespace U3T7
// "public" permite acceder desde cualquier parte del programa.
public class Persona
{
    // Public: se puede consultar y modificar desde fuera de la clase.
    public string Nombre { get; set; }

    // Private: solo se puede usar dentro de la clase Persona.
    private int _edad;

    // Protected: se puede usar dentro de Persona y de sus clases derivadas.
    protected string Ciudad;

    // Internal: se puede usar desde cualquier clase del mismo proyecto o ensamblado.
    internal string Correo;

    // Constructor público para crear objetos Persona.
    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        _edad = edad;
        Ciudad = "Madrid";
        Correo = "persona@ejemplo.com";
    }

    // Método público: se puede llamar desde fuera de la clase.
    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {_edad}");
        Console.WriteLine($"Ciudad: {Ciudad}");
        Console.WriteLine($"Correo: {Correo}");
    }

    // Método privado: solo se puede llamar desde dentro de Persona.
    private bool EsMayorDeEdad()
    {
        return _edad >= 18;
    }

    // Método protegido: disponible para Persona y sus clases derivadas.
    protected void MostrarCiudad()
    {
        Console.WriteLine($"Ciudad: {Ciudad}");
    }

    // Método interno: disponible dentro del mismo proyecto o ensamblado.
    internal void CambiarCorreo(string nuevoCorreo)
    {
        Correo = nuevoCorreo;
    }
}

// Hereda de Persona.
public class Estudiante : Persona
{
    public Estudiante(string nombre, int edad) : base(nombre, edad)
    {
    }

    public void MostrarDatosDeEstudiante()
    {
        // Puede acceder a Nombre porque es public.
        Console.WriteLine($"Estudiante: {Nombre}");

        // Puede acceder a Ciudad porque es protected.
        Console.WriteLine($"Ciudad: {Ciudad}");

        // Puede acceder a Correo porque es internal y está en el mismo ensamblado.
        Console.WriteLine($"Correo: {Correo}");

        // No puede acceder a _edad ni llamar a EsMayorDeEdad(),
        // porque son private en Persona.
    }
}

internal class Program
{
    static void Main()
    {
        // Se puede crear una Persona porque la clase y su constructor son public.
        Persona persona = new Persona("Ana", 20);

        // Se puede acceder a Nombre porque es public.
        Console.WriteLine(persona.Nombre);

        // Se puede llamar a MostrarDatos porque es public.
        persona.MostrarDatos();

        // Se puede llamar a CambiarCorreo porque es internal
        // y Program pertenece al mismo ensamblado.
        persona.CambiarCorreo("ana@ejemplo.com");

        // No se puede acceder directamente a _edad, Ciudad ni a EsMayorDeEdad():
        // _edad y EsMayorDeEdad() son private, y Ciudad es protected.
        // Console.WriteLine(persona._edad); // Error de acceso
        // Console.WriteLine(persona.Ciudad); // Error de acceso
    }
}