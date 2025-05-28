Console.Write("Ingrese un número: ");
string? cadena = Console.ReadLine();
int num;
if (int.TryParse(cadena, out num))
{
    int aux = 0;
    int longitud = cadena.Length;
    if (num > 0)
    {
        while (longitud > 0)
        {
            aux += (num % 10) * (int)(Math.Pow(10, longitud - 1));
            num /= 10;
            longitud--;
        }
    }
    Console.WriteLine("Inverso: " + aux);
}