// See https://aka.ms/new-console-template for more information
using System;

int realizarOtraOperacion = 1;
Console.WriteLine("Calculadora Avanzada");

do{
    Console.WriteLine("1. Valor Absoluto");
    Console.WriteLine("2. Cuadrado");
    Console.WriteLine("3. Raiz Cuadrada");
    Console.WriteLine("4. Seno");
    Console.WriteLine("5. Coseno");
    Console.WriteLine("6. Parte Entera de un Real");
    Console.WriteLine("7. Max y Min entre dos Numeros");
    
    Console.Write("\nIngrese la operacion: ");

    string cadena = Console.ReadLine();
    
    if (int.TryParse(cadena, out int operacion))
    {
        switch (operacion)
        {
            case 1:
                Console.WriteLine("Valor Absoluto");
                double resultadoAbsoluto = Math.Abs(Numeros());
                Console.WriteLine("Resultado: " + resultadoAbsoluto);
                break;
            case 2:
                double resultadoPotencia = Math.Pow(Numeros(), 2);
                Console.WriteLine("Resultado: " + resultadoPotencia);
                break;
            case 3:
                double = numero Numeros();
                if (numero >= 0)
                {
                    double resultadoRaiz = Math.Sqrt(numero);
                    Console.WriteLine("Resultado: " + resultadoRaiz);
                } else {
                    Console.WriteLine("Ingrese un numero no negativo.");
                }
                break;
            case 4:
                double anguloGradosSeno = Numeros();
                double resultadoSeno = Math.Sin(anguloGradosSeno * Math.PI / 180);
                Console.WriteLine($"Seno de {anguloGradosSeno} grados: {resultadoSeno}");
                break;
            case 5:
                double anguloGradosCoseno = Numeros();
                double resultadoCoseno = Math.Cos(anguloGradosCoseno * Math.PI / 180);
                Console.WriteLine($"Coseno de {anguloGradosCoseno} grados: {resultadoCoseno}");
                break;
            case 6:
                int resultadoEntero = (int)(Numeros());
                Console.WriteLine("Resultado: " + resultadoEntero);
                break;
            case 7:
                double primerNumero = Numeros();
                double segundoNumero = Numeros();
                if (primerNumero > segundoNumero)
                {
                    Console.WriteLine($"Entre {primerNumero} y {segundoNumero} el mayor es {primerNumero}");
                }
                else if (segundoNumero > primerNumero)
                {
                    Console.WriteLine($"Entre {primerNumero} y {segundoNumero} el mayor es {segundoNumero}");
                }
                else
                {
                    Console.WriteLine("Ambos numeros son iguales.");
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

    bool ingresoValorCorrecto = false;
    do
    {
        Console.WriteLine("Desea realizar otra operacion?");
        Console.WriteLine("1.Si \t0.No");
        Console.Write("Desicion: ");
        cadena = Console.ReadLine();
        if (int.TryParse(cadena, out realizarOtraOperacion))
        {
            if (realizarOtraOperacion != 1 && realizarOtraOperacion != 0)
            {
                Console.WriteLine("Metele algo valido. \n");
            }
            else
            {
                Console.WriteLine("\nIngrese la operacion:");
                ingresoValorCorrecto = true;
            }
        }
        else
        {
            Console.WriteLine("Ingrese un numero. \n");

        }
    } while (ingresoValorCorrecto != true);

} while (realizarOtraOperacion != 0);




double Numeros()
{
    Console.Write("Ingrese un numero: ");
    string entrada = Console.ReadLine();
    if (double.TryParse(entrada, out double num))
    {
        return num;
    }
    else
    {
        Console.WriteLine("Ingrese un numero.");
        return 0;
    }
}