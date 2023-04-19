// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:

// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.

string[] nome = new string[10];
float[] preco = new float[10];
bool[] promocao = new bool[10];
char produtoEmPromocao;
char acao;
// string resposta;


do
{
    Console.WriteLine(@$"Bem vindo ao nosso programa de gerenciamento de produtos! O que deseja fazer?
1- Cadastrar produtos
2- Listar produtos
3- Ver produtos em promoção
0 - Fechar sistema");
    acao = char.Parse(Console.ReadLine());
    switch (acao)
    {
        case '1':
            char resposta;
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Qual o nome do produto?");
                    nome[i] = Console.ReadLine();

                    Console.WriteLine($"Qual o preço do produto?");
                    preco[i] = float.Parse(Console.ReadLine());

                    Console.WriteLine(@$"O produto está em promoção?
                1- sim
                2- não");
                    produtoEmPromocao = char.Parse(Console.ReadLine());

                    if (produtoEmPromocao == '1')
                    {
                        promocao[i] = true;
                    }
                    else
                    {
                        promocao[i] = false;
                    }
                }

                Console.WriteLine($"{nome} cadastrado!");

                Console.WriteLine(@$"Deseja cadastrar um novo produto?
            1- sim
            2- não");
                resposta = char.Parse(Console.ReadLine());
            }
            while (resposta == '1');
            break;

        case '2':
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(@$"
            Nome do produto: {nome[i]}.
            Preco do produto: {preco[i]}.");
            }
            break;
        case '3':

            for (int i = 0; i < 10; i++)
            {
                if (promocao[i] == true)
                {
                    Console.WriteLine($"O produto {nome[i]} está com desconto!");
                }
            }
            break;

        case '0':
            Console.WriteLine($"Fechando sistema...");
            break;
        default:
            Console.WriteLine($"Não foi possivel reconhecer sua escolha, tente novamente.");
            break;
    }
} while (acao != 0);

