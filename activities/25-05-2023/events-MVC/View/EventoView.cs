
using events_MVC.Model;
using events_MVC.Controller;

namespace events_MVC.View
{
    public class EventoView
    {
        public void Listar(List<Evento> eventos)
        {
            foreach (var item in eventos)
            {
                Console.WriteLine($"Nome do reservante:{item.NomeReservante}");
                Console.WriteLine($"Nome do evento:{item.NomeEvento}");
                Console.WriteLine($"Data do evento:{item.DataEvento}");  
            }
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o nome do reservante:");
            novoEvento.NomeReservante = Console.ReadLine();
            
            Console.WriteLine($"Informe o nome do evento");
            novoEvento.NomeEvento = Console.ReadLine();
            
            Console.WriteLine($"Informe a data do evento:");
            novoEvento.DataEvento = Console.ReadLine();
            
            return novoEvento;
        }
    }
}