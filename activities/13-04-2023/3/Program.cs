// 2 - Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

Console.WriteLine(@$"Bem-vindo(a) ao nosso posto! Escolha o tipo de combustível que irá abastecer seu automóvel:
A- álcool
G- gasolina");
char fuel = char.Parse(Console.ReadLine().ToUpper());

Console.WriteLine($"Quantos litros você deseja?");
int liters = int.Parse(Console.ReadLine());


if (fuel == 'A')
{
    float price = (float)(liters * 4.90);

    if (fuel == 'A' && liters <= 20)
    {
        float desconto = CalculoDesconto(price, 3);
        Console.WriteLine(@$"Seu abastecimento deu R${price} com o desconto de R${desconto}. Ou seja, seu total será de R${price - desconto}");
    }
    else if (fuel == 'A' && liters > 20)
    {
        float desconto = CalculoDesconto(price, 5);
        Console.WriteLine(@$"Seu abastecimento deu R${price} com o desconto de R${desconto}. Ou seja, seu total será de R${price - desconto}");
    }
    else
    {
        Console.WriteLine($"Não foi possível calcular. Tente novamente");
    }
}
else if (fuel == 'G')
{
    float price = (float)(liters * 5.30);

    if (fuel == 'G' && liters <= 20)
    {
        float desconto = CalculoDesconto(price, 4);
        Console.WriteLine(@$"Seu abastecimento deu R${price} com o desconto de R${desconto}. Ou seja, seu total será de R${price - desconto}");
    }
    else if (fuel == 'G' && liters > 20)
    {
        float desconto = CalculoDesconto(price, 6);
        Console.WriteLine(@$"Seu abastecimento deu R${price} com o desconto de R${desconto}. Ou seja, seu total será de R${price - desconto}");
    }
    else
    {
        Console.WriteLine($"Não foi possível calcular. Tente novamente");
    }
}

static float CalculoDesconto(float price, float porcentagem)
{
    return ((porcentagem / 100 * price));
}