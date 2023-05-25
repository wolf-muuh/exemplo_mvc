using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemplo_mvc.Model;

namespace exemplo_mvc.View
{
    public class ProdutoView
    {
        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");
                
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código");
            novoProduto.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Informe o Nome");
            novoProduto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe o preço");
            novoProduto.Preco = float.Parse(Console.ReadLine());

            return novoProduto;
            
            
            
            
        }
    }
}