// Crie uma classe abstrata denominada Elevador para armazenar as informações de um elevador
// dentro de um prédio. A classe deve armazenar o andar atual (térreo = 0), total de andares
// no prédio (desconsiderando o térreo), capacidade do elevador e quantas pessoas estão
// presentes nele. A classe deve também disponibilizar os seguintes métodos:
// Inicializa : que deve receber como parâmetros a capacidade do elevador e o total de
// andares no prédio (os elevadores sempre começam no térreo e vazio);
// Entrar : para acrescentar uma pessoa no elevador (só deve acrescentar se ainda houver
// espaço);
// Sair : para remover uma pessoa do elevador (só deve remover se houver alguém
// dentro dele);
// Subir : para subir um andar (não deve subir se já estiver no último andar);
// Descer : para descer um andar (não deve descer se já estiver no térreo);
// Encapsular todos os atributos da classe (criar os métodos set e get).
// Crie também duas subclasses: ELEVADORSOCIAL e ELEVADORSERVIÇO, o elevador de serviço deve ter um método altere o numero de caixas dentro dele.

using elevator;

Elevador elevador = new Elevador();

Console.WriteLine($"Nos informe seu andar atual.");
int andarAtual = int.Parse(Console.ReadLine());

elevador.Entrar();


Console.WriteLine(@$"Voce deseja subir ou descer?
s para subir 
d para descer");
char subirOudescer = char.Parse(Console.ReadLine());

switch (subirOudescer)
{
    case 's':
        elevador.Subir();
        break;
    case 'd':
        elevador.Descer();
        break;
    default:
        break;
}
