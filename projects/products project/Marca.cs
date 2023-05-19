namespace products_project
{
    public class Marca
    {
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public DateTime DataCadastro { get; private set; }
        List<Marca> ListaMarca = new List<Marca>();

        public Marca(int Codigo, string NomeMarca)
        {
            this.Codigo = Codigo;
            this.NomeMarca = NomeMarca;
        }

        public void Cadastrar()
        {
            Console.Write(@$"
            Cadastre sua marca!
            Nome da marca:");
            NomeMarca = Console.ReadLine();

            Console.Write($"Codigo da marca:");
            Codigo = int.Parse(Console.ReadLine());

            ListaMarca.Add(new Marca(Codigo, NomeMarca));
        }

        public void Deletar()
        {
            Console.WriteLine($"Qual marca voce deseja deletar? Digite seu codigo");
            string nomeExcluir = Console.ReadLine().ToUpper();

            int indice = ListaMarca.FindIndex(x => x.NomeMarca == nomeExcluir);
            if (indice != -1)
            {
                ListaMarca.RemoveAt(indice);
                indice++;
                ListaMarca.RemoveAt(indice);
            }
            else
            {

            }
        }
        public void ProcurarMarcas(int codigo)
        {
            Marca marca = ListaMarca.Find((x => x.Codigo == codigo));

            if (marca == null)
            {
                Console.WriteLine(@$"Essa marca nao existe...");
            }
            else
            {

            }
        }
    }
}