namespace alg03;

class Program
{
    static void Main(string[] args)
    {   
        //entrada de dados
        Console.Write("Informe o custo de fábrica: ");
        double custoFabrica = double.Parse(Console.ReadLine());
        //processamento de dados
        double custoDistribuidor = custoFabrica * 0.28;
        double imposto = custoFabrica * 0.45;
        double custoConsumidor = custoFabrica + custoDistribuidor + imposto;
        Console.WriteLine("O custo do consumidor é de R${0:N2}", custoConsumidor);
    }
}
