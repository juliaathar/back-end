namespace products_project
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public Marca Marca { get; private set; }
        public Usuario usuario { get; private set; }
        public Usuario CadastradoPor { get; private set; }
        List<Produto> ListaDeProdutos = new List<Produto>();
        Usuario ObjetoUsuario = new Usuario();

        public Produto(int codigo, string nomeProduto, float preco, Usuario cadastradoPor, DateTime dataCadastro)
        {
            Codigo = codigo;
            NomeProduto = nomeProduto;
            Preco = preco;
            CadastradoPor = cadastradoPor;
            DataCadastro = dataCadastro;
        }

        public string Cadastrar(string novoProduto)
        {
            Console.WriteLine(@$"
            Vamos cadastrar seu produto!
            Informe o codigo do produto:");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o nome do produto?");
            NomeProduto = Console.ReadLine();

            Console.WriteLine($"Qual o preco do produto?");
            Preco = float.Parse(Console.ReadLine());

            Console.WriteLine($"Qual o codigo da marca?");
            int codigoMarca = int.Parse(Console.ReadLine());

            Marca.ProcurarMarcas(codigoMarca);
            ObjetoUsuario.Nome = CadastradoPor.Nome;
            DataCadastro = DateTime.Now;

            ListaDeProdutos.Add(new Produto(Codigo, NomeProduto, Preco, CadastradoPor, DataCadastro));

            return NomeProduto;

        }

        public List<Produto> Listar()
        {
            foreach (var produto in ListaDeProdutos)
            {
                Console.WriteLine(@$"
                Codigo: {produto.Codigo}
                Nome: {produto.NomeProduto}
                Preco: {produto.Preco}
                Marca: {produto.Marca}
                Cadastrado por: {produto.Marca}
                Data: {produto.DataCadastro}
                ");

            }

            return ListaDeProdutos;
        }

        public void Deletar()
        {
            Console.WriteLine($"Qual produto voce deseja deletar? Digite o nome");
            string nomeExcluir = Console.ReadLine().ToUpper();

            int indice = ListaDeProdutos.FindIndex(x => x.NomeProduto == nomeExcluir);
            if (indice != -1)
            {
                ListaDeProdutos.RemoveAt(indice);
                indice++;
                ListaDeProdutos.RemoveAt(indice);
                indice++;
                ListaDeProdutos.RemoveAt(indice);
                indice++;
                ListaDeProdutos.RemoveAt(indice);
                indice++;
                ListaDeProdutos.RemoveAt(indice);
                indice++;
                ListaDeProdutos.RemoveAt(indice);
                indice++;
                ListaDeProdutos.RemoveAt(indice);
            }
            else
            {

            }
        }
    }
}