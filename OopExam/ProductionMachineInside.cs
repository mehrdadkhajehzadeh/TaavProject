class ProductionMachineInside : Vehicle
{
    int rent = 1000;
    public ProductionMachineInside(int yearCarManufacturing, string carName) : base (yearCarManufacturing, carName)
    {
        YearCarManufacturing = yearCarManufacturing;
        CarName = carName;
    }
    public override void Rent()
    {
        Console.WriteLine($"{CarName} : {YearCarManufacturing} rent for each day :{rent}$");
    }
}
