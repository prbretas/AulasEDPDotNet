using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



/*
EXEMPLO UTILIZANDO Tipos numéricos de ponto flutuante (Referência de C#):

//inteiro
int valorA = 45;

//float
float valorB = 54.55f;

//double
double valorC = 543.555;

//decimal
decimal valorD = 5433.543m;

*/

namespace ProjetoEntidadeClasseEmpresa
{
    public class Produto
    {
        //SEMPRE QUE TIVER ATRIBUTOS PRIVADOS, DEVE-SE CRIAR PROPRIEDADES!
        //--------------------ATRIBUTOS ---------------------
        private int codigo; //caracteristica da entidade de classe
        private string nome;

        private string descricao;

        private decimal preco_compra;

        private decimal preco_venda;
        private int quantidade;

        private bool ativo = true;

        private DateTime data_cadastro;





        // ------------PRORPRIEDADES ---------------
        //DEVE-SE CRIAR PROPRIEDADES TODA VEZ QUE OS ATRIBUTOS DA CLASSE FOREM PRIVATE
        // A FUNÇÃO DA PROPRIEDADE É ACESSAR E ATRIBUIR VALORES PARA O ATRIBUTO QUE É PRIVADO
        public int Codigo
        {

            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Nome
        {

            get { return this.nome; }
            set { this.nome = value; }
        }


        public string Descricao
        {

            get { return this.descricao; }
            set { this.descricao = value; }
        }
        public decimal Preco_Compra
        {

            get { return this.preco_compra; }
            set { this.preco_compra = value; }
        }

        public decimal Preco_Venda
        {

            get { return this.preco_venda; }
            set { this.preco_venda = value; }
        }

        public int Quantidade
        {

            get { return this.quantidade; }
            set { this.quantidade = value; }
        }

        public bool Ativo
        {
            get { return this.ativo; }
            set { this.ativo = value; }

        }


        public DateTime Data_Cadastro
        {
            get { return this.data_cadastro; }
            set { this.data_cadastro = value; }

        }


        //--------------- CONSTRUTOR -------------------
        /* NAO É NECESSARIO TER PROPRIEDADES QUANDO UTILIZA-SE O CONSTRUCTOR,
           MAS É BOM QUE TENHA PARA OBRIGAR DEFINIR OS VALORES DA CLASSE JA NA CRIAÇÃO DO OBJETO
           O CONSTRUCTOR EH UMA FORMA DE SET.
           É RECOMENDADO UTILIZAR AS PROPRIEDADES
           SUBSTITUI A PROPRIEDADE NO REQUISITO SET(), GET NUNCA! */

        // QUANDO UTILIZA O CONSTRUTOR, ESTÁ OBRIGANDO DEFINIR VALORES NA CRIAÇÃO DO OBJETO

        public Produto(int codigo, string nome, string descricao,
        decimal preco_compra, decimal preco_venda, int quantidade, DateTime data_cadastro)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.descricao = descricao;
            this.preco_compra = preco_compra;
            this.preco_venda = preco_venda;
            this.quantidade = quantidade;
            this.data_cadastro = data_cadastro;

        }



        //-------------------- MÉTODOS---------------------
        //FORMA CORRETA DE ESCREVER UM METODO, USANDO COMO PARAMETRO A ENTIDADE DE CLASSE
        /*       APENAS EXEMPLO PARA RECUPERAR OS VALORES DOS METODOS

          public void Inserir(Produto produto)
                {
                    this.codigo = produto.codigo;  // é uma forma de criar o SET
                    nome = produto.nome;
                    //o this nessa parte do codigo fica OPCIONAL.
                    this.descricao = produto.descricao;
                    preco_compra = produto.preco_compra;
                    preco_venda = produto.preco_venda;
                    quantidade = produto.quantidade;
                    data_cadastro = produto.data_cadastro;

                    Console.WriteLine("");
                }
         */

        public void Cadastrar(Produto produto)
        {
            Console.WriteLine($"Produto cadastrado com sucesso: {produto.codigo} - {produto.nome}");

        }
    }
}



//PAREI NA AULA 2, SEMANA 3, 2:11