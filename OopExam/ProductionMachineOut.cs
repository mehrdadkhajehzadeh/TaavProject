class ProductionMachineOut : Vehicle
{
    int rent = 1500;
    public ProductionMachineOut(int yearCarManufacturing, string carName) : base(yearCarManufacturing, carName)
    {
        YearCarManufacturing = yearCarManufacturing;
        CarName = carName;
    }

    public override void Rent()
    {
        Console.WriteLine($"{CarName} : {YearCarManufacturing} rent for each day {rent}$");
    }
}