// 1. Uma certa empresa fez uma
// pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.    
// O número de pessoas que responderam SIM.

// B.    
// O número de pessoas que responderam NÃO;

// C.   
// O número de mulheres que responderam SIM;

// D.   
// A porcentagem de homens que responderam NÃO entre todos

// E.    
// os homens analisados.

Console.WriteLine($"Será feita uma pesquisa para saber o feedback de um produto.");

int sim = 0, nao = 0, femininosim = 0, masculinonao = 0, masculino = 0;

for (int i = 1; i <= 3; i++)
{
    Console.WriteLine(@$"Informe seu sexo:
    m - mulher
    h - homem");
    char sexo = char.Parse(Console.ReadLine().ToLower());

    Console.WriteLine(@$"Sua opinião sobre o produto é positiva?
    s - sim
    n - não");
    char opiniao = char.Parse(Console.ReadLine().ToLower());


    if (sexo == 'f' && opiniao == 's')
    {
        femininosim++;
    }

    else if (sexo == 'm' && opiniao == 'n')
    {
        masculinonao++;
    }

    else if (sexo == 'm')
    {
        masculino++;
    }

    if (opiniao == 's')
    {
        sim++;
    }

    else if (opiniao == 'n')
    {
        nao++;
    }
}

int total = sim + nao;

float porcentagem = (float) Math.Round((float) masculinonao/total, 2) * 100;


Console.WriteLine($"{sim} pessoas responderam sim, {nao} pessoas responderam nao, {femininosim} mulheres que responderam sim, {porcentagem} responderam nao, {masculino} homens participaram.");
