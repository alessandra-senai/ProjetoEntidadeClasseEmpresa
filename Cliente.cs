using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEntidadeClasseEmpresa
{
    public class Cliente
    {
        private int idCliente;
        private string cpf;
        private string nomeCliente;
        private string endereco;
        private DateTime dtNascimento;
        private double renda;

        public Cliente(int idCliente, string cpf, string nomeCliente, 
                       string endereco, DateTime dtNascimento, double renda)
        {
            this.idCliente = idCliente; // set
            this.cpf = cpf;
            this.nomeCliente = nomeCliente;
            this.endereco = endereco;
            this.dtNascimento = dtNascimento;
            this.renda = renda;
        }
    }
}