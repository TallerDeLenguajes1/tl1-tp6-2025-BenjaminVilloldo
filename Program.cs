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

int entero1;
int entero2;
int salir;


/////////PUNTO 2/////////

int eleccion;
do
{

    Console.WriteLine("1 - Operaciones basicas | 2 - Operacionesavanazdas");

    string? inputOperacion = Console.ReadLine();
    int operacion;
    if (int.TryParse(inputOperacion, out operacion))
    {
        Console.WriteLine("Ingrese dos enteros:");
        switch (operacion)
        {
            case 1:
                while (!int.TryParse(Console.ReadLine(), out entero1)) // esto verifica que la entrada sea un entero
                {
                    Console.WriteLine("Ingrese un numero valido");
                }
                while (!int.TryParse(Console.ReadLine(), out entero2)) // esto verifica que la entrada sea un entero
                {
                    Console.WriteLine("Ingrese un numero valido");
                }
                Console.WriteLine("1 - Suma | 2 - Resta | 3 - Multiplicacion | 4 - Division | 5 - Valor absoluto |");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out eleccion))
                {
                    int resultado;
                    switch (eleccion)
                    {
                        case 1:
                            resultado = Sumar(entero1, entero2);
                            Console.WriteLine("El resultado es de: " + resultado);
                            break;
                        case 2:
                            resultado = entero1 - entero2;
                            Console.WriteLine("El resultado es de: " + resultado);

                            break;
                        case 3:
                            resultado = entero1 * entero2;
                            Console.WriteLine("El resultado es de: " + resultado);

                            break;
                        case 4:
                            resultado = entero1 / entero2;
                            Console.WriteLine("El resultado es de: " + resultado);

                            break;
                        case 5:
                            Console.WriteLine("Saliendo...");
                            break;
                        case 6:

                            break;
                        default:
                            Console.WriteLine("No es una opcion valida.");
                            return;
                    }
                }
                break;
            case 2:
                double resultado2;
                Console.WriteLine("Ingrese un numero: ");
                string? inputAvanzado = Console.ReadLine();
                double.TryParse(inputAvanzado, out double enteroA);

                Console.WriteLine("1 - Valor absoluto | 2 - Cuadradado | 3 - Raiz cuadrada | 4 - Sen | 5 - Coseno | 6 - Parte entera");
                string? input2 = Console.ReadLine();
                int.TryParse(input2, out int operacionAvanzada);

                switch (operacionAvanzada)
                {
                    case 1:
                        if (enteroA < 0)
                        {
                            resultado2 = -enteroA;
                        }
                        else
                        {
                            resultado2 = enteroA;
                        }
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
                    default:

                        return;
                }
                Console.WriteLine("El resultado es: " + resultado2);






                break;
            case 3:
                break;
            default:
                Console.WriteLine("No es una opcion valida.");
                return;
        }
    }



    Console.WriteLine("¿Desea salir?\n 1 - Si \n 2 - Seguir calculando");
    string? entradaSalir = Console.ReadLine();

    if (int.TryParse(entradaSalir, out int opcionSalir))// no entiendo bien como funciona esto
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
