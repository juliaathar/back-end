
namespace calculator_class_activity
{
    public class Calculadora
    {
        public float n1;
        public float n2;
        public void Soma(float n1, float n2)
        {
            float resultado = n1 + n2;
            Console.WriteLine($"O resultado e {resultado}");
            
        }
        public void Subtracao(float n1, float n2)
        {
            float resultado = n1 - n2;
            Console.WriteLine($"O resultado e {resultado}");
        }
        public void Multiplicacao(float n1, float n2)
        {
            float resultado = n1 * n2;
            Console.WriteLine($"O resultado e {resultado}");
        }
        public void Divisao(float n1, float n2)
        {
            float resultado = n1 / n2;
            Console.WriteLine($"O resultado e {resultado}");
        }
    }
}