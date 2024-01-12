class Pizza : Food
    {
        public Pizza(int orderQuantity, int price) : base(orderQuantity, price)
        {

        }
        public override void SetOrderQuantity(int orderQuantity)
        {
            if (orderQuantity > 50)
            {
                throw new Exception("More than capacity available");
            }
            base.SetOrderQuantity(orderQuantity);
        }
        public override void SetPrice(int price)
        {
            if (price > 350)
            {
                throw new Exception("Invalid Price");
            }
            base.SetPrice(price);
        }
    }

