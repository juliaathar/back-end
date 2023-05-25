using console_MVC.model;
using console_MVC.Controller;

// instancia do objeto produto
Produto p1 = new Produto();

// instancia do objeto produtoController
ProdutoController pcontroller = new ProdutoController();

// chamada do metodo controlador
pcontroller.CadastrarProduto(); 

// chamada do metodo controlador
pcontroller.ListarProdutos();
