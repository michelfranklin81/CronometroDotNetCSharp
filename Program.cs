using System;
using System.Threading;

namespace StopWatch{
    class Program 
    {
        static void Main(string[] args)
        {

            Menu();
            
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto Tempo deseja contar?");
            
            string data = Console.ReadLine().ToLower();
            // O método substring captura o caractere definido pelo parâmetro. Por exemplo => banana Substring(1,1) ele vai capturar a letra primeira letra que está na primeira posição. Neste caso a letra "a".
            char type = char.Parse(data.Substring(data.Length -1 ,1)); // data.Length percorrerá o array e desconsiderará o último elemento, por isso o -1. Feito isso o ,1 é o parâmetro para capturar a primeira letra do último elemento, ou seja o "s" para segundos ou "m" para minutos
            int time = int.Parse(data.Substring(0,data.Length -1)); // data.Length percorrerá o array a partir do parâmetro zero e desconsiderará o último elemento, por isso o -1. 
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);

                PreStart(time * multiplier);

            
        }

            static void PreStart(int time)
            {
                Console.Clear();
                Console.WriteLine("Ready...");
                Thread.Sleep(1000);
                Console.WriteLine("Set...");
                Thread.Sleep(1000);
                Console.WriteLine("Go...");
                Thread.Sleep(2500);

                Start(time);
            }
        static void Start(int time)
        {

            int currentTime = 0;
            while(currentTime != time)
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);         // Comando para o while esperar um segundo (1k milisegundos) antes de rodar uma nova repetição - Importante adicionar o using. Threading; no topo da tela
                
            }
            Console.Clear();
            Console.WriteLine("StopWatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}