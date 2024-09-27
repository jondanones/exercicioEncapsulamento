using exercicioEncapsulamento;
using System.Globalization;

OperacaoBanco o;

Console.Write("Entre o número da conta: ");
int conta = int.Parse(Console.ReadLine());
Console.Write("Entre o titular da conta: ");
string titular = Console.ReadLine();
Console.Write("Haverá depósito inicial (s/n)? ");
string confirmaDeposito = Console.ReadLine();

if (confirmaDeposito == "s" || confirmaDeposito == "S") {
    Console.Write("Entre o valor de depósito inicial: ");
    double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    o = new OperacaoBanco(conta, titular, depositoInicial);
}
else {
    o = new OperacaoBanco(conta, titular);
}

Console.WriteLine("Dados da Conta: ");
Console.WriteLine(o);
Console.WriteLine();

Console.Write("Entre um valor para depósito: ");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
o.Deposito(valor);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(o);
Console.WriteLine();

Console.Write("Entre um valor para saque: ");
valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
o.Saque(valor);

Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(o);




