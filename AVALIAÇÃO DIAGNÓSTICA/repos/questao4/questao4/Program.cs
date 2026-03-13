using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[5];
        double[] notas = new double[5];
        int contador = 0;
        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("\n1 - Cadastrar aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Mostrar media das notas");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    if (contador < 5)
                    {
                        Console.Write("Nome do aluno: ");
                        nomes[contador] = Console.ReadLine();
                        Console.Write("Nota do aluno: ");
                        notas[contador] = double.Parse(Console.ReadLine());
                        contador++;
                        Console.WriteLine("Aluno cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine("Limite de 5 alunos atingido.");
                    }
                    break;

                case 2:
                    Console.WriteLine("\nLista de Alunos:");
                    for (int i = 0; i < contador; i++)
                    {
                        Console.WriteLine($"Nome: {nomes[i]} | Nota: {notas[i]}");
                    }
                    break;

                case 3:
                    if (contador == 0)
                    {
                        Console.WriteLine("Nenhum aluno cadastrado para calcular a média.");
                    }
                    else
                    {
                        double soma = 0;
                        for (int i = 0; i < contador; i++)
                        {
                            soma += notas[i];
                        }
                        Console.WriteLine($"\nMédia das notas: {soma / contador}");
                    }
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}