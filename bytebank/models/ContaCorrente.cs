namespace bytebank.models;

public class ContaCorrente
{
    public int Agencia;
    public string Conta;
    public Cliente Titular;
    private double Saldo = 100;

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
        }  
        else 
        {
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

    public void DefinirSaldo(double valor) 
    {
        if (valor < 0)
        {
            return; 
        }
        else 
        {
            this.Saldo += valor;
        }
    }

    public double ObterSaldo() 
    {
        return this.Saldo;
    }
}