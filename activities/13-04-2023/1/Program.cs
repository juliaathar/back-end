//faça um método para calcular imposto sobre a renda

//regras de negócio
//tabela de imposto vs renda
//até $1500 - isento
//de $1501 até $3500 - 20% de imposto
//de $3501 até $6000 - 25% de imposto
//acima de $6000 - 35% de imposto


//receber o renda via console
//chamar o método passando a renda como parâmetro
//exibir o valor do imposto referente á renda 


Console.WriteLine($"Informe a sua renda:");
float renda = float.Parse(Console.ReadLine());

static float CalculoImposto(float renda, float porcentagem)
{
    return (porcentagem / 100 * renda);
}

if (renda <= 1500)
{
    Console.WriteLine($"Você está livre de impostos!");
}
else if (renda <= 3500)
{
    CalculoImposto(renda, 20);
    Console.WriteLine($"O valor do seu imposto é R${CalculoImposto(renda, 20)}");
}
else if (renda <= 6000)
{
    CalculoImposto(renda, 25);
    Console.WriteLine($"O valor do seu imposto é R${CalculoImposto(renda, 25)}");
}
else if (renda > 6000)
{
    CalculoImposto(renda, 35);
    Console.WriteLine($"O valor do seu imposto é R${CalculoImposto(renda, 35)}");
}
else
{
    Console.WriteLine($"Não foi possível calcular. Informe seu salário corretamente.");
}