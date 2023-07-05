using System;
using EspacioCalculadora;

namespace MiAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("¡Bienvenido a la calculadora!");

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Ingrese una operación (sumar, restar, multiplicar, dividir, limpiar) o 'salir' para salir:");
                string operacion = Console.ReadLine();

                switch (operacion)
                {
                    case "sumar":
                        Console.WriteLine("Ingrese el número a sumar:");
                        float numSumar = float.Parse(Console.ReadLine());
                        calculadora.Sumar(numSumar);
                        Console.WriteLine("El resultado es: " + calculadora.Resultado);
                        break;
                    case "restar":
                        Console.WriteLine("Ingrese el número a restar:");
                        float numRestar = float.Parse(Console.ReadLine());
                        calculadora.Restar(numRestar);
                        Console.WriteLine("El resultado es: " + calculadora.Resultado);
                        break;
                    case "multiplicar":
                        Console.WriteLine("Ingrese el número a multiplicar:");
                        float numMultiplicar = float.Parse(Console.ReadLine());
                        calculadora.Multiplicar(numMultiplicar);
                        Console.WriteLine("El resultado es: " + calculadora.Resultado);
                        break;
                    case "dividir":
                        Console.WriteLine("Ingrese el número divisor:");
                        float numDividir = float.Parse(Console.ReadLine());
                        calculadora.Dividir(numDividir);
                        Console.WriteLine("El resultado es: " + calculadora.Resultado);
                        break;
                    case "limpiar":
                        calculadora.Limpiar();
                        Console.WriteLine("El resultado ha sido limpiado.");
                        break;
                    case "salir":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Operación inválida. Intente nuevamente.");
                        break;
                }
            }

            Console.WriteLine("¡Hasta luego!");
        }
    }
}
