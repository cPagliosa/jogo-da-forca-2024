using System;
using System.Collections;

namespace JogoDaForca.ConsoleApp
{
    internal class Program
    {
        static LinkedList<string> lista = new LinkedList<string>();
        static Random rnd = new Random();
        static string palavraChave = "";
        static int erros = 0,arcertos = 0;
        static char[] charOriginal;
        static char[] charAux;
        static void Main(string[] args)
        {
            while (true)
            {
                arcertos = 0;
                erros = 0;
                Console.Clear();
                CarregarLista();
                ObterStringAleatoria();
                iniciar();
                Console.WriteLine("\nVocê quer rejogar?\n[1] Sim   [2] Não");
                Console.Write("qual a sua escolha: ");
                int h = Convert.ToInt32(Console.ReadLine());
                if (h == 2) break;

            }
        }

        static void iniciar()
        {
            while (true)
            {
                Console.Clear();
                forca(erros);

                if (erros == 5)
                {
                    
                    Console.WriteLine($"\n** Você perdeu!!! a palavra era {palavraChave} **\n");
                    break;

                }
                else
                {
                    if (arcertos == charAux.Length) {
                        Console.WriteLine("\n**Paraben! Você Ganhou!!! **\n");
                        mostrarPalavra();
                        break;
                    }
                    mostrarPalavra();
                    ErroCerto(entrada());
                }

            }
        }

        static char entrada()
        {
            Console.Write("\nQual é o seu chute? ");
            return Convert.ToChar(Console.ReadLine());
        }

        static void ErroCerto(char c)
        {
            Boolean errouu = true;
            for (int i = 0; i < charOriginal.Length; i++)
            {
                if ((charAux[i] == c))
                {

                }else if (charOriginal[i] == c)
                {
                    charAux[i] = c;
                    errouu = false;
                    arcertos++;
                }
                
            }
            if(errouu)
            {
                erros++;
            }
        }

        static void forca(int i)
        {
            if(i == 0)
            {
                Console.Write(" ________________\n" +
                          " | /          |\n" +
                          " |/\n" +
                          " |\n" +
                          " |\n" +
                          " |\n" +
                          " |\n" +
                          " |\n" +
                          "_|________________\n\n");
            }else if(i == 1)
            {
                Console.Write(" ________________\n\n" +
                          " | /          | \n" +
                          " |/           O \n" +
                          " |\n" +
                          " |\n" +
                          " |\n" +
                          " |\n" +
                          " |\n" +
                          "_|________________\n");
            }else if(i == 2)
            {
                Console.Write(" ________________\n\n" +
                          " | /          | \n" +
                          " |/           O \n" +
                          " |          / X \\ \n" +
                          " |\n" +
                          " |\n" +
                          " |\n" +
                          " |\n" +
                          "_|________________\n");
            }else if(i == 3)
            {
                Console.Write(" ________________\n\n" +
                          " | /          | \n" +
                          " |/           O \n" +
                          " |          / X \\ \n" +
                          " |            X \n" +
                          " |\n" +
                          " |\n" +
                          " |\n" +
                          "_|________________\n\n");
            }else if(i == 4)
            {
                Console.Write(" ________________\n\n" +
                          " | /          | \n" +
                          " |/           O \n" +
                          " |          / X \\ \n" +
                          " |            X \n" +
                          " |           / \n" +
                          " |\n" +
                          " |\n" +
                          "_|________________\n\n");
            }else if(i == 5)
            {
                Console.Write(" ________________\n\n" +
                          " | /          | \n" +
                          " |/           O \n" +
                          " |          / X \\ \n" +
                          " |            X \n" +
                          " |           / \\ \n" +
                          " |\n" +
                          " |\n" +
                          "_|________________\n\n");
            }
            

        }

        static void mostrarPalavra()
        {
            for (int i = 0; i < charAux.Length; i++)
            {
                Console.Write(charAux[i]+" " );
                
            }
        }
        
        static void ObterStringAleatoria()
        {
            int x = rnd.Next(0, lista.Count);

            LinkedListNode<string> Atual = lista.First;
            for (int i = 0; i < x; i++)
            {
                Atual = Atual.Next;
            }

            // Retornar a string no índice aleatório
            palavraChave = Atual.Value;
            charOriginal = palavraChave.ToCharArray();
            charAux = new char[charOriginal.Length];
            Array.Copy(charOriginal,charAux,charOriginal.Length);

            for (int i = 0; i < charAux.Length; i++)
            {
                charAux[i] = '_';
            }
        }

        static void CarregarLista()
        {
            lista.AddLast("ABACATE");
            lista.AddLast("ABACAXI");
            lista.AddLast("ACEROLA");
            lista.AddLast("ACAI");
            lista.AddLast("ARACA");
            lista.AddLast("ABACATE");
            lista.AddLast("BACABA");
            lista.AddLast("BACURI");
            lista.AddLast("BANANA");
            lista.AddLast("CAJA");
            lista.AddLast("CAJU");
            lista.AddLast("CARAMBOLA");
            lista.AddLast("CUPUACU");
            lista.AddLast("GRAVIOLA");
            lista.AddLast("GOIABA");
            lista.AddLast("JABUTICABA");
            lista.AddLast("JENIPAPO");
            lista.AddLast("MACA");
            lista.AddLast("MANGABA");
            lista.AddLast("MANGA");
            lista.AddLast("MARACUJA");
            lista.AddLast("MURICI");
            lista.AddLast("PEQUI");
            lista.AddLast("PITANGA");
            lista.AddLast("PITAYA");
            lista.AddLast("SAPOTI");
            lista.AddLast("TANGERINA");
            lista.AddLast("UMBU");
            lista.AddLast("UVA");
            lista.AddLast("UVAIA");
        }
    }
}