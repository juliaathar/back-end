// 2 - Faça um programa que leia um nome de usuário e a sua senha e não
// aceite a senha igual ao nome do usuário, mostrando uma mensagem de erro
// e*voltando a pedir as informações

Console.Write($"Digite seu nome de usuário:");
string name = Console.ReadLine();

Console.Write($"Digite sua senha:");
string password = Console.ReadLine();

while (name == password)
{
    Console.Write($"Digite uma senha diferente do seu nome de usuário.");
    password = Console.ReadLine();
}

Console.WriteLine($"Cadastro efetivado!");
