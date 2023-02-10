using bytebank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.Agencia = 15;
contaAndre.Titular = "André Silva";
contaAndre.Conta = "1010-X";
contaAndre.Saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaAndre.Saldo);

contaAndre.Deposito(100);

Console.WriteLine("Saldo da conta do André pós deposito = " + contaAndre.Saldo);

if(contaAndre.Saque(100) == true) {
    Console.WriteLine("Saldo da conta do André pós saque = " + contaAndre.Saldo);
} else {
    Console.WriteLine("Não foi possível efeturar o saque.");
}


