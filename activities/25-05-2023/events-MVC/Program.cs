// Criar um programa console Para cadastro de Eventos. Aplique os conceitos MVC aprendidos em sala de aula.

// O evento deve ter Nome, Descrição e Data que o evento ocorrerá.

// As funcionalidades devem ser Cadastrar e Listar.

using events_MVC.Model;
using events_MVC.Controller;

Evento evento = new Evento();
EventoController eventoController = new EventoController();

eventoController.CadastrarEvento();
eventoController.ListarEventos();