namespace bytebank;

public class ContaCorrente
{
    public int Agencia;
    public string Conta;
    public string Titular;
    public double Saldo;

    public void Deposito(double valor)
    {
        this.Saldo += valor;
    }
    public bool Saque(double valor)
    {
        if (valor <= this.Saldo)
        {
            this.Saldo -= valor;
            return true;
        }  else {
            return false;
        }
    }
}