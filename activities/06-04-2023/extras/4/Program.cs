//  Pesquise como funciona o algoritmo Fibonacci.
//  Faça um programa que gere a série até que o valor seja maior que 500. 

int num1 = 1;
int num2 = 1;
do
{
    Console.WriteLine($"{num1} é abaixo de 500");
    Console.WriteLine($"{num2} é abaixo de 500");
    num1 = num1 + num2;
    num2 = num2 + num1;
} while (num2 < 500 || num1 < 500);
Console.WriteLine($"{num1} é o primeiro valor que ultrapassa 500");