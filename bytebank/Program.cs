using bytebank.models;

// ContaCorrente contaAndre = new ContaCorrente();
// contaAndre.Agencia = 15;
// contaAndre.Titular.Nome = "André Silva";
// contaAndre.Conta = "1010-X";
// contaAndre.Saldo = 100;

Cliente cliente = new Cliente();

cliente.Nome = "André Silva";
cliente.Cpf = "123456789";
cliente.Profissao = "Analista";

ContaCorrente conta = new ContaCorrente();

conta.Titular = cliente;
conta.Conta = "1010-X";
conta.Agencia = 15;
conta.Saldo = 100;

Console.WriteLine("Titular: " + conta.Titular.Nome);
Console.WriteLine("CPF: " + conta.Titular.Cpf);
Console.WriteLine("Profissão: " + conta.Titular.Profissao);
Console.WriteLine("Agência: " + conta.Agencia);
Console.WriteLine("Número Conta: " + conta.Conta);
Console.WriteLine("Saldo: " + conta.Saldo);

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.Agencia = 20;
contaMaria.Titular.Nome = "Maria Eduarda";
contaMaria.Conta = "1010-5";
contaMaria.Saldo = 350;

// Console.WriteLine("Saldo da conta da Maria = " + contaMaria.Saldo);

// contaAndre.Transferir(50, contaMaria);

// System.Console.WriteLine("Saldo do André = " + contaAndre.Saldo);
// System.Console.WriteLine("Saldo da Maria = " + contaMaria.Saldo);

ContaCorrente contaPedro = new ContaCorrente();

contaPedro.Titular.Nome = "Pedro Almeida";

