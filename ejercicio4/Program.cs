// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese una frase: ");
string PrimeraCadena = Console.ReadLine();

Console.WriteLine($"\nLa longitud de \"{PrimeraCadena}\" es: {PrimeraCadena.Length}\n");

Console.WriteLine("Ingrese otra frase: ");
string SegundaCadena = Console.ReadLine();

string CadenaConcatenada = string.Concat(PrimeraCadena, " ", SegundaCadena);
Console.WriteLine($"\nCadenas concatenadas: {CadenaConcatenada}\n");

string Subcadena = CadenaConcatenada.Substring(0, 5);
Console.WriteLine($"Una subcadena de \"{CadenaConcatenada}\" es: {Subcadena}\n");


Console.Write("Ingrese un numero: ");
string CadenaNumero1 = Console.ReadLine();
Console.Write("Ingrese otro numero: ");
string CadenaNumero2 = Console.ReadLine();

if (int.TryParse(CadenaNumero1, out int num1) && int.TryParse(CadenaNumero2, out int num2))
{
    int resultado = num1 + num2;
    Console.Write($"La suma de {num1} y de {num2} es igual a: {resultado.ToString()}\n");
}

foreach (char c in CadenaConcatenada)
{
    Console.WriteLine(c);
}

Console.Write("Ingrese la palabra a buscar: ");
string PalabraABuscar = Console.ReadLine();

int contador = 0;
int posicion = 0;

while ((posicion = CadenaConcatenada.IndexOf(PalabraABuscar, posicion)) != -1)
{
    contador++;
    posicion += PalabraABuscar.Length;
}

Console.WriteLine($"La palabra \"{PalabraABuscar}\" aparece {contador} veces.\n");

Console.WriteLine($"\nEn mayuscula: {CadenaConcatenada.ToUpper()}\n");
Console.WriteLine($"En minuscula: {CadenaConcatenada.ToLower()}\n");

string[] CadenaSeparada = CadenaConcatenada.Split(' ');

foreach (string cadenita in CadenaSeparada)
{
    Console.WriteLine(cadenita);
}

Console.Write("Ingrese una ecuacion simple: ");
string ecuacion = Console.ReadLine();

char[] operadores = { '+', '-', '*', '/' };
char operador = ' ';

foreach (char operacion in operadores)
{
    if (ecuacion.Contains(operacion))
    {
        operador = operacion;
        break;
    }
}

if (operador == ' ')
{
    Console.WriteLine("No se encontro un operador valido.\n");
    return;
}

string[] numeros = ecuacion.Split(operador);

if (numeros.Length != 2)
{
    Console.WriteLine("Ingrese una operacion simple.\n");
    return;
}

if (int.TryParse(numeros[0], out int numero1) && int.TryParse(numeros[1], out int numero2))
{
    switch (operador)
    {

        case '+': Console.WriteLine($"{numero1}+{numero2}={numero1+numero2}"); break;
        case '-': Console.WriteLine($"{numero1}-{numero2}={numero1-numero2}"); break;
        case '*': Console.WriteLine($"{numero1}*{numero2}={numero1*numero2}"); break;
        case '/':
            if (numero2 != 0)
            {
                Console.WriteLine($"{numero1}/{numero2}={numero1/numero2}");
            } else {
                Console.WriteLine("No es posible dividir por 0.\n");
                return;
            }
        break;
    }
} else {
    Console.WriteLine("Ingrese numeros validos.\n");
}

