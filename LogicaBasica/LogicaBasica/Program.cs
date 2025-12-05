using System;

namespace LogicaBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            Exercicio04();
        }

        static void Exercicio01()
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

        static void Exercicio02()
        {
            string continuar = "sim";

            while (continuar != "sair")
            {
                Console.WriteLine("=====================RAIO=======================");
                Console.WriteLine();
                Console.Write("Digite o valor do raio: ");
                double valorRaio = double.Parse(Console.ReadLine()!);
                double area = Math.PI * (valorRaio * valorRaio);

                Console.WriteLine($"Área = {area:F4}");

                Console.WriteLine("Digite 'sair' para encerrar ou pressione ENTER para continuar...");
                continuar = Console.ReadLine()!.ToLower();
                Console.Clear();
            }

            Console.WriteLine("Programa Encerrado!");
        }

        static void Exercicio03()
        {
            string continuar = "sim";

            while (continuar != "sair")
            {
                Console.WriteLine("==============Estrutura Condicional===================");
                Console.WriteLine();

                // Exibe a tabela de produtos
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║          CARDÁPIO - LANCHONETE           ║");
                Console.WriteLine("╠═══════╦═══════════════════════╦══════════╣");
                Console.WriteLine("║ Cód.  ║ Especificação         ║ Preço    ║");
                Console.WriteLine("╠═══════╬═══════════════════════╬══════════╣");
                Console.WriteLine("║   1   ║ Cachorro Quente       ║ R$ 4,00  ║");
                Console.WriteLine("║   2   ║ X-Salada              ║ R$ 4,50  ║");
                Console.WriteLine("║   3   ║ X-Bacon               ║ R$ 5,00  ║");
                Console.WriteLine("║   4   ║ Torrada simples       ║ R$ 2,00  ║");
                Console.WriteLine("║   5   ║ Refrigerante          ║ R$ 1,50  ║");
                Console.WriteLine("╚═══════╩═══════════════════════╩══════════╝");
                Console.WriteLine();

                //Solicita o código do produto ao usuário
                Console.Write("Digite o código do produto desejado: ");
                int codigo = int.Parse(Console.ReadLine()!);

                //Solicita a quantidade do produto ao usuário
                Console.Write("Digite a quantidade desejada: ");
                int quantidade = int.Parse(Console.ReadLine()!);

                //Define o preço com base no código do produto
                double preco = 0.0;

                switch (codigo)
                {
                    case 1: preco = 4.00; break;
                    case 2: preco = 4.50; break;
                    case 3: preco = 5.00; break;
                    case 4: preco = 2.00; break;
                    case 5: preco = 1.50; break;
                    default:
                        Console.WriteLine("Código inválido. Por favor, tente novamente.");
                        return;
                }

                //Calcula o valor total
                double valorTotal = preco * quantidade;

                //Exibe o valor total a pagar
                Console.WriteLine($"O valor total a pagar é: R$ {valorTotal:F2}");

                Console.WriteLine("Digite 'sair' para encerrar ou pressione ENTER para continuar...");
                continuar = Console.ReadLine()!.ToLower();
                Console.Clear();
            }

            Console.WriteLine("Programa Encerrado!");
        }

        static void Exercicio04()
        {   
            string continuar = "sim";

            while (continuar != "sair")
            {
                Console.WriteLine("=== CÁLCULO DAS RAÍZES DE UMA EQUAÇÃO DO 2º GRAU ===");
                //Coeficientes da equação
                double a = 0.0;
                double b = 0.0;
                double c = 0.0;

                Console.WriteLine("Digite o valor de A: ");
                a = double.Parse(Console.ReadLine()!);

                Console.WriteLine("Digite o valor de B: ");
                b = double.Parse(Console.ReadLine()!);

                Console.WriteLine("Digite o valor de C: ");
                c = double.Parse(Console.ReadLine()!);

                Console.WriteLine();

                if (a != 0.0 && (b * b - 4 * a * c) >= 0.0)
                {
                    double delta = b * b - 4 * a * c;
                    double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine($"As raízes da equação são: R1 = {raiz1:F5} e R2 = {raiz2:F5}");
                }
                else
                {
                    Console.WriteLine("Impossível calcular as raízes da equação com os valores fornecidos.");
                }

                Console.WriteLine("Digite 'sair' para encerrar ou pressione ENTER para continuar...");
                continuar = Console.ReadLine()!.ToLower();
                Console.Clear();
            }
            

        }

    }
}