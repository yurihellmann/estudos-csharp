﻿using System.Runtime.CompilerServices;
using ExemploFundamentos.Common.Models;

// Listas

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

// for(int contador = 0; contador < listaString.Count; contador++){
//     Console.WriteLine($"Posição Nº {contador + 1} - {listaString[contador]}");
// }

// int contadorForEach = 0;
// foreach(string item in listaString){
//     Console.WriteLine($"Posição Nº {contadorForEach + 1} - {listaString[contadorForEach]}");
//     contadorForEach++;
// }



// Arrays
// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 72;
// arrayInteiros[1] = 64;
// arrayInteiros[1+1] = 50;
// // arrayInteiros[3] = 1;

// // Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Console.WriteLine("Percorrendo array com FOR");
// for(int contador = 0; contador < arrayInteiros.Length; contador++){
//     Console.WriteLine($"Posição Nº {contador + 1} - {arrayInteiros[contador]}");
// }

// Console.WriteLine();
// Console.WriteLine("############################################");
// Console.WriteLine();

// Console.WriteLine("Percorrendo array com FOREACH");
// int contadorForEach = 1;
// foreach(int valor in arrayInteiros){
//     Console.WriteLine($"Posição Nº {contadorForEach} - {valor}");
//     contadorForEach++;
// }

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Yuri";
// pessoa1.Idade = 24;
// pessoa1.Apresentar();

// Menu interativo simples
// string opcao;
// bool exibirMenu = true;

// while(exibirMenu){
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Sair");

//     opcao = Console.ReadLine();

//     switch(opcao){
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
        
//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;
        
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             Environment.Exit(0);
//             break;

//         default:
//             Console.WriteLine("Opção inválida. Digite novamente.");
//             break;
//     }
// }



// Laço DO WHILE
// int soma = 0, numero = 0;

// do {
//     Console.WriteLine("Digite um número (0 para parar):  ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");

//Laço WHILE
// int numero = 5;
// int contador = 0;

// while (contador <= 10){
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//     contador++;
// }



// Laço FOR;
// int numero = 5;
// int contador;

// for(contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }



// Operadores aritméticos e função Math.
// Calculadora calc = new Calculadora();

// Incremento e decremento
// int numeroIncremento = 10;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("Incrementando o 10");
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);

// Console.WriteLine("###################################");

// int numeroDecremento = 20;

// Console.WriteLine(numeroDecremento);

// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;

// Console.WriteLine(numeroDecremento);



// Calculos com a classe MATH (seno, coseno e tangente)
// string userInput;
// double angulo;

// Console.WriteLine("Informe o angulo a ser calculado: ");
// userInput = Console.ReadLine();
// angulo = Convert.ToDouble(userInput);

// calc.Seno(angulo);
// calc.Coseno(angulo);
// calc.Tangente(angulo);

// Calculos com a classe MATH (potencia)
//calc.Potencia(3, 3);



// Calculos básicos
// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 45);
// calc.Dividir(2, 2);

/////////////////////////////////////////////////
//Operador NOT
// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde){
//     Console.WriteLine("Vou pedalar");
// } else{
//     Console.WriteLine("Vou pedalar outro dia");
// }



// Operador E
// bool possuiPresencaMinima = true;
// double media = 7.5;

// if (possuiPresencaMinima && media >= 7){
//     Console.WriteLine("Aprovado");
// }else{
//     Console.WriteLine("Reprovado");
// }


//Operador OU
// bool ehMaiorDeIdade = true;
// bool possuiAutorizacaoResponsavel = false;

// if (ehMaiorDeIdade || possuiAutorizacaoResponsavel){
//     Console.WriteLine("Entrada liberada!");
// }
// else{
//     Console.WriteLine("Entrada não liberada!");
// }


//Switch Case
// Console.WriteLine("Digite uma letra: ");
// string letra = Console.ReadLine();

// switch (letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }





// Funcionamento do IF
// int quantidadeEmEstoque = 3;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade em compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0){
//     Console.WriteLine("Venda inválida.");
// }
// else if (possivelVenda){
//     Console.WriteLine("Venda realizada.");
// }
// else{
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }



// Convertendo de maneira segura
// string a = "15";
// int b = 0;

// int.TryParse(a, out b);

// Console.WriteLine(b);



// Ordem dos operadores (mesma da matemática)
// double a = 4 / (2 + 2);
// Console.WriteLine(a);



// Cast implicito
// int a = 5;
// double b = a;
// int a = int.MaxValue;
// long b = a;

// Console.WriteLine(b);



// Converter para String
// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);



// Cast - Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// Console.WriteLine(a);



//Combinação de operadores
// int a = 10;
// int b = 20;

// int c = a + b;

// c = c + 5; 
// c += 5;

// Console.WriteLine(c);



//Tipo DateTime
// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));



// string apresentacao = "Olá, seja bem-vindo";
// int quantidade = 1;
// double altura = 1.90;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine($"Valor da variável quantidade: {quantidade}");
// Console.WriteLine($"Valor da variável altura: {altura.ToString("0.00")}");
// Console.WriteLine($"Valor da variável preco: {preco}");
// Console.WriteLine($"Valor da variável condicao: {condicao}");



// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Yuri";
// pessoa1.Idade = 24;
// pessoa1.Apresentar();
