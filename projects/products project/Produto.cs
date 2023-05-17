namespace products_project
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string NomeProduto { get; set; }
        private float Preco { get; set; }
        private DateTime DataCadastro { get; set; }
        private Marca Marca { get; set; }
        private Usuario CadastradoPor { get; set; }
        private List<string> ListaDeProdutos { get; set; }

        public void Cadastrar(Produto novoProduto)
        {

        }

         public List<Produto> Listar()
         {
            
         }

        public void Deletar (Produto _produto)
        {

        } 
    }
}