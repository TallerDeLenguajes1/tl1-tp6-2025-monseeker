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
                Console.WriteLine("\nValor Absoluto");
                double resultadoAbsoluto = Math.Abs(Numeros());
                Console.WriteLine($"Resultado: {resultadoAbsoluto} \n");
                break;
            case 2:
                Console.WriteLine("\nCuadrado");
                double resultadoPotencia = Math.Pow(Numeros(), 2);
                Console.WriteLine($"Resultado: {resultadoPotencia} \n");
                break;
            case 3:
                Console.WriteLine("\nRaiz Cuadrada");
                double numero = Numeros();
                if (numero >= 0)
                {
                    double resultadoRaiz = Math.Sqrt(numero);
                    Console.WriteLine($"Resultado: {resultadoRaiz} \n");
                }
                else
                {
                    Console.WriteLine("Ingrese un numero no negativo. \n");
                }
                break;
            case 4:
                Console.WriteLine("\nSeno");
                double anguloGradosSeno = Numeros();
                double resultadoSeno = Math.Sin(anguloGradosSeno * Math.PI / 180);
                Console.WriteLine($"Seno de {anguloGradosSeno} grados: {resultadoSeno} \n");
                break;
            case 5:
                Console.WriteLine("\nCoseno");
                double anguloGradosCoseno = Numeros();
                double resultadoCoseno = Math.Cos(anguloGradosCoseno * Math.PI / 180);
                Console.WriteLine($"Coseno de {anguloGradosCoseno} grados: {resultadoCoseno} \n");
                break;
            case 6:
                Console.WriteLine("\nEntero de un real");
                int resultadoEntero = (int)Numeros();
                Console.WriteLine($"Resultado: {resultadoEntero} \n");
                break;
            case 7:
                Console.WriteLine("\nMayor y menor");
                double primerNumero = Numeros();
                double segundoNumero = Numeros();
                if (primerNumero > segundoNumero)
                {
                    Console.WriteLine($"Entre {primerNumero} y {segundoNumero} el mayor es {primerNumero} y el menor {segundoNumero} \n");
                }
                else if (segundoNumero > primerNumero)
                {
                    Console.WriteLine($"Entre {primerNumero} y {segundoNumero} el mayor es {segundoNumero} y el menor {primerNumero} \n");
                }
                else
                {
                    Console.WriteLine("Ambos numeros son iguales. \n");
                }
                break;
            default:
                Console.WriteLine("Ingrese un valor valido. \n");
                break;
        }

    }
    else
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
        if (int.TryParse(cadena, out realizarOtraOperacion))
        {
            if (realizarOtraOperacion != 1 && realizarOtraOperacion != 0)
            {
                Console.WriteLine("Ingrese un valor valido. \n");
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