int[] numeros = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o {i + 1}º número e veja seu valor dobrado!");
    numeros[i] = int.Parse(Console.ReadLine());
}

foreach (var numero in numeros)
{
    Console.WriteLine($"O dobro do número {numero} é {numero*2}!");
}