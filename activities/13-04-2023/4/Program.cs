// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade &lt;=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

Console.WriteLine($"Digite o nome do produto:");
string nome = Console.ReadLine();

Console.WriteLine($"Qual foi a quantidade de {nome} que será comprada?");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Qual o valor do item?");
float valor = float.Parse(Console.ReadLine());

float preco = quantidade*valor;

