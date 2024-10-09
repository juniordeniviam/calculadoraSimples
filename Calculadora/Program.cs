using System;
using Calculadora.Calculadora;

namespace Calculadora.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo à calculadora simples em .NET 8!");

            while (true)
            {
                // Exibir as opções de operação
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Sair");

                // Ler a escolha do usuário
                string? opcao = Console.ReadLine();

                if (opcao == "5")
                {
                    Console.WriteLine("Encerrando a calculadora. Até logo!");
                    break;
                }

                // Ler e validar os dois números de entrada
                double numero1 = LerNumero("Digite o primeiro número:");
                double numero2 = LerNumero("Digite o segundo número:");

                // Executar a operação escolhida
                double resultado = 0;
                CalculadoraSimples calc = new CalculadoraSimples();

                switch (opcao)
                {
                    case "1":
                        resultado = calc.Adicionar(numero1, numero2);
                        Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultado}");
                        break;
                    case "2":
                        resultado = calc.Subtrair(numero1, numero2);
                        Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultado}");
                        break;
                    case "3":
                        resultado = calc.Multiplicar(numero1, numero2);
                        Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultado}");
                        break;
                    case "4":
                        if (numero2 != 0)
                        {
                            resultado = calc.Dividir(numero1, numero2);
                            Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: divisão por zero não é permitida.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha uma operação válida.");
                        break;
                }
            }
        }

        static double LerNumero(string mensagem)
        {
            double numero;
            while (true)
            {
                Console.WriteLine(mensagem);
                string? input = Console.ReadLine();

                if (double.TryParse(input, out numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
                }
            }
        }
    }
}
