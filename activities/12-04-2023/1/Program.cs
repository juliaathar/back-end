// criar um métodos para as quatro operações

Console.WriteLine(@$"Olá, escolha qual operação você deseja executar:
1- somar
2- subtrair
3- multiplicar
4- dividir");
char operacao = char.Parse(Console.ReadLine());

Console.Write($"Informe o primeiro número:");
float primeiroNumero = float.Parse(Console.ReadLine());

Console.Write($"Informe o segundo número:");
float segundoNumero = float.Parse(Console.ReadLine());

static float somar(float n1, float n2)
{
    return (n1 + n2);
}

static float subtrair(float n1, float n2)
{
    return (n1 - n2);
}

static float multiplicacao(float n1, float n2)
{
    return (n1 * n2);
}

static float dividir(float n1, float n2)
{
    return (n1 / n2);
}

switch (operacao)
{
    case '1':
        Console.WriteLine($"A soma de {primeiroNumero} + {segundoNumero} é {somar(primeiroNumero, segundoNumero)}");
        break;

    case '2':
        Console.WriteLine($"A subtração de {primeiroNumero} - {segundoNumero} é {subtrair(primeiroNumero, segundoNumero)}");
        break;

    case '3':
        Console.WriteLine($"A multiplicação de {primeiroNumero} * {segundoNumero} é {multiplicacao(primeiroNumero, segundoNumero)}");
        break;

    case '4':
        Console.WriteLine($"A divisão de {primeiroNumero} / {segundoNumero} é {dividir(primeiroNumero, segundoNumero)}");
        break;

    default:
        Console.WriteLine($"Não foi possível realizar a operação. Escolha um operador válido.");
        break;
}
