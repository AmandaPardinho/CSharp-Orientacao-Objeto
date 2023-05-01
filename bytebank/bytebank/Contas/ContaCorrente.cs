using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        //Cada um dos campos recebe um valor inicial padrão
        //É possível alterar esse valor padrão do campo aqui mesmo na criação da classe => basta atribuir (=) um valor de acordo com o seu tipo

        private int _numeroAgencia;

        //Definindo uma propriedade 
        public int NumeroAgência
        {
            get { return _numeroAgencia; }
            set
            {
                if(value > 0)
                {
                    _numeroAgencia = value;
                }
            }
        }
        
        /* Criação de uma propriedade autoimplementada
         * - Útil quando não há necessidade de realizar validação
         * - Deixa o código mais enxuto
         * - Cria um campo privado interno e atribui um valor na execução
         */
        //private string conta;
        public string Conta { get; set; }

        //private Cliente titular;
        public Cliente Titular { get; set; }

        private double saldo;
        //public double saldo = 100;

        //Método depositar
        public void Depositar(double valor)
        {
            saldo += valor;
        }

        //Método sacar
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Método transferir
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        //Exibir informações da conta
        /*public string ExibirInfos()
        {
            return $"Titular: {titular.nome}\nCPF: {titular.cpf}\nProfissão: {titular.profissao}\nNúmero da agência: {_numeroAgencia}\nNúmero da conta: {conta}\nSaldo: R$ {string.Format("{0:0.00}", saldo)}";
        }*/

        public void SetSaldo(double valor)
        {
            if(valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }
    }


}
