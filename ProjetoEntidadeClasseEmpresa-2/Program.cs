
using ProjetoEntidadeClasseEmpresa;

//var empresa = new Empresa();
/* Empresa empresa = new Empresa();
empresa.Nome = "Maria Silva";
empresa.Telefone = "47 9999- 4891";
empresa.InserirTotalFuncionarios(1);
Console.WriteLine($"------- Empresa -------\nNome: {empresa.Nome}\nTelefone: {empresa.Telefone}");
Console.Write($"Total de Funcionarios: {empresa.RetornaTotalFuncionarios()}");
 */


/* 
Empresa empresaNovo = new Empresa("Maria Silva", "64646-6400", 1);

Console.WriteLine(empresaNovo.Nome);


 */




/* Cliente clientePessoaFisica = new Cliente(1, "000-000-000-00", "João da Silva", "Rua Numero 1, Centro Joinville-SC",
new DateTime(1986,05,10), 1479.46);


 */

Produto produtoNovo = new Produto(2, "Cafeteira Elétrica", "Modelo 5194W", 46.89m, 109.99m, 20, new System.DateTime(2022,11,14));


produtoNovo.Cadastrar(produtoNovo);

Console.WriteLine(produtoNovo.Nome);



Socio socio = new Socio();

socio.Cpf = "456.879.987-54";
socio.Nome= " Maria Jose";
socio.Telefone = "99964-4166";
socio.Endereco = "Rua Olaria,123";

socio.ConfirmarCadastro(telefone:socio.Telefone, cpf: socio.Cpf, nome: socio.Nome);



//PAREI NA AULA 3 MODULO 3 - 1:40