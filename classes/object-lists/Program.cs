// Criar uma lista de objetos(produtos)

using object_lists;

// CREATE
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

// UPDATE

// acessar um objeto da lista para poder manipular
Produto produtoEncontrado = produtos.Find(x => x.Codigo == 1235);

// encontrar o indice do produto encontrado
int index = produtos.IndexOf(produtoEncontrado);

// exibir o indice no console
Console.WriteLine($"O indice do produto encontrado e o: {index}");

// fazer alteracoes 
produtoEncontrado.Preco = 599.99f;

// remover item antigo da lista
produtos.RemoveAt(index);

// devolver o item atualizado no lugar
produtos.Insert(index,produtoEncontrado);

Console.WriteLine($"Produtos depois da atualizacao");


foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");  
}

// DELETE 

produtos.RemoveAt(1);

foreach (var item in produtos)
{
    Console.WriteLine($"Código: {item.Codigo}, Nome: {item.Nome}, Preço: {item.Preco:C}");  
}