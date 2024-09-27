using System.Globalization;

namespace exercicioEncapsulamento {
    internal class OperacaoBanco {
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public OperacaoBanco(int conta, string nome) {
            Conta = conta;
            Titular = nome;
        }
        public OperacaoBanco(int conta, string titular, double saldo) : this(conta, titular) {
            Saldo = saldo;
        }

        public void Deposito(double deposito) {
            Saldo += deposito;
        }

        public void Saque(double saque) {
            Saldo -= saque + 5.0;
        }
        public override string ToString() {
            return "Conta: " + Conta + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
