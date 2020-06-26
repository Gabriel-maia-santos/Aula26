namespace Aula26
{
    public interface ICarrinho
    {

        //Calcular o total desafio
        void Ler();
        void Adicionar(Produto _produto);

        void Remover(Produto _produto);

        void Alterar(int _codigo, Produto _produtoAlterado);

        void MostrarTotal(float ValorTotal);

    }
}