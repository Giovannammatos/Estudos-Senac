namespace CalculoImc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu peso em quilos ");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe sua altura em metro ");
        double altura = double.Parse(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("seu imc é {0:N2}", imc);

        if (imc < 20)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Peso ideal");
        }
        else
        {
            Console.WriteLine("Acima do peso");
        }
    }
}
