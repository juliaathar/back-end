static void barraCarregamento(string texto, int quantidadePontinhos, int tempo)
{
    Console.Write(texto);

    for (var i = 0; i < quantidadePontinhos; i++)
    {
        Console.Write($".");
        Thread.Sleep(tempo);
    }
}

barraCarregamento("Carregando", 5, 1000);
