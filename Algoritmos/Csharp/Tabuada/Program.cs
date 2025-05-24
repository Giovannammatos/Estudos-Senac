namespace Tabuada;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o numero que deseja receber a tabuada: ");
        int num = int.Parse(Console.ReadLine());

        for (int cont = 1; cont <= 10; cont++)
        {
            int result = num * cont;
            Console.WriteLine("{0} * {1} = {2}", num, cont, result);
        }
    
    } 
}
