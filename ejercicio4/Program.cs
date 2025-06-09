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

