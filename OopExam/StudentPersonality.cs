class StudentPersonality
{

    string Name { get; set; }
    int StudentId { get; set; }
    public StudentPersonality(string name, int studentId)
    {
        Name = name;
        StudentId = studentId;
    }
    public void ShowStudentPersonality()
    {
        Console.WriteLine(Name + " " + "studentId : " + StudentId);
    }
}
