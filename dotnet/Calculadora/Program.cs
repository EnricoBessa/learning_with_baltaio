using System;
namespace Calculadora
{
    class Program
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("------ SOMA ------");
            Soma();
            Console.WriteLine("------ SUBTRACAO ------");
            Subtracao();
            Console.WriteLine("------ MULTIPLICACAO ------");
            Multiplicacao();
            Console.WriteLine("------ DIVISAO ------");
            Divisao();
        }

        static void Soma()
        {
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


