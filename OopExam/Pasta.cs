
class Pasta : Food
{
    public Pasta(int orderQuantity, int price) : base(orderQuantity, price)
    {

    }
    public override void SetOrderQuantity(int orderQuantity)
    {
        if (orderQuantity > 31)
        {
            throw new Exception("More than capacity available");
        }
        base.SetOrderQuantity(orderQuantity);
    }
    public override void SetPrice(int price)
    {
        if (price > 200)
        {
            throw new Exception("Invalid Price");
        }
        base.SetPrice(price);
    }
}
