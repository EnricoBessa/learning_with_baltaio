using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("--- STOPWATCH ---");
            Console.WriteLine("Digite como deseja contar o tempo, em segundo ou minuto (para sair escreva 'sair')");
            string tp_tempo = Console.ReadLine().ToLower();
            if (tp_tempo == "sair")
            {
                return;
            }
            Console.WriteLine("Quanto tempo deseja cronometrar?");
            int time = int.Parse(Console.ReadLine());
            int multiplier = 1;
            if (tp_tempo == "minuto")
            {
                multiplier = 60;
            }
            PreStart(time * multiplier);
        }

        static void PreStart(int time){
            Console.WriteLine("Iniciando contagem..");
            Thread.Sleep(1500);
            Start(time);
        }

        static void Start(int time)
        {
            int current_time = 0;
            while (current_time != time)
            {
                Console.Clear();
                current_time++;
                Console.WriteLine(current_time);
                Thread.Sleep(1000);
            }

        }

    }
}