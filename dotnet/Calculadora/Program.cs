using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("Digite com letras minusculas qual operecao vc deseja realizar (soma, subtracao, multiplicacao ou divisao)");
            string resposta = Console.ReadLine();
            switch (resposta)
            {
                case "soma":
                    Soma();
                    break;
                case "subtracao":
                    Subtracao();
                    break;
                case "multiplicacao":
                    Multiplicacao();
                    break;
                case "divisao":
                    Divisao();
                    break;
                default:
                    Console.WriteLine("Digite a resposta da mesma maneira que esta no parentese");
                    Menu();
                    break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("------ SOMA ------");
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float total = valor1 + valor2;
            Console.WriteLine("O primeiro valor " + valor1 + ", o segundo valor " + valor2);
            Console.WriteLine($"Somando os dois totalizando {total}");
            Console.ReadKey();
        }
        static void Subtracao()
        {
            Console.WriteLine("------ SUBTRACAO ------");
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float total = valor1 - valor2;
            Console.WriteLine("O primeiro valor " + valor1 + ", o segundo valor " + valor2);
            Console.WriteLine($"Subtraindo os dois {total}");
            Console.ReadKey();
        }
        static void Multiplicacao()
        {
            Console.WriteLine("------ MULTIPLICACAO ------");
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float total = valor1 * valor2;
            Console.WriteLine("O primeiro valor " + valor1 + ", o segundo valor " + valor2);
            Console.WriteLine($"Multiplicando os dois {total}");
            Console.ReadKey();
        }
        static void Divisao()
        {
            Console.WriteLine("------ DIVISAO ------");
            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            float total = valor1 / valor2;
            Console.WriteLine("O primeiro valor " + valor1 + ", o segundo valor " + valor2);
            Console.WriteLine($"Dividindo os dois {total}");
            Console.ReadKey();
        }
    }

}


