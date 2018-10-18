using System;
using System.Globalization;

namespace primeiro_projeto {
    class Program {
        static void Main(string[] args) {
            Produto P;
            P = new Produto();
            int qte;

            Console.WriteLine("Digite os dados do produto");
            Console.Write("Nome: ");
            P.nome = Console.ReadLine();
            Console.Write("Preço: ");
            P.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em estoque: ");
            P.quantidadeEmEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + P.ToString());
            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos entraram no estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizarEntrada(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P.ToString());
            Console.WriteLine();

            Console.WriteLine("Digite a quantidade de produtos saíram no estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.realizarSaida(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + P.ToString());
            Console.WriteLine("Fim do Sistema");

            

            Console.ReadLine();
        }
    }
}
