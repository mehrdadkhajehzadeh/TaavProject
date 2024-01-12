
class Food
{
    public int OrderQuantity { get;private set; }

    public int Price { get; private set; }
    public Food(int orderQuantity, int price)
    {
        OrderQuantity = orderQuantity;
        Price = price;
    }

    public virtual void SetOrderQuantity(int orderQuantity)
    {
        if (orderQuantity < 0)
        {
            throw new Exception("Invalid Quatity");
        }
        OrderQuantity = orderQuantity;
    }
    public virtual void SetPrice(int price)
    {
        if (price < 0)
        {
            throw new Exception("Invalid Quatity");
        }
        Price = price;
    }
}
