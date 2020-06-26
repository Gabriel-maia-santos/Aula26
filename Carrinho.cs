using System;
using System.Collections.Generic;

namespace Aula26
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Alterar(int _codigo, Produto _produtoAlterado)
        {
            carrinho.Find(a => a.Codigo == _codigo).Nome = _produtoAlterado.Nome;
            carrinho.Find(a => a.Codigo == _codigo).Preco = _produtoAlterado.Preco;
        }

        public void Ler()
        {
            foreach(Produto item in carrinho){
            System.Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }
        

        public void MostrarTotal(float ValorTotal)
        {       
             foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Valor total da compra: R$ {ValorTotal}");
        }
    }
}