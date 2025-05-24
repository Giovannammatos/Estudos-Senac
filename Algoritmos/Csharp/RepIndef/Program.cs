namespace RepIndef;

class Program
{
    static void Main(string[] args)
    {
        int soma = 0; // variavel que fara a soma
        Console.WriteLine("Digite um numéro");
        int num = int.Parse(Console.ReadLine()); // variavel para verificar se o numero é negativo

        while (num >= 0)
        {
            soma = soma + num;
            Console.WriteLine("Digite um numéro: ");
            num = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Soma: " + soma);
    }
}
