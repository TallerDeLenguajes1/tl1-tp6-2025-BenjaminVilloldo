// See https://aka.ms/new-console-template for more information
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

}else
{
    Console.WriteLine("No se ingreso un numero, reinicie el sistema.");
}


