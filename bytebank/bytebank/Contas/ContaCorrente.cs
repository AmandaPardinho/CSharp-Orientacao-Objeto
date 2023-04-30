﻿using bytebank.Titular;
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

        public int numeroAgencia;
        public string conta;
        public Cliente titular;
        public double saldo;
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
        public string ExibirInfos()
        {
            return $"Titular: {titular.nome}\nCPF: {titular.cpf}\nProfissão: {titular.profissao}\nNúmero da agência: {numeroAgencia}\nNúmero da conta: {conta}\nSaldo: R$ {string.Format("{0:0.00}", saldo)}";
        }
    }
}