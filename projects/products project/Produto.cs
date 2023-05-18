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
        public List<string> ListaDeProdutos { get; private set; }
        Usuario ObjetoUsuario = new Usuario();



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
            CadastradoPor = ObjetoUsuario.ProcurarUsuario(ObjetoUsuario.Nome);

            return novoProduto;

        }

        //  public List<Produto> Listar()
        //  {
            
        //  }

        public void Deletar ()
        {

        } 
    }
}