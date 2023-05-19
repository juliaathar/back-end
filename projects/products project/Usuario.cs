namespace products_project
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        List<Usuario> ListaDeUsuario = new List<Usuario>();

        public Usuario()
        { }
        public Usuario(string email, string senha, string nome)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
        public void Cadastrar()
        {
            Usuario usuario = new Usuario();

            Console.WriteLine($"Bem vindo ao seu cadastro!");

            Console.WriteLine($"Digite seu nome:");
            Nome = Console.ReadLine();

            Console.WriteLine($"Digite seu email:");
            Email = Console.ReadLine();

            Console.WriteLine($"Defina uma senha:");
            Senha = Console.ReadLine();

            ListaDeUsuario.Add(new Usuario(Email, Senha, Nome));
        }
        public void Deletar()
        {
            Console.WriteLine($"Informe o email do usuário que deseja excluir:");
            string usuarioExcluir = Console.ReadLine().ToUpper();

            Usuario usuarioBuscado = ListaDeUsuario.Find(CadaUsuario => CadaUsuario.Email == usuarioExcluir);

            ListaDeUsuario.Remove(usuarioBuscado);
        }
    }
}