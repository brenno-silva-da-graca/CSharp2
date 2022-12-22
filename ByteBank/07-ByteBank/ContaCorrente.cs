
namespace _07_ByteBank
{
    public class ContaCorrente
    {

        public Cliente Titular { get; set; }

        public static int TotalContasCriadas { get; private set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                    return;

                _agencia = value;
            }
        }

        public int Numero { get; set; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                    return;

                _saldo = value;
            }
        }

        /*
        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
                return;

            this.saldo = saldo;
        }

        public double GetSaldo()
        {
            return saldo;
        }
        */

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            TotalContasCriadas++;
        }

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
                return false;

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
                return false;

            Sacar(valor);
            contaDestino.Depositar(valor);

            return true;
        }
    }
}
