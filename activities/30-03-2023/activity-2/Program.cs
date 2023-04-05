//Desenvolva um programa que recebe do usuário, o placar de um jogo de futebol (os gols de cada time) e informa se o resultado foi um empate, se a vitória foi do primeiro time ou do segundo time.

Console.Write($"Informe a quantidade de gols do primeiro time:");
int golsTime1 = int.Parse (Console.ReadLine());

Console.Write($"Agora informe a quantidade de gols do segundo time:");
int golsTime2 = int.Parse (Console.ReadLine());

if (golsTime1 > golsTime2)
{
    Console.WriteLine($"Time 1 foi vencedor");
}
else if (golsTime2 > golsTime1)
{
    Console.WriteLine($"Time 2 foi vencedor");
}
else
{
    Console.WriteLine($"Teve empate entre os times!");
}
