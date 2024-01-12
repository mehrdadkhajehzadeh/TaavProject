class Person
{
 
    
    public string? LastName { get; set; }
    public string? FirstName{ get; set; }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public void GetFullName()
    {
        Console.WriteLine($"{FirstName}  {LastName}");
    }
}
