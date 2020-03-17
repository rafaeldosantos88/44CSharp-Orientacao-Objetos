
using System.Globalization;


namespace _42_Exemplo
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;

        }

        public void AdcionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;

        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;

        }


        public override string ToString()
        {//Aqui o produto vai ser transformado na forma de String
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + " ,"
                + Quantidade
                + " Unidades, total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
