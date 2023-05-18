namespace products_project
{
    public class Usuario
    {
        public int Codigo { get; private set; }
        public string Nome { get;  set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        List<Usuario> ListaDeUsuario = new List<Usuario>();

        public Usuario()
        { }
        public Usuario(string email, string senha, string nome)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public string Cadastrar(string novoUsuario)
        {
            Usuario usuario = new Usuario();

            Console.WriteLine($"Bem vindo ao seu cadastro!");
            Console.WriteLine($"Digite um codigo para seu usuario:");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Digite seu email:");
            string email = Console.ReadLine();
            Console.WriteLine($"Defina uma senha:");
            string senha = Console.ReadLine();

            ListaDeUsuario.Add(new Usuario(Email, Senha, Nome));

            return novoUsuario;
        }
        public void Deletar(int codigo, string nome, string email, string senha)
        {
            codigo = 0;
            nome = "";
            email = "";
            senha = "";
            DataCadastro = DateTime.Parse("00-0000-0T00:00:00");
        }
    }
}