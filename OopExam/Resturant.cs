

 class Resturant
{
   private static List<Food> _foods = new List<Food>();

    public void AddFood(int orderQuantity, int price, int type)
    {
        if(type == 1)
        {
            var pasta = new Pasta(orderQuantity, price);
            _foods.Add(pasta);
        }
        if (type == 2)
        {
            var pizza = new Pizza(orderQuantity, price);
            _foods.Add(pizza);
        }
    }
    public void ShowDetail()
    {
        foreach (var food in _foods)
        {
            
            Console.WriteLine($"{food.OrderQuantity} , {food.Price}");
        }
    }

}   
