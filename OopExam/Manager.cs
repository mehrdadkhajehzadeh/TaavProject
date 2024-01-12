class Manager : Employee
{
    public string Department { get; set; }

    public Manager(int employeeID, int salary, string department) : base(employeeID, salary)
    {
        EmployeeID = employeeID;
        Salary = salary;
        Department = department;
    }
    public void PrintDetails()
    {
        Console.WriteLine($"{EmployeeID} salary : {Salary} Department :{Department}");
    }
}