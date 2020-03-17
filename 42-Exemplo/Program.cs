using System;
using System.Globalization;

namespace _42_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de  um produto em estoque(nome,preco e quantidade no estoque).m seguida
            •Mostras os dados do produto(nome,preco,quantidade no estoque,valor total no estoque.
            •Realizar uma entrada no estoque e mostrar novamente os dados do prdouto
            •Vamos ultilizar o toString,converte objeto para String
            •Realizar uma saída no estoque e mostrar novamente os dados do produto */

            Produto p = new Produto();  //Aqui instanciando Produto com variavel p
            Console.WriteLine("Entre com os dados do Produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());



            Console.WriteLine();
            Console.WriteLine("Dados do produto:" + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdcionarProdutos(qte);
            Console.WriteLine("Dados atualizados:" + p);

            Console.WriteLine();
            Console.WriteLine("Dados do produto:" + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser Removido ao estoque: ");
             qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados:" + p);





        }
    }
}
