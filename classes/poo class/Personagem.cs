namespace poo_class
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string IA;

        public void Atacar()
        {
            Console.WriteLine($"O {nome} atacou!");
        }
        public string Defender()
        {
            return "O personagem se defendeu!";
        }
        public void RestaurarArmadura()
        {
            Console.WriteLine($"O {nome} está restaurando sua armadura...");
        }
    }
}
