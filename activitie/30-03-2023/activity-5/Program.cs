// As  maçãs custam R$ 0,30 cada se forem compradas    menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.Write($"Quantas maçãs deseja comprar?");
int macas = int.Parse (Console.ReadLine());

if (macas<12)
{
    double preco = macas*0.30;
    Console.WriteLine($"O preço foi {preco}");
}
else if (macas>=12)
{
    double preco = macas*0.25;
    Console.WriteLine($"O preço foi {preco}");
}