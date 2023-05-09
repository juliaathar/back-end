// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.


using celphone;

Cel celular = new Cel();

Console.WriteLine($"Olá, nos descreva algumas características do seu celular. Começando pelo sua cor:");
celular.cor = Console.ReadLine();

Console.WriteLine($"Agora nos informe seu modelo:");
celular.modelo = Console.ReadLine();

Console.WriteLine($"E seu tamanho em polegadas:");
celular.tamanho = Console.ReadLine();

Console.WriteLine(@$"Deseja ligar seu celular?
s - Sim
n - nao");
string ligarResposta = Console.ReadLine().ToLower();

if (ligarResposta == "s")
{
    celular.ligarCelular();
    string escolha;

do
{
    Console.WriteLine(@$"Bem vindo ao nosso menu! Escolha o que deseja fazer com seu telefone:
    1- Ligar
    2- Enviar mensagem
    3- Fazer ligação
    4- Desligar
    0 - Sair");
    escolha = Console.ReadLine();

    if (escolha == "1")
    {
        celular.ligarCelular();
    }
    else if (escolha == "2")
    {
        Console.WriteLine($"Para quem deseja enviar mensagem?");
        string destinatario = Console.ReadLine();

        Console.WriteLine($"Digite a mensagem para {destinatario}");
        string mensagem = Console.ReadLine();

        celular.enviarMensagem(destinatario, mensagem);
    }
    else if (escolha == "3")
    {
        Console.WriteLine($"Para quem deseja ligar?");
        string destinatario = Console.ReadLine();

        celular.fazerLigacao(destinatario);
    }
    else if (escolha == "4")
    {
        celular.desligarCelular();
    }
    else
    {
        Console.WriteLine($"Não foi possível identificar. Tente novamente.");
    }
    
} while (escolha != "0");
}
else if (ligarResposta == "n")
{
    celular.desligarCelular();
}
else
{
    Console.WriteLine($"Tente novamente.");
    ligarResposta = Console.ReadLine().ToLower();
}