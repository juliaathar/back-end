// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair

// criar esquema que o usuario digite uma senha para acessar menu
// validacao da senha


// fazer menu com 3 funcoes: cadastrar, listar e sair

// colher dados: nome, origem, destino, data de voo (repetir 5 vezes)

class Program
{
    static List<string[]> passagens = new List<string[]>();

    static void Main()
    {
        Console.WriteLine($"Bem vindo ao nosso programa de compania aerea! Nos informe seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine($"Para acessar nosso sistema digite sua senha:");
        string senha = Console.ReadLine();

        bool senhaValida = ValidarSenha(senha);

        if (senhaValida)
        {
            Console.WriteLine($"{nome}, seu login foi efetuado com sucesso!");

            MostrarMenu();
        }
        else
        {
            Console.WriteLine($"Falha ao logar. Tente novamente.");
        }
    }

    static bool ValidarSenha(string senha)
    {
        string senhaDefinida = "123456";
        return senha == senhaDefinida;
    }

    static void MostrarMenu()
    {
        Console.WriteLine(@$"Agora escolha o que deseja fazer no menu:
1- Cadastrar passagem
2- Listar Passagens
0- Sair");
        char acao = char.Parse(Console.ReadLine());

        switch (acao)
        {
            case '1':
                CadastrarPassagem();
                break;

            case '2':
                ListarPassagens();
                break;

            case '0':
                Console.WriteLine("Saindo...");
                break;

            default:
                Console.WriteLine("Opção inválida!");
                MostrarMenu();
                break;
        }
    }

    static void CadastrarPassagem()
    {
        List<string[]> passagens = new List<string[]>();

        for (int quantidadeUsuario = 0; quantidadeUsuario < 5; quantidadeUsuario++)
        {

            Console.WriteLine($"Digite seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine($"{nome}, agora digite sua origem:");
            string origem = Console.ReadLine();

            Console.WriteLine($"Agora informe para onde quer ir:");
            string destino = Console.ReadLine();

            Console.WriteLine($"Qual a data de voo desejada?");
            string data = Console.ReadLine();

            Console.WriteLine($"Ok, {nome}, sua viagem esta marcada para {data}");

            string[] dadosPassagem = { nome, origem, destino, data };
            passagens.Add(dadosPassagem);

        }
        VoltarAoMenu();
    }

    static void ListarPassagens()
    {
        if (passagens.Count == 0)
        {
            Console.WriteLine("Não há passagens cadastradas!");
        }
        else
        {
            Console.WriteLine("Passagens cadastradas:");

            for (int unidadePassagem = 0; unidadePassagem < passagens.Count; unidadePassagem++)
            {
                string[] dadosPassagem = passagens[unidadePassagem];

                Console.WriteLine($"Passagem {unidadePassagem + 1}:");

                Console.WriteLine($"Nome do passageiro: {dadosPassagem[0]}");
                Console.WriteLine($"Origem: {dadosPassagem[1]}");
                Console.WriteLine($"Destino: {dadosPassagem[2]}");
                Console.WriteLine($"Data marcada para o voo: {dadosPassagem[3]}");
            }
        }

        VoltarAoMenu();
    }

    static void VoltarAoMenu()
    {
        Console.WriteLine(@$"Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
        MostrarMenu();
    }
}