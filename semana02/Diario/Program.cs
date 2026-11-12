using System;

class Program
{
    static void Main()
    {
        Diario meuDiario = new Diario();

        string opcao = "";

        while (opcao != "5")
        {
            Console.WriteLine("\n===== MEU DIÁRIO =====");
            Console.WriteLine("1. Escrever um registro");
            Console.WriteLine("2. Exibir o diário");
            Console.WriteLine("3. Salvar o diário");
            Console.WriteLine("4. Carregar o diário");
            Console.WriteLine("5. Sair");

            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                Registro registro1 = new Registro();

                List<string> perguntas = new List<string>()
                {
                    "Qual foi a melhor parte do seu dia?",
                    "Qual foi a maior aventura hoje?",
                    "Qual é a novidade do dia?",
                    "O que você aprendeu hoje?",
                    "Pelo que você é grato hoje?"
                };

                Random sorteio = new Random();

                int numero = sorteio.Next(perguntas.Count);

                registro1._pergunta = perguntas[numero];

                Console.WriteLine(registro1._pergunta);

                registro1._resposta = Console.ReadLine() ?? "";

                registro1._data = DateTime.Now.ToString("dd/MM/yyyy");

                meuDiario.AdicionarRegistro(registro1);

                Console.WriteLine("Registro adicionado ao diário!");
                break;

                case "2":
                    meuDiario.ExibirRegistros();
                    break;

                case "3":
                    Console.WriteLine("Digite o nome do arquivo: ");
                    string nomeArquivo = Console.ReadLine() ?? "";

                    meuDiario.SalvarArquivo(nomeArquivo);

                    Console.WriteLine("Diário Salvo com sucesso!");
                    break;

                case "4":
                    Console.Write("Digite o nome do arquivo: ");
                    string arquivoCarregar = Console.ReadLine() ?? "";

                    if (File.Exists(arquivoCarregar))
                    {
                        meuDiario.CarregarArquivo(arquivoCarregar);
                        Console.WriteLine("Diário carregado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Arquivo não encontrado!");
                    }
                    break;

                case "5":
                    Console.WriteLine("Encerrando o diário...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}