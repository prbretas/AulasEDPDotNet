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
        this.idCliente = idCliente; // é uma forma de criar o SET
        this.cpf = cpf;// é uma forma de criar o SET
        this.nomeCliente = nomeCliente;
        this.endereco = endereco;
        this.dtNascimento = dtNascimento;
        this.renda = renda;
    }                      

    }
}