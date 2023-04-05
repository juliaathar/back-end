// Escreva     um     programa     que     verifique     a     validade     de     uma     senha     fornecida pelo     usuário. 
// A     senha     válida     é     o     número     1234. 
// Devem     ser    impressas     as    seguintes     mensagens:
// ACESSO    PERMITIDO    caso    a    senha    seja    válida.
// ACESSO    NEGADO    caso    a    senha    seja    inválida.

int senha = 1234;

Console.Write($"Informe sua senha para acessar seu perfil:");
int senhaDigitada = int.Parse (Console.ReadLine());

if (senha == senhaDigitada)
{
    Console.Write($"Acesso aprovado");
       
}
else
{
    Console.Write($"Acesso negado");
    
}