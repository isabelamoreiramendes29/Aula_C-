public class contaCorrente 
{
        public string Titular;
        public int Agencia;
        public int Numero; 
        public double Saldo;

        public contaCorrente (string Titular, int Agencia, int Numero, double Saldo){
                this.Titular = Titular;
                this.Agencia = Agencia;
                this.Numero = Numero;
                this.Saldo = Saldo;

        }

        public bool Sacar(double valorSaque){
                if (Saldo >= valorSaque){
                    Saldo = Saldo - valorSaque;
                    return true
                }
                    return false
        }
}