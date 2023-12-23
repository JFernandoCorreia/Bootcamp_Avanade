//Desafio
//Você deve criar um programa que crie um objeto jogador com nome, nacionalidade, idade e posição. O jogador deve ser criado a
//partir de uma classe "Jogador" com o método "novo" e os atributos mencionados.

//Entrada
//O programa deve ler as informações do jogador nessa ordem:

//nome: string
//nacionalidade: string
//idade: inteiro
//posição: strig
//Saída
//O programa deve imprimir as informações do jogador criado, uma por linha, com a mensagem "Jogador criado!" no início. As
//informações devem ser exibidas na seguinte ordem: nome, nacionalidade, idade e posição (com a mensagem "Posição:" na frente).
//Veja a estrutura abaixo:

//Jogador criado!
//[nome]
//[nacionalidade]
//[idade]
//Posição: [posição]
//Exemplos
//A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu
//programa com esses exemplos e com outros casos possíveis.

//Entrada	          Saída
//Ronaldo           Jogador criado!
//Brasil            Ronaldo
//46                Brasil
//Atacante          46
//                  Posição: Atacante

//Puyol             Jogador criado!
//Espanha           Puyol
//20                Espanha
//Zagueiro          20
//                  Posição: Zagueiro

//John              Jogador criado!
//EUA               John
//28                EUA
//Meio-campo        28
//                  Posição: Meio-campo






using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador(string nome, string nacionalidade, int idade, string posicao)
    {
        Nome = nome;
        Nacionalidade = nacionalidade;
        Idade = idade;
        Posicao = posicao;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Jogador criado!");
        string nome = Console.ReadLine();
        string nacionalidade = Console.ReadLine();
        int idade = Convert.ToInt32(Console.ReadLine());
        string posicao = Console.ReadLine();

        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);

        Console.WriteLine(jogador.Nome);
        Console.WriteLine(jogador.Nacionalidade);
        Console.WriteLine(jogador.Idade);
        Console.WriteLine("Posição: " + jogador.Posicao);
    }
}
