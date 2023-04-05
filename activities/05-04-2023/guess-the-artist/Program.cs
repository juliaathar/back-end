Console.WriteLine($"Bem-vindo ao nosso quiz, adivinhe a idade da Cantora Rihanna :)");

int answer = 0;

do 
{
    Console.WriteLine($"Qual é a idade Rihanna?");
    answer = int.Parse (Console.ReadLine());
} 

while ( answer != 35);

Console.WriteLine($"Você acertou! Shine bright like a diamond!");
