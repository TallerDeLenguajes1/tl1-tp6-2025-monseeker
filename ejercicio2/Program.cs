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
        double num1, num2, resultado;

        switch (operacion)
        {
            case 1:
                num1 = PedirNumero();
                num2 = PedirNumero();
                resultado = Sumar(num1, num2);
                Console.WriteLine($"{num1}+{num2}={resultado:F2}");
                break;
            case 2:
                num1 = PedirNumero();
                num2 = PedirNumero();
                resultado = Restar(num1, num2);
                Console.WriteLine($"{num1}-{num2}={resultado:F2}");
                break;
            case 3:
                num1 = PedirNumero();
                num2 = PedirNumero();
                resultado = Producto(num1, num2);
                Console.WriteLine($"{num1}*{num2}={resultado:F2}");
                break;
            case 4:
                num1 = PedirNumero();
                num2 = PedirNumero();
                if (num2 != 0)
                {
                    resultado = Cociente(num1, num2);
                    Console.WriteLine($"{num1}/{num2}={resultado:F2}");
                }
                break;
            default:
                Console.WriteLine("Ingrese una opción válida del menú.\n");
                break;
        }

    } else
    {
        Console.WriteLine("Ingrese un numero. \n");
    }
    bool ingresoValorCorrecto = false;
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
                Console.WriteLine("Ingrese una opción válida del menú.\n");

            }
            else
            {
                ingresoValorCorrecto = true;
            }
        }
        else
        {
            Console.WriteLine("Ingrese un numero. \n");

        }
    } while (ingresoValorCorrecto != true);

} while (desicion != 0);




double PedirNumero()
{
    bool numeroValido;
    do
    {
        Console.Write("Ingrese un numero: ");
        string? entrada = Console.ReadLine();
        numeroValido = double.TryParse(entrada, out double num);
        if (!numeroValido)
        {
            Console.WriteLine("Ingrese un numero valido.");
        }
    } while (!numeroValido);
    return num;
}

double Sumar(double num1, double num2)
{
    return num1 + num2;
}

double Restar(double num1, double num2)
{
    return num1 - num2;
}

double Producto(double num1, double num2)
{
    return num1 * num2;
}

double Cociente(double num1, double num2)
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