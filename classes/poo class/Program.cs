using poo_class;

Personagem tony = new Personagem();

Console.WriteLine(tony.nome);
Console.WriteLine(tony.idade);
Console.WriteLine(tony.armadura);
Console.WriteLine(tony.IA);

tony.Atacar();

Console.WriteLine(tony.Defender());

tony.RestaurarArmadura();