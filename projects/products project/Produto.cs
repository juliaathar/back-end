namespace products_project
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca { get; set; }
        public Usuario usuario { get; set; }
        public Usuario CadastradoPor { get; set; }
        List<Produto> ListaDeProdutos = new List<Produto>();
        Usuario ObjetoUsuario = new Usuario();

        public Produto()
        { }

        public Produto(int codigo, string nomeProduto, float preco, Usuario cadastradoPor, DateTime dataCadastro)
        {
            Codigo = codigo;
            NomeProduto = nomeProduto;
            Preco = preco;
            CadastradoPor = cadastradoPor;
            DataCadastro = dataCadastro;
        }

        List<Produto> listProduto = new List<Produto>();

        Marca m = new Marca();
        public void Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.Write($"Informe o código do produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            if (novoProduto == null)
            {
                Console.Write($"Informe o nome do produto:");
                novoProduto.NomeProduto = Console.ReadLine().ToUpper();

                Console.Write($"Informe o preco do produto:");
                novoProduto.Preco = float.Parse(Console.ReadLine());


                novoProduto.Marca = m.Cadastrar();
                DataCadastro = DateTime.Now;

                listProduto.Add(novoProduto);
            }

            else
            {
                Console.WriteLine($"O produto já existe! *{novoProduto.NomeProduto}*");
            }


            Console.Write($"Informe o nome do produto:");
            novoProduto.NomeProduto = Console.ReadLine().ToUpper();

            Console.Write($"Informe o preço do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine());


            novoProduto.Marca = m.Cadastrar();
            DataCadastro = DateTime.Now;

            listProduto.Add(novoProduto);
        }

        public List<Produto> Listar()
        {
            foreach (var item in listProduto)
            {
                Console.WriteLine(@$"
                ╔═══════════════════════════════════════════════╗
                ║Nome do produto : {item.NomeProduto}           ║  
                ║Código do produto : {item.Codigo}              ║
                ║Preço do produto : {item.Preco}                ║
                ║Marca do produto (código) : {item.Marca.Codigo}║
                ╚═══════════════════════════════════════════════╝");

            }

            return listProduto;
        }

        public void Deletar()
        {
            Console.WriteLine($"Informe o nome do produto que deseja excluir:");
            string produtoExcluir = Console.ReadLine().ToUpper();

            Produto produtoBuscado = listProduto.Find(CadaUsuario => CadaUsuario.NomeProduto == produtoExcluir);

            listProduto.Remove(produtoBuscado);
        }
    }
}