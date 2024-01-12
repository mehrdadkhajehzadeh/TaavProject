class StudentGrade : Avrage
{
    public double Grade { get; set; }
    public int Unit { get; set; }

    public StudentGrade(double grade, int unit)
    {
        Grade = grade;
        Unit = unit;
    }

    public void StudentAvrage()
    {
        Console.WriteLine($"{Grade} unit {Unit} avrage :{(Grade*Unit)/Unit} ");
    }
}