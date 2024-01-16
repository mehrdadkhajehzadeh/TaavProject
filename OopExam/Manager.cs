class Manager : Employee
{
    public string Department { get; set; }
    public Manager(string department, string name, int employeeID, int salary) : base(name, employeeID, salary)
    {
        Department = department;

    }
    public override void PrintDetails()
    {
        Console.WriteLine(
            $"name is : {Name}," +
            $" EmployeeId is : {EmployeeID}," +
            $" Department is : {Department}," +
            $" salary is : {Salary}");
    }
}