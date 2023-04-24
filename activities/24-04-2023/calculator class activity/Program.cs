using calculator_class_activity;

Console.WriteLine(@$"Bem vindo a nossa calculadora escolha sua operacao:
1- soma
2- subtracao 
3- multiplicacao
4- divisao");
char operacao = char.Parse(Console.ReadLine());

Console.WriteLine($"Agora informe seu primeiro numero:");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Agora informe seu segundo numero:");
float n2 = float.Parse(Console.ReadLine());

Calculadora calculando = new Calculadora();

if (operacao == '1')
{
    calculando.Soma(n1, n2);
}
else if (operacao == '2')
{
    calculando.Subtracao(n1, n2);
}
else if (operacao == '3')
{
    calculando.Multiplicacao(n1, n2);
}
else if (operacao == '4')
{
    calculando.Divisao(n1, n2);
}