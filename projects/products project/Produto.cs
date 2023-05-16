using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public string Cadastrar()
        {
            Produto novoProduto = new Produto();
            ListaDeProdutos.Add(novoProduto);
        }

        public List<Produto> Listar()
        {
        }
    }
}