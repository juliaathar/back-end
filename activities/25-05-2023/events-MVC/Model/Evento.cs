namespace events_MVC.Model
{
    public class Evento
    {
        public string NomeReservante { get; set; }
        public string NomeEvento { get; set; }
        public string DataEvento { get; set; }

        private const string PATH = "Database/Evento.csv";

        public Evento()
        {
            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Evento> Ler()
        {
            List<Evento> eventos = new List<Evento>();

            string[] eventosMarcados = File.ReadAllLines(PATH);

            foreach (var item in eventosMarcados)
            {
                string[] atributos = item.Split(";");

                Evento evento = new Evento();

                evento.NomeReservante = atributos[0];
                evento.NomeEvento = atributos[1];
                evento.DataEvento = atributos[2];

                eventos.Add(evento);

            }

            return eventos;
        }

        public string PrepararLinhasCSV(Evento evento)
        {
            return $"{evento.NomeReservante}; {evento.NomeEvento}; {evento.DataEvento}";
        }

        public void Inserir(Evento evento)
        {
            string[] eventosMarcados = {PrepararLinhasCSV(evento)};

            File.AppendAllLines(PATH, eventosMarcados);
        }
    }
}