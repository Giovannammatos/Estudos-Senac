namespace alg_atv;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a velocidade: ");

        int velocidade = int.Parse(Console.ReadLine());
        if (velocidade > 60)
        {
            Console.WriteLine("Excesso de velocidade");
        }
        
        Console.WriteLine("Fim do programa");
           
    }
}
