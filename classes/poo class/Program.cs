using poo_class;

Personagem p1 = new Personagem();

Console.WriteLine($"Digite o nome do personagem");
p1.nome = Console.ReadLine();

Console.WriteLine($"Digite a idade do personagem");
p1.idade = int.Parse (Console.ReadLine());

Console.WriteLine($"Digite o nome da armadura do personagem");
p1.armadura = Console.ReadLine();

Console.WriteLine($"Digite o nome da IA do personagem");
p1.IA = Console.ReadLine();

Console.WriteLine(@$"
{p1.nome}
{p1.idade}
{p1.armadura}
{p1.IA}");

p1.Atacar();
Console.WriteLine(p1.Defender());
p1.RestaurarArmadura();