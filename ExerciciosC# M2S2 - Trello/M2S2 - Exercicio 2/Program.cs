/* Exercicio 2 - MODULO 2 SEMANA 2

No C sharp podemos utilizar a palavra reservada "var" para declarar-mos variáveis.
Então crie um método simples que imprima no console qual os tipos das seguintes variáveis

var meuTime = "Cruzeiro"
var minhaIdade = 26
var hobbies = new string[]{"xadrez","Mario kart mobile",}
 */


string meuTime = "Fluminense";
int minhaIdade = 30;
var hobbies = new string[]{"games", "tocar guitarra", "passear com meu filho"};


Console.WriteLine(meuTime.GetType());
Console.WriteLine(minhaIdade.GetType());
Console.WriteLine(hobbies.GetType());


