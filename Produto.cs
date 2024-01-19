using System;
using System.Globalization;

namespace Exercicio_Estoque
{
    internal class Produto
    {
        public string Nome;
        public decimal Preco;
        public int Quantidade;

        public decimal ValorTotalEmEstoque ()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade; 
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
                
        }


    }
}
