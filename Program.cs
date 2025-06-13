using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mensagem de boas-vindas
            Console.WriteLine("Calculadora Simples em C#");
            Console.WriteLine("Digite o primeiro número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o operador (+, -, *, /):");
            string operador = Console.ReadLine();

            Console.WriteLine("Digite o segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            // Lógica de cálculo com base no operador digitado
            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    // Verifica divisão por zero
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                        Console.WriteLine("Erro: divisão por zero!");
                    break;
                default:
                    Console.WriteLine("Operador inválido.");
                    break;
            }

            // Exibe o resultado (se houver)
            if (operador == "+" || operador == "-" || operador == "*" || (operador == "/" && num2 != 0))
            {
                Console.WriteLine($"Resultado: {resultado}");
            }

            // Espera o usuário apertar Enter antes de encerrar
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
  
