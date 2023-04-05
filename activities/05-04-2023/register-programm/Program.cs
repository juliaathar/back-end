//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viuvo(a)), 'd'(divorciado(a));

Console.Write($"Digite seu nome:");
string name = Console.ReadLine();

while (name.Length == 0)
{
    Console.Write($"Digite um nome válido!");
    name = Console.ReadLine();
    
}

Console.Write($"Digite sua idade:");
int age = int.Parse (Console.ReadLine());

while (age < 0 || age > 100)
{
    Console.Write($"Digite sua idade verdadeira!");
    age = int.Parse (Console.ReadLine());
}

Console.Write($"Informe seu salário:");
float wage = float.Parse (Console.ReadLine());

while (wage <= 0)
{
    Console.Write($"Seu salário tem que ser maior que R$00,00.");
    wage = float.Parse (Console.ReadLine());
}

Console.Write(@$"Informe seu estado civil:
Digite (s) para Solteiro(a)
(c) para Casado(a)
(v) para Viúvo(a)
(d) para Divorciado(a)");
char civil = char.Parse (Console.ReadLine().ToLower());

while (civil != 's' && civil != 'c' && civil != 'v' && civil != 'd')
{
    Console.Write($"Digite um estado civil válido:");
    civil = char.Parse (Console.ReadLine());
}

Console.WriteLine($"Seu cadastro foi concluído com sucesso!");