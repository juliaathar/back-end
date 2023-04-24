
namespace calculator_class_activity
{
    public class Calculadora
    {
        public void Soma(float n1, float n2)
        {
            float resultado = n1 + n2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            
        }
        public void Subtracao(float n1, float n2)
        {
            float resultado = n1 - n2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
        }
        public void Multiplicacao(float n1, float n2)
        {
            float resultado = n1 * n2;
            Console.WriteLine($"O resultado multiplicação é {resultado}");
        }
        public void Divisao(float n1, float n2)
        {
            float resultado = n1 / n2;
            Console.WriteLine($"O resultado divisão é {resultado}");
        }
    }
}