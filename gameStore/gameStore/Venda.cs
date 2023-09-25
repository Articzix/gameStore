using gameStore;

public static class Venda
{
    public static List<Jogo> jogosDisponiveis = new List<Jogo>
    {
        new Jogo { Id = 1, Nome = "Marvel Spider Man 2", Preco = 250.00M },
        new Jogo { Id = 2, Nome = "Lies of P", Preco = 200.00M },
        new Jogo { Id = 3, Nome = "Final Fantasy XVI", Preco = 150.00M }
    };

    public static void ExibirJogos()
    {
        foreach (var jogo in jogosDisponiveis)
        {
            Console.WriteLine($"{jogo.Id}. {jogo.Nome} - R${jogo.Preco}");
        }
    }

    public static void VenderJogo(int id)
    {
        var jogo = jogosDisponiveis.FirstOrDefault(j => j.Id == id);
        if (jogo != null)
        {
            Console.WriteLine($"Vendido: {jogo.Nome} por R${jogo.Preco}");
            jogosDisponiveis.Remove(jogo);
        }
        else
        {
            Console.WriteLine("Jogo não encontrado.");
        }
    }
}
