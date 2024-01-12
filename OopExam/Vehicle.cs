abstract class Vehicle
{
    private int _yearCarManufacturing;
    
    public  int YearCarManufacturing {
        get
        {
            return _yearCarManufacturing;
        } set
        {
            if (value < 0 )
            {
                throw new Exception("Invalid number");
            }
            _yearCarManufacturing = value;
        }
    }

    public  string CarName { get; set; }
    public abstract void Rent();


    public Vehicle(int yearCarManufacturing, string carName)
    {
        YearCarManufacturing = yearCarManufacturing;
        CarName = carName;
    }


}
