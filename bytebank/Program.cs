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
conta.DefinirSaldo(100);

Console.WriteLine("Titular: " + conta.Titular.Nome);
Console.WriteLine("CPF: " + conta.Titular.Cpf);
Console.WriteLine("Profissão: " + conta.Titular.Profissao);
Console.WriteLine("Agência: " + conta.Agencia);
Console.WriteLine("Número Conta: " + conta.Conta);
Console.WriteLine("Saldo: " + conta.ObterSaldo());

ContaCorrente conta2 = new ContaCorrente();

conta2.Titular = new Cliente(); 

conta2.Titular.Nome = "André Silva";
conta2.Titular.Cpf = "123456789";
conta2.Titular.Profissao = "Analista";
conta2.Titular = cliente;
conta2.Conta = "1010-X";
conta2.Agencia = 15;
conta2.DefinirSaldo(100);

ContaCorrente conta3 = new ContaCorrente();
conta3.DefinirSaldo(200);
System.Console.WriteLine(conta3.ObterSaldo());

