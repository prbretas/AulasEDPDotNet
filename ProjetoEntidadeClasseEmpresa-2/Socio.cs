using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEntidadeClasseEmpresa
{
    public class Socio
    {
        /* QUANDO CRIAMOS ATRIBUTOS PUBLICOS
        NÃO PRECISAMOS CRIAR PROPRIEDADES, LOGO O SET E GET É AS PROPS 
        
        */
        public string Nome {set;get;} //PROPRIEDADE DA CLASSE(GET E SET)
        public string Cpf {set;get;}
        public string Rg {set;get;}
        public DateTime Nascimento {set;get;}
        public string Telefone {set;get;}
        public string Endereco {set;get;}





public void ConfirmarCadastro(string nome, string cpf, string telefone, string endereco = null){ //Parametro NULL sempre deixar por ultimo


Console.WriteLine($"Nome:{nome} - CPF: {cpf} - Telefone: {telefone} - Endereço:{endereco}");

}


    }
}