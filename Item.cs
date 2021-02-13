namespace stone
{
    public class Item
    {
        string Name;
        int Price;
        int Quantity;
        public Item(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public int  CalculateItem()
        {

            return Price * Quantity;
        }

    }
}