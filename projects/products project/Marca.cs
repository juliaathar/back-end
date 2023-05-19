namespace products_project
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }
        List<Marca> ListaMarca = new List<Marca>();

        public Marca()
        { }
        public Marca(int Codigo, string NomeMarca)
        {
            this.Codigo = Codigo;
            this.NomeMarca = NomeMarca;
        }

        public Marca Cadastrar()
        {
            Marca novaMarca = new Marca();

            DataCadastro = DateTime.Now;
            Console.Write($"Informe o codigo da marca:");
            int codigo = int.Parse(Console.ReadLine());

            novaMarca = ListaMarca.Find(x => x.Codigo == codigo);

            if (novaMarca == null)
            {
                novaMarca = new Marca();
                novaMarca.Codigo = codigo;
                Console.Write($"Informe o nome da marca:");
                novaMarca.NomeMarca = Console.ReadLine().ToUpper();

                ListaMarca.Add(novaMarca);
                return novaMarca;
            }
            else
            {
                Console.WriteLine($"A marca já existe! *{novaMarca.NomeMarca}*");
                return novaMarca;   
            }

        }
        public List<Marca> Listar()
        {
            foreach (var item in ListaMarca)
            {
                Console.WriteLine(@$"
                Nome da Marca : {item.NomeMarca}
                Código : {item.Codigo}
                Data de cadastro : {item.DataCadastro}");
            }
            return ListaMarca;
        }
        public void Deletar()
        {
            Console.WriteLine($"Qual marca você deseja deletar? Digite seu código");
            string nomeExcluir = Console.ReadLine().ToUpper();

            ListaMarca.FindIndex(x => x.NomeMarca == nomeExcluir);
        }

    }
}