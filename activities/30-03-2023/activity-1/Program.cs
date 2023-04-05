// Faça um programa que o usuário informe o salário recebido e o total gasto. Deverá ser exibido na tela “Gastos dentro do orçamento” caso o valor gasto não ultrapasse o valor do salário e “Orçamento estourado” se o valor gasto ultrapassar o valor do salário.

Console.Write($"Informe seu salário recebido:");
double salarioRecebido = double.Parse (Console.ReadLine());

Console.Write($"Agora informe o total gasto:");
double totalGasto = double.Parse (Console.ReadLine());

double saldo = salarioRecebido - totalGasto;

if (saldo >= 0)
{
    Console.Write($"Gastos dentro do orçamento");
}
else if (saldo <0)
{
    Console.WriteLine($"Orçamento estourado");
}


