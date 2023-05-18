namespace products_project
{
    public class Login
    {
        public bool Logado { get; private set; }
        public Login()
        {
            Menu();
        }

        Usuario usuario;
        public void Logar()
        {
            // Console.WriteLine($"Insira seu email");
            // string email = Console.ReadLine();
            // usuario.ListaDeUsuarios.Find(x => x.Email == email);

            // Console.WriteLine($"Insira sua senha");
            // string senha = Console.ReadLine();
            // usuario.ListaDeUsuarios.Find(x => x.Senha == senha);


            // if (usuario.Email == email && usuario.Senha == senha)
            // {
            //     this.Logado = true;
            //     Console.WriteLine($"Login efetuado com sucesso");
            // }
            // else
            // {
            //     this.Logado = false;
            //     Console.WriteLine($"Falha ao logar");
            // }

        }

        public void Deslogar()
        {

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