// Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string[] nomes = new string[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i}º nome:");
    nomes[i] = Console.ReadLine();
}

Console.WriteLine($"Qual o nome da pessoa que deseja buscar?");
string busca = Console.ReadLine();

bool achou = false;

for (int i = 0; i < 10; i++)
{
    if (busca == nomes[i])
    {
        achou = true;
        break;
    }
}

if (achou)
{
    Console.WriteLine($"ACHEI!");
}
else
{
    Console.WriteLine($"NÃO ACHEI :(");
}