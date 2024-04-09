using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace JogoDaForca.ConsoleApp
{
    internal class Jogo
    {
        private char[] palavraChave;
        private char[] palavraForca;
        private int erro = 0;
        private int acerto = 0;

        public void Iniciar()
        {
            Palavra plv = new Palavra();
            Forca forc = new Forca();

            palavraChave = plv.GerarPalavraChave();
            palavraForca = (char[])palavraChave.Clone();
            palavraForca = plv.EsconderPalavra(palavraForca);

            while (true)
            {
                Console.Clear();
                forc.Desenhar(erro);

                if (erro == 5)
                {
                    string msg = new string(palavraChave);
                    Console.WriteLine($"\n** Você perdeu!!! a palavra era {msg} **\n");
                    break;

                }
                else
                {
                    if (acerto == palavraForca.Length)
                    {
                        Console.WriteLine("\n**Paraben! Você Ganhou!!! **\n");
                        this.MostrarPalavra();
                        break;
                    }
                    this.MostrarPalavra();
                    ErroCerto(this.Entrada());
                }

            }
        }

        private void ErroCerto(char c)
        {
            bool errouu = true;
            for (int i = 0; i < palavraChave.Length; i++)
            {
                if ((palavraForca[i] == c))
                {

                }
                else if (palavraChave[i] == c)
                {
                    palavraForca[i] = c;
                    errouu = false;
                    acerto++;
                }

            }
            if (errouu)
            {
                erro++;
            } 
        }

        private void MostrarPalavra()
        {

            for (int i = 0; i < palavraForca.Length; i++)
            {
                Console.Write(palavraForca[i] + " ");

            }
        }

        private char Entrada()
        {
            Console.Write("\nQual é o seu chute? ");
            return Convert.ToChar(Console.ReadLine());
        }
    }
}
