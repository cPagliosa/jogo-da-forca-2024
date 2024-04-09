using System;

public class Forca
{
	public Forca()
	{
	}

	public void Desenhar(int erros)
	{
        if (erros == 0)
        {
            this.Msg();
            Console.Write(" ________________\n" +
                      " | /          |\n" +
                      " |/\n" +
                      " |\n" +
                      " |\n" +
                      " |\n" +
                      " |\n" +
                      " |\n" +
                      "_|________________\n\n");
        }
        else if (erros == 1)
        {
            this.Msg();
            Console.Write(" ________________\n" +
                      " | /          | \n" +
                      " |/           O \n" +
                      " |\n" +
                      " |\n" +
                      " |\n" +
                      " |\n" +
                      " |\n" +
                      "_|________________\n");
        }
        else if (erros == 2)
        {
            this.Msg();
            Console.Write(" ________________\n" +
                      " | /          | \n" +
                      " |/           O \n" +
                      " |          / X \\ \n" +
                      " |\n" +
                      " |\n" +
                      " |\n" +
                      " |\n" +
                      "_|________________\n");
        }
        else if (erros == 3)
        {
            this.Msg();
            Console.Write(" ________________\n" +
                      " | /          | \n" +
                      " |/           O \n" +
                      " |          / X \\ \n" +
                      " |            X \n" +
                      " |\n" +
                      " |\n" +
                      " |\n" +
                      "_|________________\n\n");
        }
        else if (erros == 4)
        {
            this.Msg();
            Console.Write(" ________________\n" +
                      " | /          | \n" +
                      " |/           O \n" +
                      " |          / X \\ \n" +
                      " |            X \n" +
                      " |           / \n" +
                      " |\n" +
                      " |\n" +
                      "_|________________\n\n");
        }
        else if (erros == 5)
        {
            this.Msg();
            Console.Write(" ________________\n" +
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

    private void Msg()
    {
        Console.WriteLine("Aviso: O Programa só aceita letas Maimaiuscula!!");
    }
}
