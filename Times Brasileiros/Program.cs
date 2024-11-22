using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times_Brasileiros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] time = new string[21];


            time[1] = "Palmeiras";
            time[2] = "Flamengo";
            time[3] = "Corinthians";
            time[4] = "São Paulo";
            time[5] = "Bragantino";
            time[6] = "Fluminense";
            time[7] = "Vasco";
            time[8] = "Atletico MG";
            time[9] = "Atletico PR";
            time[10] = "Cuiaba";
            time[11] = "Cruzeiro";
            time[12] = "Internacional";
            time[13] = "Gremio";
            time[14] = "Criciuma";
            time[15] = "Juventude";
            time[16] = "Fortaleza";
            time[17] = "Vitoria";
            time[18] = "Atletico Go";
            time[19] = "Bahia";
            time[20] = "Botafogo";


            Console.Write("Escolha um numero ente 1 a 20 e descubra o time que você torce ");
            int posição = int.Parse(Console.ReadLine());
            Console.WriteLine($"na posição {posição} se encontra o time {time[posição]}");
            Console.ReadLine();

        }
    }
}
