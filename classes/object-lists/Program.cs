// Criar uma lista de objetos(produtos)

using object_lists;

List<Produto> produtos = new List<Produto>();

// inserir objetos de produtos dentro da lista, há duas formas de fazer isso:

// através de uma instância direta (com construtor)
produtos.Add(new Produto (1234, 399.99f, "camisetaLacoste"));


// através de uma instância básica de objetos
Produto camisetaArmani = new Produto (1235, 399.99f, "camisetaArmani");
produtos.Add(camisetaArmani);

// READ 
foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");
}