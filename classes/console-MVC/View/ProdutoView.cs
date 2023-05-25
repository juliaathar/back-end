using console_MVC.model;

namespace console_MVC.View
{
    public class ProdutoView
    {
        //metodo para exibir dados da lista de produtos 
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine(@$"Codigo:{item.Codigo}");
                Console.WriteLine(@$"Nome:{item.Nome}");
                Console.WriteLine(@$"Preco:{item.Preco:C}");
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o nome:");
            novoProduto.Nome = Console.ReadLine();

            Console.WriteLine($"Informe o preco:");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
        }
    }
}