// Faça um programa que receba um número inteiro e mostre a sua tabuada.

Console.WriteLine($"Digite um número inteiro e receba sua tabuada!");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n} * {i} = {n * i}");
}
