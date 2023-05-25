using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exemplo_mvc.View;
using exemplo_mvc.Model;



namespace exemplo_mvc.Controller
{
    public class ProdutoController
    {
        Produto produto = new Produto();

        ProdutoView produtoView = new ProdutoView();

        public void ListarProdutos()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }
        public void CadastrarProduto()
        {
            Produto novoProduto = produtoView.Cadastrar();

            produto.Inserir(novoProduto);
            
            ListarProdutos();
        }

    }
}