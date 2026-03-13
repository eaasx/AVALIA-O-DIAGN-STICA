using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10];
        int maior = int.MinValue;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }

        Console.WriteLine($"\nO maior número digitado foi: {maior}");
    }
}