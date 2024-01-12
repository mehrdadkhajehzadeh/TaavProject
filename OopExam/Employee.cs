class Employee
{
    public int EmployeeID { get; set; }
    public int Salary { get; set; }
    public Employee(int employeeID, int salary)
    {
        EmployeeID = employeeID;
        Salary = salary;
    }
    public void PrintDetails()
    {
        Console.WriteLine($"{EmployeeID} salary : {Salary}");
    }
}
