using System;

public class Palavra
{
    private LinkedList<string> lista = new LinkedList<string>();

    public LinkedList<string> Lista { get => lista; set => lista = value; }

    public char[] GerarPalavraChave()
    {
        this.CarregarLista();
        Random rnd = new Random();
        int x = rnd.Next(0, lista.Count);

        LinkedListNode<string> Atual = lista.First;
        for (int i = 0; i < x; i++)
        {
            Atual = Atual.Next;
        }
        string plvChave = Atual.Value;
        char[] chave = plvChave.ToCharArray();
        return chave;
    }
    
    public char[] EsconderPalavra(char[] chave)
    {
        for(int i = 0;i < chave.Length; i++)
        {
            chave[i] = '_';
        }
        return chave;
    }
    private void CarregarLista()
    {
        this.Lista.AddLast("ABACATE");

        this.Lista.AddLast("ABACAXI");
        this.Lista.AddLast("ACEROLA");
        this.Lista.AddLast("ACAI");
        this.Lista.AddLast("ARACA");
        this.Lista.AddLast("ABACATE");
        this.Lista.AddLast("BACABA");
        this.Lista.AddLast("BACURI");
        this.Lista.AddLast("BANANA");
        this.Lista.AddLast("CAJA");
        this.Lista.AddLast("CAJU");
        this.Lista.AddLast("CARAMBOLA");
        this.Lista.AddLast("CUPUACU");
        this.Lista.AddLast("GRAVIOLA");
        this.Lista.AddLast("GOIABA");
        this.Lista.AddLast("JABUTICABA");
        this.Lista.AddLast("JENIPAPO");
        this.Lista.AddLast("MACA");
        this.Lista.AddLast("MANGABA");
        this.Lista.AddLast("MANGA");
        this.Lista.AddLast("MARACUJA");
        this.Lista.AddLast("MURICI");
        this.Lista.AddLast("PEQUI");
        this.Lista.AddLast("PITANGA");
        this.Lista.AddLast("PITAYA");
        this.Lista.AddLast("SAPOTI");
        this.Lista.AddLast("TANGERINA");
        this.Lista.AddLast("UMBU");
        this.Lista.AddLast("UVA");
        this.Lista.AddLast("UVAIA");
    }
    public Palavra()
	{
       

	}
}
