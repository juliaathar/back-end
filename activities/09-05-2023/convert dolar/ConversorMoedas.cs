namespace convert_dolar
{
    public class ConversorMoedas
    {
        public static float ValorDolar { get; private set; } = 5.01f;

        public static float DolarToreal()
        {
            Console.WriteLine($"Qual a quantidade de dolares?");
            float dolar = float.Parse(Console.ReadLine());

            float real = ValorDolar * dolar;
            Console.WriteLine($"Valor em reais R${real}");

            return real;

        }
        public static float RealToDolar()
        {
            Console.WriteLine($"Qual a quantidade de reais?");
            float real = float.Parse(Console.ReadLine());

            float dolar = real / ValorDolar;
            Console.WriteLine($"Valor em dólares ${dolar}");
            return dolar;
        }

    }
}