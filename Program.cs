// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un numero: ");
string a = Console.ReadLine();

float num;
if (float.TryParse(a, out num))
{
    if (num > 0)
    {
        num = 1/num;
    }
    Console.WriteLine(num);
}