namespace CalculaDobro;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Informe seu número: ");
        int numero = int.Parse(Console.ReadLine());
        int dobro = numero * 2;

        Console.Write("O dobro de " +numero+ " é: " +dobro);
    }
}
