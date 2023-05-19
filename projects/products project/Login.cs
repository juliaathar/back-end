namespace products_project
{
    public class Login
    {
        public bool Logado { get; private set; }
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
            Escolha se deseja logar ou se cadastrar!
            [1] Logar
            [2] Cadastrar");
                opcaoCadastro = char.Parse(Console.ReadLine());

                switch (opcaoCadastro)
                {
                    case '1':
                        Console.WriteLine($"Insira seu email: ");
                        string email = Console.ReadLine();

                        Console.WriteLine($"Insira sua senha: ");
                        string senha = Console.ReadLine();

                        if (email == usuario.Email && senha == usuario.Senha)
                        {
                            this.Logado = true;
                            Console.WriteLine($"Login efetuado com sucesso !");
                        }
                        else
                        {
                            this.Logado = false;
                            Console.WriteLine($"Falha ao logar !");
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
                        Console.WriteLine($"Opcao invalida, Tente Novamente !");
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
                    break;
                default:
                    break;
            }


        }
    }
}