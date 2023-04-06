// 1 - Faça um programa que peça uma nota, entre zero e dez. Mostre uma
// mensagem caso o valor seja inválido e continue pedindo até que o usuário
// informe um valor válido.

Console.WriteLine($"Digite uma nota de 0 a 10!");
int note = int.Parse (Console.ReadLine());

while (note < 0 || note > 10)
{
    Console.WriteLine($"Valor inválido. Digite uma nota de 0 a 10:");
    note = int.Parse (Console.ReadLine());
}