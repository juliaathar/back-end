namespace console_MVC.model
{
    public class Produto
    {
        // propriedades

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        // caminho da pasta e do caminho definido
        private const string PATH = "Database/Produto.csv";

        // criar construtor
        public Produto()
        {
            string pasta = PATH.Split("/")[0]; //"Database"

            //se não existir uma pasta Database, então cria-se uma 
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            //se não existir um arquivo csv no caminho, então cria-se um
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }

        }
        public List<Produto> Ler()
        {
            //instanciar uma lista de produto
            List<Produto> produtos = new List<Produto>();

            //array de string que recebe cada linha do csv
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                //001;Coca;6,50

                string[] atributos = item.Split(";");

                // atributos[0] = "001"
                // atributos[1] = "Coca"
                // atributos[2] = "6,50"

                Produto p = new Produto();

                p.Codigo = int.Parse(atributos[0]);  // atributos[0] = "001"
                p.Nome = atributos[1];               // atributos[1] = "Coca"
                p.Preco = float.Parse(atributos[2]); // atributos[2] = "6,50"

                produtos.Add(p);
            }

            return produtos;

            // metodo para preparar a linha de csv

        }

        // metodo para preparar a linha de csv
        public string PrepararLinhasCSV(Produto p)
        {
            return $"{p.Codigo}; {p.Nome}; {p.Preco}";
        }

        // metodo para inserir um produto no arquivo csv
        public void Inserir(Produto p)
        {
            // array que vai armazenar as linhas (cada "objeto")
            string[] linhas = { PrepararLinhasCSV(p) };

            // vai ate o arquivo e insere todas as linhas que contem nele 
            File.AppendAllLines(PATH, linhas);
        }
    }
}