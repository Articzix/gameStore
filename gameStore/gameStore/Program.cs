class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Jogos disponíveis:");
            Venda.ExibirJogos();
            Console.WriteLine("Digite o ID do jogo que deseja comprar ou 0 para sair:");

            if (int.TryParse(Console.ReadLine(), out int escolha) && escolha == 0)
            {
                break;
            }

            Venda.VenderJogo(escolha);
            Console.WriteLine();
        }
    }
}
