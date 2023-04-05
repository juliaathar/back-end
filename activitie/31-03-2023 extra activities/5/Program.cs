// Faça um programa que verifique se uma letra digitada é vogal ou consoante
Console.Write($"Informe o caractere desejado:");
string caractere = Console.ReadLine().ToLower();

if (caractere == "a" || caractere == "e" || caractere == "i" || caractere == "o" || caractere == "u")
{
 Console.WriteLine($"Seu caractere é uma vogal.");
}
else
{
    Console.WriteLine($"Seu caractere é uma consoante");
}
