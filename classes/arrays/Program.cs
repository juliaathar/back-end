//criar um array de strings para armazenar 3 carros
string[] carros = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Informe o nome do carro: ");    
    carros[i] = Console.ReadLine();    
}

Console.WriteLine($"Lista dos carros cadastrados: ");

// for (var i = 0; i < 3; i++)
// {
//     Console.WriteLine($"Nome do carro: {carros[i]}");    
// }

foreach (var item in carros)
{
    Console.WriteLine(item);    
}