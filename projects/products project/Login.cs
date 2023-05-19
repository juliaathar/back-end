namespace products_project
{
    public class Login
    {
        public bool Logado { get; set; }
        public Login()
        {
            Usuario usuario = new Usuario();
            Logar(usuario);
        }

        public void Logar(Usuario usuario)
        {
            Usuario usuario1 = new Usuario();
            char opcaoCadastro;

            do
            {
                Console.WriteLine(@$"
            Bem-vindo ao nosso programa de produtos
            [1] Fazer Login
            [2] Cadastrar");
                opcaoCadastro = char.Parse(Console.ReadLine());

                switch (opcaoCadastro)
                {
                    case '1':
                        if (usuario.Email == null || usuario.Senha == null)
                        {
                            Console.WriteLine($"Não há nenhum usuário cadastrado no programa, tente fazer seu cadastro");
                            usuario.Cadastrar();
                        }
                        else
                        {
                            Console.WriteLine($"Insira seu email: ");
                            string email = Console.ReadLine();

                            Console.WriteLine($"Insira sua senha: ");
                            string senha = Console.ReadLine();

                            if (email == usuario.Email && senha == usuario.Senha)
                            {
                                Logado = true;
                                Console.WriteLine($"Login efetuado com sucesso!");
                            }
                            else
                            {
                                Logado = false;
                                Console.WriteLine($"Falha ao logar!");
                            }
                        }
                        if (Logado == true)
                        {
                            Menu();
                        }

                        break;
                    case '2':
                        usuario.Cadastrar();
                        break;
                    default:
                        Console.WriteLine($"Opção inválida, tente novamente!");
                        opcaoCadastro = char.Parse(Console.ReadLine());
                        break;
                }
            } while (opcaoCadastro != 1);
        }


        public void Deslogar()
        {
            Logado = false;
        }

        public void Menu()
        {
            Produto produto = new Produto();
            Marca marca = new Marca();

            do
            {
                Console.WriteLine(@$"
 ╔═══════════════════════╗
 ║     Bem-vindo(a)!     ║
 ║   Escolha sua ação:   ║
 ║                       ║
 ║  1- Cadastrar Produto ║
 ║  2- Listar Produto    ║
 ║  3- Remover Produto   ║
 ║═══════════════════════║
 ║  4- Cadastrar Marca   ║
 ║  5- Listar Marca      ║
 ║  6- Remover Marca     ║
 ╚═══════════════════════╝");
                char opcao = char.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case '1':
                        produto.Cadastrar();
                        break;
                    case '2':
                        produto.Listar();
                        break;
                    case '3':
                        produto.Deletar();
                        break;
                    case '4':
                        marca.Cadastrar();
                        break;
                    case '5':
                        marca.Listar();
                        break;
                    case '6':
                        marca.Deletar();
                        break;

                    default:
                        Console.WriteLine($"Opção inválida, tente novamente !");
                        opcao = char.Parse(Console.ReadLine());
                        break;
                }


            } while (true);

        }
    }
}