namespace static_classes
{
    public static class ConversorTemperatura
    {
        public static float Temperatura {get; set;}
       public static float CelsiusParaFahreinheit(float temperaturaCelsius)
       {
        Temperatura = temperaturaCelsius;

        float fahreinheit = (temperaturaCelsius * 1.8f) + 32;

        return fahreinheit;
       }

       public static float FahreinheitParaCelsius(float temperaturaFahreinheit)
       {
        Temperatura = temperaturaFahreinheit;

        float celsius = (temperaturaFahreinheit - 32) / 1.8f;

        return celsius;
       }
    }
}