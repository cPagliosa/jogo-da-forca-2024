using System;
using System.Collections;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Jogo jogo = new Jogo();
                jogo.Iniciar();
                Console.WriteLine("\n\nVocê quer rejogar?\n[1] Sim   [2] Não");
                Console.Write("qual a sua escolha: ");
                int h = Convert.ToInt32(Console.ReadLine());
                if (h == 2) break;

            }
        }
    }
}
 


