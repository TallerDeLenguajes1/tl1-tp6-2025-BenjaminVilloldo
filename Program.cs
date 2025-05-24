// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
/*
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
using System;

class Program
{
    static void Main()
    {
        InvertirNumero();

        int salir;
        do
        {
            Console.WriteLine("\n--CALCULADORA v1--");
            Console.WriteLine("1 - Operaciones Básicas");
            Console.WriteLine("2 - Operaciones Avanzadas");

            if (int.TryParse(Console.ReadLine(), out int operacion))
            {
                switch (operacion)
                {
                    case 1:
                        OperacionesBasicas();
                        break;
                    case 2:
                        OperacionesAvanzadas();
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }

            Console.WriteLine("\n¿Desea salir?\n1 - Sí\n2 - No");
            salir = int.TryParse(Console.ReadLine(), out int opcionSalir) ? opcionSalir : 2;

        } while (salir != 1);
    }

    // -------- Funciones auxiliares --------

    static void InvertirNumero()
    {
        Console.WriteLine("--INVERTIR NÚMERO--\nIngrese un número:");
        string? entrada = Console.ReadLine();
        if (int.TryParse(entrada, out int numero))
        {
            int numeroInvertido = 0;
            while (numero > 0)
            {
                numeroInvertido = (numeroInvertido * 10) + (numero % 10);
                numero /= 10;
            }
            Console.WriteLine("Número invertido: " + numeroInvertido);
        }
        else
        {
            Console.WriteLine("No se ingresó un número válido.");
        }
    }

    static void OperacionesBasicas()
    {
        Console.WriteLine("--Operaciones Básicas--");
        int a = LeerEntero("Ingrese el primer número:");
        int b = LeerEntero("Ingrese el segundo número:");

        Console.WriteLine("1 - Suma\n2 - Resta\n3 - Multiplicación\n4 - División");
        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            int resultado = opcion switch
            {
                1 => a + b,
                2 => a - b,
                3 => a * b,
                4 => b != 0 ? a / b : throw new DivideByZeroException("No se puede dividir por cero."),
                _ => throw new ArgumentException("Operación no válida.")
            };
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }

    static void OperacionesAvanzadas()
    {
        Console.WriteLine("--Operaciones Avanzadas--");
        double a = LeerDouble("Ingrese un número:");

        Console.WriteLine("1 - Valor absoluto\n2 - Cuadrado\n3 - Raíz cuadrada\n4 - Seno\n5 - Coseno\n6 - Parte entera");
        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            double resultado = opcion switch
            {
                1 => Math.Abs(a),
                2 => Cuadrado(a),
                3 => Raiz(a),
                4 => Seno(a),
                5 => Coseno(a),
                6 => Math.Truncate(a),
                _ => throw new ArgumentException("Operación no válida.")
            };
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }

    static int LeerEntero(string mensaje)
    {
        int valor;
        Console.WriteLine(mensaje);
        while (!int.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Ingrese un número válido:");
        }
        return valor;
    }

    static double LeerDouble(string mensaje)
    {
        double valor;
        Console.WriteLine(mensaje);
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Ingrese un número válido:");
        }
        return valor;
    }

    // -------- Operaciones matemáticas --------

    static double Cuadrado(double a) => a * a;
    static double Raiz(double a) => Math.Sqrt(a);
    static double Seno(double grados) => Math.Sin(grados * Math.PI / 180);
    static double Coseno(double grados) => Math.Cos(grados * Math.PI / 180);
}

*/
Console.WriteLine("Ingrese una cadena: ");
string entradaCadena = Console.ReadLine();
int cantletras = entradaCadena.Length;
Console.WriteLine("El mensaje que se muestra es: " + cantletras);
Console.WriteLine("Ingrese la segunda cadena: ");
string entradaDos = Console.ReadLine();
string entradasConcatenadas = string.Concat(entradaCadena, entradaDos);
Console.WriteLine("Las cadenas concatenadas: " + entradasConcatenadas);

Console.WriteLine("Ingresa el inicio y el final de la cadena");
int ini;
int fin;
int.TryParse(Console.ReadLine(), out ini);
int.TryParse(Console.ReadLine(), out fin);
string subcadena = entradaCadena.Substring(ini, fin);
Console.WriteLine($"La cadena {entradaCadena} tiene la subcadena {subcadena}");
