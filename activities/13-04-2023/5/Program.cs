// Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o menor valor lido.

int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite o {i+1}º número:");
    numeros[i] = int.Parse(Console.ReadLine());
}

int maior = numeros[0];
int menor = numeros[0];

for (int i = 1; i < 10; i++)
{
    if (numeros[i] > maior)
    {
        maior = numeros[i];
    }

    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

Console.WriteLine($"O maior valor digitado foi {maior}");
Console.WriteLine($"O menor valor digitado foi {menor}");