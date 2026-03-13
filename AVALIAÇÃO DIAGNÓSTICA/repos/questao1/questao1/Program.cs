using System;

class Program
{
    static void Main()
    {
        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Somar dois numeros");
            Console.WriteLine("2 - Subtrair dois numeros");
            Console.WriteLine("3 - Multiplicar dois numeros");
            Console.WriteLine("4 - Dividir dois numeros");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opcao: ");

            if (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 5)
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                continue;
            }

            if (opcao == 5) break;

            Console.Write("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine($"Resultado: {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {num1 * num2}");
                    break;
                case 4:
                    if (num2 == 0)
                        Console.WriteLine("Erro: Divisão por zero.");
                    else
                        Console.WriteLine($"Resultado: {num1 / num2}");
                    break;
            }
        }
    }
}