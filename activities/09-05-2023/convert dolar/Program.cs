// Exercício : Faça um programa de conversão de moedas(câmbio) usando classe, membro e métodos estáticos.
// Menu de opções : dólar para real, real para dólar, sair
// Personalizar a resposta, usando recursos da linguagem(Bibliotecas)

using convert_dolar;

// Console.WriteLine(ConversorMoedas.DolarToreal(30));
// Console.WriteLine(ConversorMoedas.RealToDolar(100));

char opcao;

do
{
    Console.WriteLine(@$"
    _______________________________________________
    |                                             |
    |   Bem-vindo ao nosso conversor de moedas!   |
    |           Escolha sua operação:             |
    |                                             |
    |           1 - Dólar para real               |
    |           2 - Real para dólar               |
    |           0 - Sair                          |
    |                                             |
    |_____________________________________________|                             
    ");
    opcao = char.Parse(Console.ReadLine());

    switch (opcao)
    {
        case '1':
            ConversorMoedas.DolarToreal();
            break;
        case '2':
        ConversorMoedas.RealToDolar();
            break;
        default:
            break;
    }


} while (opcao != 0);