using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cronometro_Balta
{
    internal class Program
    {
        public static void Start(int Time) //despara o cronometro;
        {
            
            int currentTime = 0;
            while (currentTime != Time)
            {
                Console.Clear();
                currentTime++;
                Console.Write(currentTime);
                Thread.Sleep(1000); //THREAD(EXECUÇÃO ATUAL) SLEEP (DESCANSO) () TEMPO. 1000 milisegundos = 1 segundo

            }
            Console.Clear();   
            Console.WriteLine("Stopwatch Finalizado");
            Menu();
        }

        public static void Menu() 
        { 
            Console.Clear();
            Console.WriteLine("S = segundo \n M = Minuto \n 0 = Sair \n Quanto tempo deseja contar? \n Ex.: 10s; 5m; "); //1s == 1 seg. 10m == 10m
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1)); //para pegar o ultimo caracter e converter em char.
            int time =int.Parse(data.Substring(0, data.Length -1)); //para pegar a parte inteira.
            int mult = 1;
            if (type == 'm')
                mult = 60;
            if (time == 0)
                System.Environment.Exit(0); 

            PreStart(time * mult);
        }

        static void PreStart(int time) //Base Preparatoria para a função. ficar melhor ao user
        {
            Console.Clear();
            Console.WriteLine("Ready... Set");
            Thread.Sleep(1000);
            Console.WriteLine("Go!");
            Thread.Sleep(2500);
            Start(time);
            
                    

        }
        static void Main(string[] args)
        {
            Menu(); 
            Console.ReadKey();  
        }
    }
}
