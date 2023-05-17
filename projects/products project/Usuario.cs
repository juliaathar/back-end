namespace products_project
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string DataCadastro { get; set; }
        public List<Usuario> ListaDeUsuarios { get; set; }

        public Usuario(int codigo, string nome, string email, string senha)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public void Cadastrar(int codigo, string nome, string email, string senha)
        {
            Console.WriteLine($"Bem vindo ao seu cadastro!");
            Console.WriteLine($"Digite um codigo para seu usuario:");
            Codigo = int.Parse (Console.ReadLine());
            Console.WriteLine($"Digite seu nome:");
            Nome = Console.ReadLine();
            Console.WriteLine($"Digite seu email:");
            Email = Console.ReadLine();
            Console.WriteLine($"Defina uma senha:");
            Senha = Console.ReadLine();

            ListaDeUsuarios.Add(new Usuario(codigo, nome, email, senha));
        }
        public void Deletar(int codigo, string nome, string email, string senha)
        {
            Console.WriteLine($"Qual o código do usuário a ser deletado?");
            int codigoExcluir = int.Parse(Console.ReadLine()); 

            int indice = ListaDeUsuarios.FindIndex(x => x.Codigo == codigoExcluir);
            
            ListaDeUsuarios.RemoveAt(indice);
            indice++;
            ListaDeUsuarios.RemoveAt(indice);
            indice++;
            ListaDeUsuarios.RemoveAt(indice);
            indice++;
            ListaDeUsuarios.RemoveAt(indice);
            indice++;
        }
    }
}