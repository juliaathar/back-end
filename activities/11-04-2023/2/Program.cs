// escreva um programa que receba e imprima a idade de 5 pessoas

// exemplo:
// nome: carlos
// idade: 36 anos   

string[] names = new string[5];
int[] ages = new int[5];

Console.WriteLine($"Neste programa, digite o nome e idade de 5 pessoas.");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o nome da {i + 1}º pessoa");
    names[i] = Console.ReadLine();

    Console.WriteLine($"Digite a idade da {i + 1}º pessoa");
    ages[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    Console.ResetColor();
    Console.WriteLine(@$"{i + 1})");

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Nome:{names[i]}");

    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Idade: {ages[i]}");
}
