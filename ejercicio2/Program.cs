// See https://aka.ms/new-console-template for more information

Console.WriteLine("Calculadora Avanzada");
double primerNumeroACalcular = PedirNumero();
Console.WriteLine("\n");

double resultadoAbsoluto = Math.Abs(primerNumeroACalcular);
Console.WriteLine($"Valor Absoluto de {primerNumeroACalcular}: {resultadoAbsoluto} \n");

double resultadoPotencia = Math.Pow(primerNumeroACalcular, 2);
Console.WriteLine($"Cuadrado de {primerNumeroACalcular}: {resultadoPotencia} \n");

if (primerNumeroACalcular >= 0)
{
    double resultadoRaiz = Math.Sqrt(primerNumeroACalcular);
    Console.WriteLine($"Raiz cuadrada de {primerNumeroACalcular}: {resultadoRaiz} \n");
}
else
{
    Console.WriteLine("No existe la raiz cuadrada de un numero negativo. \n");
}

double resultadoSeno = Math.Sin(primerNumeroACalcular * Math.PI / 180);
Console.WriteLine($"Seno de {primerNumeroACalcular} grados: {resultadoSeno} \n");

double resultadoCoseno = Math.Cos(primerNumeroACalcular * Math.PI / 180);
Console.WriteLine($"Coseno de {primerNumeroACalcular} grados: {resultadoCoseno} \n");

double resultadoEntero = Math.Truncate(primerNumeroACalcular);
Console.WriteLine($"Entero del real {primerNumeroACalcular}: {resultadoEntero} \n");


Console.WriteLine("Ingrese dos numeros para comparar: ");
double primerNumeroAComparar = PedirNumero();
double segundoNumeroAComparar = PedirNumero();

double numeroMaximo = Math.Max(primerNumeroAComparar, segundoNumeroAComparar);
double numeroMinimo = Math.Min(primerNumeroAComparar, segundoNumeroAComparar);

Console.WriteLine($"Maximo: {numeroMaximo}");
Console.WriteLine($"Minimo: {numeroMinimo}");


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