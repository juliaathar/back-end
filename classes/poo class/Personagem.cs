namespace poo_class
{
    public class Personagem
    {
        public string nome = "Tony Stark";
        public int idade = 35;
        public string armadura = "Bleeding Edge";
        public string IA = "Jarvis";

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
