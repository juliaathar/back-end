namespace elevator
{
    public class Elevador
    {
        public int andarAtual { get; set; }
        public int quantidadeAndares = 10;
        public int capacidadeElevador = 8;
        public int quantidadePessoas { get; set; } 
        public bool inicializar;
        public char sair;
        public char subirOudescer;

        public void Inicializa()
        {
            inicializar = true;
        }
        public void Entrar()
        {
            Console.WriteLine($"Quantas pessoas ha no elevador?");
            quantidadePessoas = int.Parse(Console.ReadLine());

            if (quantidadePessoas > capacidadeElevador)
            {
                Console.WriteLine($"Não é possível inicializar o elevador pois a capacidade foi excedida. A capacidade máxima é de 8 pessoas");
                inicializar = false;
            }
            else if (quantidadePessoas < capacidadeElevador)
            {
                Console.WriteLine($"Inicializando o elevador!");
                inicializar = true;
            }
            else
            {
                Console.WriteLine($"Não é possível incializar o elevador sem saber a quantidade de pessoas presentes!");
                inicializar = false;
            }
        }
        public void Sair()
        {
            switch (sair)
            {
                case 's':
                    quantidadePessoas = quantidadePessoas - 1;
                    break;
                case 'n':
                    quantidadePessoas = quantidadePessoas;
                    break;
                default:
                    Console.WriteLine($"Não foi possível identificar a escolha, tente novamente");
                    break;
            }

        }
        public void Subir()
        {
            Console.WriteLine($"Escolha o andar que deseja ir:");
            int andar = int.Parse(Console.ReadLine());

            if (andar > andarAtual && andar < quantidadeAndares)
            {
                Console.WriteLine($"Subindo...");
            }
            if (andar < andarAtual && andar > quantidadeAndares)
            {
                Console.WriteLine($"Não foi possível identificar o andar, tente novamente.");
            }
        }
        public void Descer()
        {
            Console.WriteLine($"Escolha o andar que deseja ir:");
            int andar = int.Parse(Console.ReadLine());

            if (andar < andarAtual)
            {
                Console.WriteLine($"Descendo...");
            }
            else if (andar > andarAtual)
            {
                Console.WriteLine($"Não foi possível identificar o andar, tente novamente.");
            }
        }
    }
}