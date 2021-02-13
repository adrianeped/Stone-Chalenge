namespace stone
{
    public class Item
    {
        string Nome;
        int Preco;
        int Quantidade;
        public Item(string nome, int preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public int  CalculaItem()
        {

            return Preco * Quantidade;
        }

    }
}