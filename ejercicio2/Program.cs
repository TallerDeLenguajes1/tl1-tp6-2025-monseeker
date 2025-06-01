// See https://aka.ms/new-console-template for more information
using System;

int desicion = 1;
Console.WriteLine("Calculadora");

do{
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.Write("Ingrese la operacion: ");

    string? cadena = Console.ReadLine();
    
    if (int.TryParse(cadena, out int operacion))
    {
        int resultado;

        switch (operacion)
        {
            case 1:
                resultado = Sumar(Numeros(), Numeros());
                Console.WriteLine("Resultado: " + resultado);
                break;
            case 2:
                resultado = Restar(Numeros(), Numeros());
                Console.WriteLine("Resultado: " + resultado);
                break;
            case 3:
                resultado = Producto(Numeros(), Numeros());
                Console.WriteLine("Resultado: " + resultado);
                break;
            case 4:
                resultado = Cociente(Numeros(), Numeros());
                if (resultado != 0)
                {
                    Console.WriteLine("Resultado: " + resultado);
                }
                break;
            default:
                Console.WriteLine("Metele algo valido. \n");
                break;
        }

    } else
    {
        Console.WriteLine("Ingrese un numero. \n");
    }
    int aux = 0;
    do
    {
        Console.WriteLine("Desea realizar otra operacion?");
        Console.WriteLine("1.Si \t0.No");
        Console.Write("Desicion: ");
        cadena = Console.ReadLine();
        if (int.TryParse(cadena, out desicion))
        {
            if (desicion != 1 && desicion != 0)
            {
                Console.WriteLine("Metele algo valido. \n");
            }
            else
            {
                aux = 3;
            }
        }
        else
        {
            Console.WriteLine("Ingrese un numero. \n");

        }
    } while (aux != 3);

} while (desicion != 0);




int Numeros()
{
    Console.Write("Ingrese un numero: ");
    string? entrada = Console.ReadLine();
    if (int.TryParse(entrada, out int num))
    {
        return num;
    }
    else
    {
        Console.WriteLine("Ingrese un numero.");
        return 0;
    }
}

int Sumar(int num1, int num2)
{
    return num1 + num2;
}

int Restar(int num1, int num2)
{
    return num1 - num2;
}

int Producto(int num1, int num2)
{
    return num1 * num2;
}

int Cociente(int num1, int num2)
{
    if (num2 != 0)
    {
        return num1 / num2;
    }
    else
    {
        Console.WriteLine("No es posible dividir un numero en 0.");
        return 0;
    }
}