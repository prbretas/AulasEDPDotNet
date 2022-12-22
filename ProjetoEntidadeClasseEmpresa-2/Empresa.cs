/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 */
namespace ProjetoEntidadeClasseEmpresa
{
    public class Empresa
    {

        // -------------------------- criando ATRIBUTOS -------------------------------
        private string _nome; 
        private string _telefone;
        private int _totalFuncionarios;



        // -------------------------- criando PROPRIEDADES --------------------------
        public string Nome
        {
            //atribuir valor para o atributo _nome
            set
            {
                _nome = value;
            }

            //exibir, enviar o valor que consta no atributo _nome
            get
            {
                return _nome;
            }

        }

        public string Telefone
        {
            set
            {
                _telefone = value;
            }

            get
            {
                return _telefone;

            }
        }


        //-------------------------- criando MÉTODOS --------------------------
        
        // É UMA MÁ PRATICA ESCREVER O CODIGO DESTA FORMA,
        //DEVE SER USADO - PUXAR - SEMPRE A ENTIDADE DE CLASSE COMO PARAMETRO, E NAO OS ATRIBUTOS LISTADOS UM POR UM.
        public void Inserir(string nome, string telefone, int totalFuncionarios)
        {
            _nome = nome;
            _telefone = telefone;
            _totalFuncionarios = totalFuncionarios;
        }
        
        
        
        
        
        
        // VOID é um metodo que nao retorna nenhum resultado
        public void InserirTotalFuncionarios(int totalFuncionarios)
        {
            _totalFuncionarios = totalFuncionarios;
        }

        public int RetornaTotalFuncionarios()
        {
            return _totalFuncionarios;

        }

    }
}

//PAREI NA AULA 1 SEMANA 3 - 2:03 de aula