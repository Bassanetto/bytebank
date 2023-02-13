using bytebank.models;

 ContaCorrente contaAndre = new ContaCorrente(15, "1010-X");
 contaAndre.DefinirSaldo(200);

Cliente cliente = new Cliente();

cliente.Nome = "André Silva";
cliente.Cpf = "123456789";
cliente.Profissao = "Analista";

Console.WriteLine("================================");
 Console.WriteLine("Titular: " + cliente.Nome);
 Console.WriteLine("CPF: " + cliente.Cpf);
 Console.WriteLine("Profissão: " + cliente.Profissao);
 Console.WriteLine("Agência: " + contaAndre.Agencia);
 Console.WriteLine("Número Conta: " + contaAndre.Conta);
 Console.WriteLine("Saldo: " + contaAndre.ObterSaldo());
Console.WriteLine("================================");
 System.Console.WriteLine("Número de contas:" + ContaCorrente.TotalContasCriadas); 
Console.WriteLine("================================");
 ContaCorrente conta = new ContaCorrente(16, "1515-Y");

 conta.Titular = cliente;
 conta.DefinirSaldo(100);

 Cliente cliente2 = new Cliente();

cliente2.Nome = "Frederico";
cliente2.Cpf = "987654321";
cliente2.Profissao = "Jogador de Tenis";

 Console.WriteLine("Titular: " + cliente2.Nome);
 Console.WriteLine("CPF: " + cliente2.Cpf);
 Console.WriteLine("Profissão: " + cliente2.Profissao);
 Console.WriteLine("Agência: " + conta.Agencia);
 Console.WriteLine("Número Conta: " + conta.Conta);
 Console.WriteLine("Saldo: " + conta.ObterSaldo());
Console.WriteLine("================================");
 System.Console.WriteLine("Número de contas:" + ContaCorrente.TotalContasCriadas); 
Console.WriteLine("================================");

 ContaCorrente conta2 = new ContaCorrente(17, "2020-X");

 conta2.Titular = new Cliente(); 

 conta2.Titular.Nome = "Loud Catinga";
 conta2.Titular.Cpf = "123456789";
 conta2.Titular.Profissao = "Streamer";
 conta2.DefinirSaldo(100);

 Console.WriteLine("Titular: " + conta2.Titular.Nome);
 Console.WriteLine("CPF: " + conta2.Titular.Cpf);
 Console.WriteLine("Profissão: " + conta2.Titular.Profissao);
 Console.WriteLine("Agência: " + conta2.Agencia);
 Console.WriteLine("Número Conta: " + conta2.Conta);
 Console.WriteLine("Saldo: " + conta2.ObterSaldo());
Console.WriteLine("================================"); 
 System.Console.WriteLine("Número de contas:" + ContaCorrente.TotalContasCriadas); 
Console.WriteLine("================================");

 ContaCorrente conta3 = new ContaCorrente(18, "1010-X");
 conta3.Titular = new Cliente(); 

 conta3.Titular.Nome = "Gilberto";
 conta3.Titular.Cpf = "02975024852349";
 conta3.Titular.Profissao = "Dev";
 conta3.DefinirSaldo(300);

 Console.WriteLine("Titular: " + conta3.Titular.Nome);
 Console.WriteLine("CPF: " + conta3.Titular.Cpf);
 Console.WriteLine("Profissão: " + conta3.Titular.Profissao);
 Console.WriteLine("Agência: " + conta3.Agencia);
 Console.WriteLine("Número Conta: " + conta3.Conta);
 Console.WriteLine("Saldo: " + conta3.ObterSaldo());
Console.WriteLine("================================");
 System.Console.WriteLine("Número de contas:" + ContaCorrente.TotalContasCriadas); 
Console.WriteLine("================================");

 ContaCorrente conta4 = new ContaCorrente(19, "1234-X");
 conta4.Titular = new Cliente(); 

 conta4.Titular.Nome = "Wences";
 conta4.Titular.Cpf = "1-092834-13854-2=9";
 conta4.Titular.Profissao = "Vagabundo";
 conta4.DefinirSaldo(1);

 Console.WriteLine("Titular: " + conta4.Titular.Nome);
 Console.WriteLine("CPF: " + conta4.Titular.Cpf);
 Console.WriteLine("Profissão: " + conta4.Titular.Profissao);
 Console.WriteLine("Agência: " + conta4.Agencia);
 Console.WriteLine("Número Conta: " + conta4.Conta);
 Console.WriteLine("Saldo: " + conta4.ObterSaldo());
Console.WriteLine("================================");
 System.Console.WriteLine("Número de contas:" + ContaCorrente.TotalContasCriadas); 
Console.WriteLine("================================");

 ContaCorrente conta5 = new ContaCorrente(20, "9874-Z");
 conta5.Titular = new Cliente(); 

 conta5.Titular.Nome = "Gibran";
 conta5.Titular.Cpf = "10-9840239587";
 conta5.Titular.Profissao = "Dev";
 conta5.DefinirSaldo(10000);

 Console.WriteLine("Titular: " + conta5.Titular.Nome);
 Console.WriteLine("CPF: " + conta5.Titular.Cpf);
 Console.WriteLine("Profissão: " + conta5.Titular.Profissao);
 Console.WriteLine("Agência: " + conta5.Agencia);
 Console.WriteLine("Número Conta: " + conta5.Conta);
 Console.WriteLine("Saldo: " + conta5.ObterSaldo());
Console.WriteLine("================================");
 System.Console.WriteLine("Número de contas:" + ContaCorrente.TotalContasCriadas); 
Console.WriteLine("================================");
 ContaCorrente conta6 = new ContaCorrente(21, "8765-Y");
 conta6.Titular = new Cliente(); 

 conta6.Titular.Nome = "Thalles";
 conta6.Titular.Cpf = "01983-48120953";
 conta6.Titular.Profissao = "Consultor";
 conta6.DefinirSaldo(50000);

 Console.WriteLine("Titular: " + conta6.Titular.Nome);
 Console.WriteLine("CPF: " + conta6.Titular.Cpf);
 Console.WriteLine("Profissão: " + conta6.Titular.Profissao);
 Console.WriteLine("Agência: " + conta6.Agencia);
 Console.WriteLine("Número Conta: " + conta6.Conta);
 Console.WriteLine("Saldo: " + conta6.ObterSaldo());
Console.WriteLine("================================");
 System.Console.WriteLine("Número de contas:" + ContaCorrente.TotalContasCriadas); 
Console.WriteLine("================================");
