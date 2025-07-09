using Prototype;

InimigoA inimigo1 = new InimigoA
{
    Nome = "Inimigo A",
    Cor = "Vermelho",
    Arma = new Arma("Espadas")
};

////// Realizando uma cópia profunda

Inimigo inimigo2 = inimigo1.ShallowCopy();

inimigo1.Arma = new Arma("Machados");

Console.WriteLine($"Inimigo 1: {inimigo1.Nome}, Cor: {inimigo1.Cor}, Arma: {inimigo1.Arma.GetNomeArma()}");

Console.WriteLine($"Inimigo 2: {inimigo2.Nome}, Cor: {inimigo2.Cor}, Arma: {inimigo2.Arma.GetNomeArma()}");


////// Realizando uma cópia rasa


//Inimigo inimigo2 = inimigo1.DeepCopy();

//inimigo1.Arma = new Arma("Machados");

//Console.WriteLine($"Inimigo 1: {inimigo1.Nome}, Cor: {inimigo1.Cor}, Arma: {inimigo1.Arma.GetNomeArma()}");

//Console.WriteLine($"Inimigo 2: {inimigo2.Nome}, Cor: {inimigo2.Cor}, Arma: {inimigo2.Arma.GetNomeArma()}");



////// Saída esperada:

// Inimigo 1: Inimigo A, Cor: Vermelho, Arma: Machados
// Inimigo 2: Inimigo A, Cor: Vermelho, Arma: Faca