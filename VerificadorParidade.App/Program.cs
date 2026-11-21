using VerificadorParidade.App;

var verificadorParidade = new VerificadorParidade.App.VerificadorParidade();
Console.Write("Número inteiro: ");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(verificadorParidade.EhPar(numero) ? "Par" : "Impar");