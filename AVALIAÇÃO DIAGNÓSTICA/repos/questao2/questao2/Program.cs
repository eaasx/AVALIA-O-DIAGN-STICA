using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número inicial: ");
        int inicial = int.Parse(Console.ReadLine());

        Console.Write("Digite o número final: ");
        int final = int.Parse(Console.ReadLine());

        if (inicial >= final)
        {
            Console.WriteLine("Erro: O número inicial precisa ser menor que o final.");
        }
        else
        {
            Console.WriteLine("\nNúmeros no intervalo:");
            for (int i = inicial; i <= final; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}