//// Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.

Console.WriteLine(@$"Bem vindo, essa aplicação te ajuda com a tabuada!");

for (int fator = 1; fator <= 10; fator++)
{
    Console.WriteLine($"Tabuada do {fator}");
    
    for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
    {
        int produto = fator * multiplicador;
        Console.WriteLine($"{fator} * {multiplicador} = {produto}");
    }

}
