//  Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:


// "Telefonou para a vítima?"


// "Esteve no local do crime?"


// "Mora perto da vítima?"


// "Devia para a vítima?"


// "Já trabalhou com a vítima?"

int culpa = 0;

Console.WriteLine(@$"Você irá passar por uma série de perguntas sobre um crime que aconteceu na cidade. Responda honestamente todas as perguntas feitas para que não se torne um suspeito direto. Responda:
Telefonou para a vítima?");
string r1 = Console.ReadLine().ToLower();

if (r1 == "sim")
{
    culpa++;
}

Console.WriteLine($"Esteve no local do crime?");
string r2 = Console.ReadLine().ToLower();
if (r2 == "sim")
{
    culpa += 1;
}

Console.WriteLine($"Mora perto da vítima?");
string r3 = Console.ReadLine().ToLower();
if (r3 == "sim")
{
    culpa += 1;
}

Console.WriteLine($"Devia para a vítima?");
string r4 = Console.ReadLine().ToLower();
if (r4 == "sim")
{
    culpa += 1;
}

Console.WriteLine($"Já trabalhou com a vítima?");
string r5 = Console.ReadLine().ToLower();
if (r5 == "sim")
{
    culpa += 1;
}

if (culpa < 2)
{
    Console.WriteLine($"Você não é suspeito.");

}
else if (culpa == 2)
{
    Console.WriteLine($"Você se tornou suspeito do caso.");

}
else if (culpa == 5)
{
    Console.WriteLine($"Você é o assassino!!!!");
}
else
{
    Console.WriteLine($"Você é um possível cúmplice...");
}