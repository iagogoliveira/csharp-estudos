using System;

public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor) 
    {
        if (this.saldo < valor)
        {
            return false;
        }
            // mesmo caso que a função Transferir.
            this.saldo -= valor;
            return true;
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
      // após o primeiro return, a função retorna e não executa as seguintes linhas, portanto
      // não é necessário um else nesse caso.
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        
    }
}
