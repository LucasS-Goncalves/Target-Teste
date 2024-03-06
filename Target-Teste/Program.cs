using Target_Teste.Questoes;

// 1º questão:
Console.WriteLine("Primeira Questão: ");
Console.WriteLine();
var primeiraQuestao = new PrimeiraQuestao();
primeiraQuestao.PrintSoma(13, 0, 0); // Resultado = 91;
Console.WriteLine();
Console.WriteLine("//////////////////////////");
Console.WriteLine();
Console.WriteLine();

// 2º questão: 
Console.WriteLine("Segunda Questão: ");
Console.WriteLine();
var segundaQuestao = new SegundaQuestao();
segundaQuestao.AcharNumeroNaSequencia();
Console.WriteLine();
Console.WriteLine("//////////////////////////");
Console.WriteLine();
Console.WriteLine();

// 3º questão: 
Console.WriteLine("Terceira Questão: ");
Console.WriteLine();

Console.WriteLine("a) 9: Próximo número é o anterior + 2");
Console.WriteLine("b) 128: Próximo número é o anterior * 2");
Console.WriteLine("c) 49: Sequência dos quadrados dos números naturais");
Console.WriteLine("d) 100: Sequência dos quadrados dos números naturais pares");
Console.WriteLine("e) 13: Sequência de Fibonacci");
Console.WriteLine("f) Não consegui descobrir o padrão");

Console.WriteLine();
Console.WriteLine("//////////////////////////");
Console.WriteLine();
Console.WriteLine();

// 4º questão: 
Console.WriteLine("Quarta Questão: ");
Console.WriteLine();

Console.WriteLine(@"Acredito que a questão poderia ter mais detalhes, como: eu poderia saber se a lampada está quente?. 
Eu acredito que não tem como descobrir qual interruptor controlar qual lâmpada sem essa informação em apenas duas idas.
Supondo que eu possa saber se a lampada está quente ou fria, classificando os interruptores em A, B e C, e classificando as salas em 1, 2 e 3, eu:

0)Deixaria todos os interruptores desligados;

1)Ligaria o interruptor A e o deixaria ligado por um tempo suficiente para a lampada correspondente ficar quente;

2)Desligaria o interruptor A e ligaria o interruptor B;

3)Iria para a sala 1 (1º ida) e verificaria se a lampada estava acesa, caso estivesse, o interruptor B controlaria a lampada da sala 1, então eu iria na sala 2 (2º ida) e verificaria se a lampada estivesse quente ou não, permitindo-me deduzir se o interruptor A controlaria a lampada da sala 2 ou 3; Caso a lampada da sala 1 não estivesse acesa, eu tocaria na lampada e veria se ela estava quente, se estivesse quente, o interruptor A controlaria a lampada da sala 1; Nesse cenário, bastava eu ir na sala 2 (2º ida) por exemplo e ver se a lampada estava acesa, se estivesse, o interruptor B controlaria a sala 2 e por consequência, o interruptor C controlaria a sala 3, caso não estivesse o interruptor B controlaria a sala 3;");
Console.WriteLine();
Console.WriteLine("//////////////////////////");
Console.WriteLine();
Console.WriteLine();

// 5º questão: 
Console.WriteLine("Quinta Questão: ");
Console.WriteLine();
var quintaQuestao = new QuintaQuestao();
string stringInvertida = quintaQuestao.InverterString();
Console.WriteLine("string invertida: " + stringInvertida);
Console.WriteLine();
Console.WriteLine("//////////////////////////");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Pressione qualquer tecla para fechar o programa.");

Console.ReadKey();