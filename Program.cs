using System;

namespace Aula26
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            Produto p1 = new Produto(1, "Battlefiel 1", 70.00f);
            Produto p2 = new Produto(2, "The last of us", 165.00f);
            Produto p3 = new Produto(3, "Celeste", 43.00f);
            Produto p4 = new Produto(4, "Battlefied V", 199.99f);

            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);


            cart.Remover(p3);

            Produto prodAlterar = new Produto(1, "Cyberpunk 2077", 199.99f);
            cart.Alterar(2, prodAlterar);

            cart.Ler();

            cart.MostrarTotal(0);


        }
    }
}
