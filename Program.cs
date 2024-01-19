using System;
using System.Globalization;

namespace Exercicio_Estoque
{
   public class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            
            Console.WriteLine("Entre os dados do produto:");
            Console.WriteLine();

            Console.Write("Nome:");
            p.Nome= Console.ReadLine();

            Console.Write("Preço:");
            p.Preco=decimal.Parse(Console.ReadLine());

            Console.Write("Quantidade:");
            p.Quantidade=int.Parse(Console.ReadLine());

            // Console.WriteLine($"Dados do produto:{p.Nome}, valor: {p.Preco}, tem {p.Quantidade}, em estoque" );

            Console.WriteLine("Dados do produto:" + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a serem adicionados:");
            int qte=int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + p);
            Console.WriteLine();

            Console.Write("Digite o número de produtos a ser removido:");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadKey();






        }
    }
}
