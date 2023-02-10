using bytebank.models;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.Agencia = 15;
contaAndre.Titular.Nome = "André Silva";
contaAndre.Conta = "1010-X";
contaAndre.Saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaAndre.Saldo);

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.Agencia = 20;
contaMaria.Titular.Nome = "Maria Eduarda";
contaMaria.Conta = "1010-5";
contaMaria.Saldo = 350;

Console.WriteLine("Saldo da conta da Maria = " + contaMaria.Saldo);

contaAndre.Transferir(50, contaMaria);

System.Console.WriteLine("Saldo do André = " + contaAndre.Saldo);
System.Console.WriteLine("Saldo da Maria = " + contaMaria.Saldo);

ContaCorrente contaPedro = new ContaCorrente();

contaPedro.Titular.Nome = "Pedro Almeida";