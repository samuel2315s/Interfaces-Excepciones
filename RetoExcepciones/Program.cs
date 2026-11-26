using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== VALIDACION DE EDAD ===");

        try
        {
            Console.Write("Ingrese su edad: ");

            int edad = int.Parse(Console.ReadLine() ?? "");

            if (edad < 0 || edad > 120)
            {
                throw new EdadInvalidaException(
                    "La edad debe estar entre 0 y 120 años.");
            }

            Console.WriteLine("Edad valida: " + edad + " años.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: debe ingresar un numero entero.");
        }
        catch (EdadInvalidaException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
       catch (Exception ex) when (ex is OverflowException)
{
    Console.WriteLine("Error: el numero ingresado esta fuera de los limites de un entero.");
}
        finally
        {
            Console.WriteLine("Proceso de validacion finalizado.");
        }
    }
}