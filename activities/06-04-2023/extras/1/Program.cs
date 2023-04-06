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

int sim = 0, nao = 0, mulherSim = 0, homemNao = 0, homem = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(@$"Agora diga seu sexo
    M- mulher
    H- homem");
    char sex = char.Parse(Console.ReadLine().ToUpper());

    Console.WriteLine(@$"Sua opinião sobre o produto é positiva?
    S- sim
    N- não");
    char opiniao = char.Parse(Console.ReadLine().ToUpper());


    if (sex == 'F' && opiniao == 'S')
    {
        mulherSim++;
    }

    else if (sex == 'M' && opiniao == 'N')
    {
        homemNao++;
    }

    else if (sex == 'M')
    {
        homem++;
    }

    if (opiniao == 'S')
    {
        sim++;
    }

    else if (opiniao == 'N')
    {
        nao++;
    }
}

Console.WriteLine($"{sim} pessoas responderam sim, {nao} pessoas responderam nao, {mulherSim} mulheres que responderam sim, {homemNao} responderam nao, {homem} homens participaram.");