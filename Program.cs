// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

Console.WriteLine("--CALCULADORA--\nIngrese el valor: ");

int numero = 0;
numero = Console.Read();

int numeroInvertido = 0;
int ultimoDigito;
int numSalida;
if (int.TryParse(int numero, out numSalida))
{
    
}
do
{


    ultimoDigito = numero % 10;
    numeroInvertido = (numeroInvertido * 10) + ultimoDigito;
    numero /= 10;
} while (numero > 0);

Console.WriteLine("El numero invertido es: " + numeroInvertido);