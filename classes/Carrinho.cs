using System;
using System.Collections.Generic;

namespace POO_Interface.classes
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();
        public void Alterar(int cod, Produto novoProduto)
        {
            carrinho.Find(x => x.Codigo == cod).Nome = novoProduto.Nome;
            carrinho.Find(x => x.Codigo == cod).Preco = novoProduto.Preco;
            carrinho.Find(x => x.Codigo == cod).Codigo = novoProduto.Codigo;
        }

        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        public void Deletar(int cod)
        {
            Produto deletar = carrinho.Find(x => x.Codigo == cod);
        }

        public void Listar()
        {
            if (carrinho != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (var item in carrinho){
                    Console.WriteLine($"{item.Codigo}° Produto: {item.Nome}    R$ {item.Preco}");
                }
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não há itens na lista");
            }
            Console.ResetColor();
        }
    }
}