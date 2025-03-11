using ScreenSound2.Menus;
using ScreenSound2.Modelos;
using OpenAI;

// var client = new OpenAI("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");

namespace ScreenSound2;
internal static class Program
{
    private static void Main(string[] args)
    {
        Banda ira = new Banda("Ira!");
        ira.AdicionarNota(new Avaliacao(10));
        ira.AdicionarNota(new Avaliacao(8));
        ira.AdicionarNota(new Avaliacao(6));
        Banda beatles = new Banda("The Beatles");

        Dictionary<string, Banda> bandasRegistradas = new();
        bandasRegistradas.Add(ira.Nome, ira);
        bandasRegistradas.Add(beatles.Nome, beatles);

        Dictionary<int, Menu> opcoes = new();
        opcoes.Add(1, new MenuRegistrarBanda());
        opcoes.Add(2, new MenuRegistrarAlbum());
        opcoes.Add(3, new MenuMostrarBandasRegistradas());
        opcoes.Add(4, new MenuAvaliarBanda());
        opcoes.Add(5, new MenuAvaliarAlbum());
        opcoes.Add(6, new MenuExibirDetalhes());
        opcoes.Add(0, new MenuSair());

        void ExibirLogo()
        {
            Console.WriteLine(@"
            
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
            ");
            Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
        }

        void ExibirOpcoesDoMenu()
        {
            ExibirLogo();
            Console.WriteLine("\nDigite 1 para registrar uma banda");
            Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
            Console.WriteLine("Digite 3 para mostrar todas as bandas");
            Console.WriteLine("Digite 4 para avaliar uma banda");
            Console.WriteLine("Digite 5 para avaliar um álbum");
            Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
            Console.WriteLine("Digite 0 para sair");

            Console.Write("\nDigite a sua opção: ");
            string opcaoEscolhida = Console.ReadLine()!;
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

            if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
                menuASerExibido.Executar(bandasRegistradas);
                if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
            } else 
            {
                Console.WriteLine("Opção inválida");
            }
        }
        ExibirOpcoesDoMenu();
    }
}