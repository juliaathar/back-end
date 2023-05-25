
using events_MVC.Model;
using events_MVC.View;

namespace events_MVC.Controller
{
    public class EventoController
    {
        Evento evento = new Evento();
        EventoView eventoView = new EventoView();

        public void ListarEventos()
        {
            List<Evento> eventos = evento.Ler();

            eventoView.Listar(eventos);
        }

        public void CadastrarEvento()
        {
            Evento novoEvento = eventoView.Cadastrar();

            evento.Inserir(novoEvento);
        }
    }

}