// 1 - Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

int ano = 2023;

Console.WriteLine($"Digite seu ano de nascimento:");
int anoNascimento = int.Parse(Console.ReadLine());

int age = ano - anoNascimento;

if (age >= 16)
{
    Console.WriteLine($"Está apto a votar.");
}
else
{
    Console.WriteLine($"Não está apto a votar");
}