
//using System.Reflection.PortableExecutable;

//var person = new Person("mehrdad", "kh");
//person.GetFullName();


//var employee = new Employee(123, 1000);
//employee.PrintDetails();

//var manager = new Manager(123, 1500, "Developer");
//manager.PrintDetails();

//var carInside = new ProductionMachineInside(2000, "pride");
//carInside.Rent();

//var carOut = new ProductionMachineOut(2010, "X4");
//carOut.Rent();

//var student  = new Student("mehrdad", 123);
//var studentGrade = new StudentGrade(17,3);
//student.ShowStudentPersonality();
//studentGrade.StudentAvrage();

//List<Category> categories = new List<Category>();
//var category = new Category("eghtesadi",2);

//categories.Add(category);


//var library = new Library();
//library.AddBook("financial", "mohammad", 1);
//var library1 = new Library();
//library1.AddBook("OOP", "Ali", 1);
//var library2 = new Library();
//library2.AddBook("OOP", "Ali", 2);

//library.ShowDetail();



class ExerciseTask : Task
{
    public ExerciseTask(string taskName, string taskDate) : base(taskName, taskDate)
    {

    }
    public override void PrintDetails()
    {
        Console.WriteLine($"Name:{TaskName} Date : {TaskDate}");
    }
}

