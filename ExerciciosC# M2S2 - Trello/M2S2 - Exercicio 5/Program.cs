/*


------------------------Exercicio 5 - MODULO 2 SEMANA 2----------------------

Tentando ir além do óbvio e trazendo exemplo reais de como sistemas podem evoluir,
vamos incrementar melhorias no código criado no exercício anterior.

Para este desafio, além de ser mostrado a média dos números, deve também ser mostrado o
menor número e o maior número

 */


decimal nota1 = 8.0m;
decimal nota2 = 7.6m;
decimal nota3 = 9.7m;
decimal nota4 = 8.2m;
decimal nota5 = 8.9m;

decimal mediaNotas = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

Console.WriteLine(mediaNotas);








decimal MenorNota = mediaNotas.Min();
Console.WriteLine("A menor nota é :" + MenorNota);


decimal MaiorNota = mediaNotas.Max();
Console.WriteLine("A maior nota é: " + MaiorNota);