namespace alg_if;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a velocidade");
        int velocidade = int.Parse(Console.ReadLine());

        if (velocidade > 60)
        {
            Console.WriteLine("Multado");
        }
        else
        {
            Console.WriteLine("Não multado");
        }
        Console.WriteLine("Fim do programa"); 
    }
}
