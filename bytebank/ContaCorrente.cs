namespace bytebank;

public class ContaCorrente
{
    public int Agencia;
    public string Conta;
    public string Titular;
    public double Saldo;

    public void Depositar(double valor)
    {
        this.Saldo += valor;
    }
    public bool Sacar(double valor)
    {
        if (valor <= this.Saldo)
        {
            this.Saldo -= valor;
            return true;
        }  else {
            return false;
        }
    }
    public bool Transferir(double valor, ContaCorrente destino)
    {
        if (this.Saldo <= valor)
        {
            return false;
        }
          else 
        {
            
            this.Sacar(valor);
            destino.Depositar(valor);
            return true;
        }
    }
}