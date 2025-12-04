using System;

namespace LogicaBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            string continuar = "sim";

            while (continuar != "sair")
            {
                Console.WriteLine("=== CÁLCULO DE VALOR DE PEÇAS ===");
                Console.WriteLine();
                Console.Write("Digite o código da peça 1: ");
                int codigoPeca1 = int.Parse(Console.ReadLine()!);

                Console.Write("Digite a quantidade de peças 1: ");
                int quantidadePeca1 = int.Parse(Console.ReadLine()!);

                Console.Write("Digite o valor unitário da peça 1: ");
                double valorUnitarioPeca1 = double.Parse(Console.ReadLine()!);

                Console.Write("Digite o código da peça 2: ");
                int codigoPeca2 = int.Parse(Console.ReadLine()!);

                Console.Write("Digite a quantidade de peças 2: ");
                int quantidadePeca2 = int.Parse(Console.ReadLine()!);

                Console.Write("Digite o valor unitário da peça 2: ");
                double valorUnitarioPeca2 = double.Parse(Console.ReadLine()!);

                double valorTotalPeca1 = quantidadePeca1 * valorUnitarioPeca1;
                double valorTotalPeca2 = quantidadePeca2 * valorUnitarioPeca2;

                double valorAPagar = valorTotalPeca1 + valorTotalPeca2;


                Console.WriteLine($"VALOR A PAGAR: R$ {valorAPagar:F2}");
                Console.WriteLine();
                Console.WriteLine("Digite 'sair' para encerrar ou pressione ENTER para continuar...");
                continuar = Console.ReadLine()!.ToLower();
                Console.Clear();

            }
            Console.WriteLine("Programa Encerrado!");
        }

    }
}