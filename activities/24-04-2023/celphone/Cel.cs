namespace celphone
{
    public class Cel
    {
        public string cor;
        public string modelo;
        public string tamanho;
        public bool ligado;

        public void ligarCelular()
        {
            Console.WriteLine($"Seu celular está ligado!");
            ligado = true;
        }
        public void desligarCelular()
        {
            Console.WriteLine($"Seu celular está desligado!");
            ligado = false;
        }

        public void fazerLigacao(string destinatario)
        {
            if (ligado == true)
            {
                Console.WriteLine($"Ligando para {destinatario}...");
            }
            else
            {
                Console.WriteLine($"Ligue seu celular para fazer uma ligação.");
            }
        }
        public void enviarMensagem(string destinatario, string mensagem)
        {
            if (ligado == true)
            {
                Console.WriteLine(@$"ENVIANDO A MENSAGEM: 
                '{mensagem}'
                para: {destinatario}");
            }
            else
            {
                Console.WriteLine($"Ligue seu celular para enviar uma mensagem.");
            }
        }
    }
}