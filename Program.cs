// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);


Console.WriteLine("--CALCULADORA--\nIngrese el valor: ");

string? entrada = Console.ReadLine();
int numero;
int numeroInvertido = 0;
int ultimoDigito;
if (int.TryParse(entrada, out numero))
{
    do
    {
        ultimoDigito = numero % 10; // toma el ultimo digito
        numeroInvertido = (numeroInvertido * 10) + ultimoDigito;
        numero /= 10;
    } while (numero > 0);
    Console.WriteLine("El numero invertido es: " + numeroInvertido);

}
else
{
    Console.WriteLine("No se ingreso un numero, reinicie el sistema.");
}

Console.WriteLine("Calculadora v1\n");



/////////PUNTO 2/////////

int salir = 0;
do
{
    Console.WriteLine("1 - Operaciones básicas | 2 - Operaciones avanzadas");
    string? inputOperacion = Console.ReadLine();
    int operacion;

    if (int.TryParse(inputOperacion, out operacion))
    {
        switch (operacion)
        {
            case 1:
                int entero1, entero2;

                Console.WriteLine("Ingrese dos números enteros:");
                while (!int.TryParse(Console.ReadLine(), out entero1))
                {
                    Console.WriteLine("Ingrese un número válido:");
                }
                while (!int.TryParse(Console.ReadLine(), out entero2))
                {
                    Console.WriteLine("Ingrese un número válido:");
                }

                // Usamos un switch solo para separar el grupo de operaciones básicas
                switch (1) // Siempre entra acá para agrupar
                {
                    case 1:
                        Console.WriteLine($"Suma: {entero1} + {entero2} = {entero1 + entero2}");
                        Console.WriteLine($"Resta: {entero1} - {entero2} = {entero1 - entero2}");
                        Console.WriteLine($"Multiplicación: {entero1} * {entero2} = {entero1 * entero2}");

                        if (entero2 != 0)
                            Console.WriteLine($"División: {entero1} / {entero2} = {(double)entero1 / entero2}");
                        else
                            Console.WriteLine("División: No se puede dividir por cero.");
                        break;
                }
                break;

            case 2:
                Console.WriteLine("Ingrese un número:");
                string? inputAvanzado = Console.ReadLine();
                double.TryParse(inputAvanzado, out double enteroA);

                Console.WriteLine("1 - Valor absoluto | 2 - Cuadrado | 3 - Raíz cuadrada | 4 - Seno | 5 - Coseno | 6 - Parte entera");
                string? input2 = Console.ReadLine();
                int.TryParse(input2, out int operacionAvanzada);

                double resultado2;

                switch (operacionAvanzada)
                {
                    case 1:
                        resultado2 = Math.Abs(enteroA);
                        break;
                    case 2:
                        resultado2 = Cuadrado(enteroA);
                        break;
                    case 3:
                        resultado2 = Raiz(enteroA);
                        break;
                    case 4:
                        resultado2 = Seno(enteroA);
                        break;
                    case 5:
                        resultado2 = Coseno(enteroA);
                        break;
                    case 6:
                        resultado2 = Math.Floor(enteroA);
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        continue;
                }

                Console.WriteLine("El resultado es: " + resultado2);
                break;

            default:
                Console.WriteLine("No es una opción válida.");
                continue;
        }
    }

    Console.WriteLine("¿Desea salir?\n1 - Sí\n2 - Seguir calculando");
    string? entradaSalir = Console.ReadLine();

    if (int.TryParse(entradaSalir, out int opcionSalir))
    {
        salir = opcionSalir;
    }
    else
    {
        salir = 2;
    }

} while (salir != 1);


int Sumar(int a, int b) => a + b;
double Cuadrado(double a) => a * a;
double Raiz(double a) => Math.Sqrt(a);
double Seno(double anguloEnGrados) => Math.Sin(anguloEnGrados * Math.PI / 180);
double Coseno(double anguloEnGrados) => Math.Cos(anguloEnGrados * Math.PI / 180);


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

Console.WriteLine("---Trabajo con toString---");
foreach (char letra in entradaCadena)
{
    Console.WriteLine(letra);
}

Console.WriteLine("Ingrese una frase: ");
string frase = Console.ReadLine();
Console.WriteLine("Ingrese una palabra: ");
string palabra = Console.ReadLine();

if (frase.Contains(palabra))
{
    Console.WriteLine("Lo tiene");
}
else
{
    Console.WriteLine("No lo tiene");
}
