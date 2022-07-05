using System; 

namespace meuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[]args)
        {
            contaCorrente conta_da_Isabela = new contaCorrente("Isabela", 12345, 789, 100);
            contaCorrente conta_da_Maria = new contaCorrente("Maria", 987, 101, 101);
            contaCorrente conta_do_Igor = new contaCorrente("Igor", 32, 121, 10000);

            Console.WriteLine("A conta é do (a) " + conta_da_Isabela.Titular + ", a agência é " + conta_da_Isabela.Agencia + " o numero é " + conta_da_Isabela.Numero + " Saldo: " + conta_da_Isabela.Saldo);
            Console.WriteLine("A conta é do (a) " + conta_da_Maria.Titular + ", a agência é " + conta_da_Maria.Agencia + " o numero é " + conta_da_Maria.Numero + " Saldo: " + conta_da_Maria.Saldo); 
            Console.WriteLine("A conta é do (a) " + conta_do_Igor.Titular + ", a agência é " + conta_do_Igor.Agencia + " o numero é " + conta_do_Igor.Numero + " Saldo: " + conta_do_Igor.Saldo); 

            bool sacar_conta = conta_da_Isabela.Sacar(100);
            bool sacar_conta1 = conta_da_Maria.Sacar(100);
            bool sacar_conta2 = conta_do_Igor.Sacar(100);
          
            Console.WriteLine("A conta é do (a) " + conta_da_Isabela.Titular + ", a agência é " + conta_da_Isabela.Agencia + " o numero é " + conta_da_Isabela.Numero + " Saldo: " + conta_da_Isabela.Saldo);
            Console.WriteLine("A conta é do (a) " + conta_da_Maria.Titular + ", a agência é " + conta_da_Maria.Agencia + " o numero é " + conta_da_Maria.Numero + " Saldo: " + conta_da_Maria.Saldo); 
            Console.WriteLine("A conta é do (a) " + conta_do_Igor.Titular + ", a agência é " + conta_do_Igor.Agencia + " o numero é " + conta_do_Igor.Numero + " Saldo: " + conta_do_Igor.Saldo); 

        }
    }
}
