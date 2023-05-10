// Crie uma classe chamada: "Produto"
// Crie as propriedades: Código, Nome, Preço
// Crie um construtor vazio dessas classes
// Crie um construtor com todos os atributos

// atalho: ctor

namespace object_lists
{
    public class Produto
    {
        public int Codigo { get; set; }
        public float Preco { get; set; }
        public string Nome { get; set; }

        public Produto()
        {

        }

        public Produto(int codigo, float preco, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }
    }
}