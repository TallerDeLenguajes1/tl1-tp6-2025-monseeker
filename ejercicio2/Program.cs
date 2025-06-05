// See https://aka.ms/new-console-template for more information
using System;

int desicion = 1;
Console.WriteLine("Calculadora");

do{
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.WriteLine("5. Calculadora Avanzada");
    Console.WriteLine("6. Comparar dos Numeros");
    Console.Write("\nIngrese la operacion: ");

    string cadena = Console.ReadLine();
    
    if (int.TryParse(cadena, out int operacion))
    {
        double num1, num2, resultado;

        switch (operacion)
        {
            case 1:
                num1 = PedirNumero();
                num2 = PedirNumero();
                resultado = Sumar(num1, num2);
                Console.WriteLine($"{num1}+{num2}={resultado:F2}\n");
                break;
            case 2:
                num1 = PedirNumero();
                num2 = PedirNumero();
                resultado = Restar(num1, num2);
                Console.WriteLine($"{num1}-{num2}={resultado:F2}\n");
                break;
            case 3:
                num1 = PedirNumero();
                num2 = PedirNumero();
                resultado = Producto(num1, num2);
                Console.WriteLine($"{num1}*{num2}={resultado:F2}\n");
                break;
            case 4:
                num1 = PedirNumero();
                num2 = PedirNumero();
                if (num2 != 0)
                {
                    resultado = Cociente(num1, num2);
                    Console.WriteLine($"{num1}/{num2}={resultado:F2}\n");
                }
                else
                {
                    Console.WriteLine("No es posible dividir un numero en cero.\n");
                }
                break;
            case 5:
                CalculadoraAvanzada();
                break;
            case 6:
                CompararDosNumeros();
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
        Console.WriteLine("\n");
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
    double num;
    bool numeroValido;
    do
    {
        Console.Write("Ingrese un numero: ");
        string entrada = Console.ReadLine();
        numeroValido = double.TryParse(entrada, out num);
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
    return num1 / num2;
} 

void CalculadoraAvanzada()
{
    Console.WriteLine("Calculadora Avanzada");
    double num = PedirNumero();
    Console.WriteLine("\n");

    double resultadoAbsoluto = Math.Abs(num);
    Console.WriteLine($"Valor Absoluto de {num}: {resultadoAbsoluto} \n");

    double resultadoPotencia = Math.Pow(num, 2);
    Console.WriteLine($"Cuadrado de {num}: {resultadoPotencia} \n");

    if (num >= 0)
    {
        double resultadoRaiz = Math.Sqrt(num);
        Console.WriteLine($"Raiz cuadrada de {num}: {resultadoRaiz} \n");
    }
    else
    {
        Console.WriteLine("No existe la raiz cuadrada de un numero negativo. \n");
    }

    double resultadoSeno = Math.Sin(num * Math.PI / 180);
    Console.WriteLine($"Seno de {num} grados: {resultadoSeno} \n");

    double resultadoCoseno = Math.Cos(num * Math.PI / 180);
    Console.WriteLine($"Coseno de {num} grados: {resultadoCoseno} \n");

    double resultadoEntero = Math.Truncate(num);
    Console.WriteLine($"Entero del real {num}: {resultadoEntero} \n");
}

void CompararDosNumeros()
{
    Console.WriteLine("Ingrese dos numeros para comparar: ");
    double primerNumeroAComparar = PedirNumero();
    double segundoNumeroAComparar = PedirNumero();

    double numeroMaximo = Math.Max(primerNumeroAComparar, segundoNumeroAComparar);
    double numeroMinimo = Math.Min(primerNumeroAComparar, segundoNumeroAComparar);

    Console.WriteLine($"Maximo: {numeroMaximo}");
    Console.WriteLine($"Minimo: {numeroMinimo}"); 
}