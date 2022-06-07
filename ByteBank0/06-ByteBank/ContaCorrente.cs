using System;
//using _05_ByteBank;


namespace _06_ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular {get; set;}
        public int Agencia { get; set;}
        public int Numero { get; set;}

        private double  _saldo = 100;

        public double Saldo
        {
            get 
            { 
                return _saldo; 
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }


       // public double getSaldo()
        //{
            //return saldo;
        //}

        //public void setSaldo(double saldo)
        //{
          //  if (saldo < 0)
            //{
              //  return;
           // }       
           // this.saldo = saldo;   
        //}


        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            // mesmo caso que a função Transferir.
            _saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                return false;
            }
            // após o primeiro return, a função retorna e não executa as seguintes linhas, portanto
            // não é necessário um else nesse caso.
            _saldo -= valor;
            contaDestino.Depositar(valor);
            return true;

        }

    }

}
