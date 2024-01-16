
using OopExam;
using System.Reflection.PortableExecutable;

var person = new Person("mehrdad", "kh");
person.GetFullName();


var employee = new Employee("Hossein", 1, 1000);
employee.PrintDetails();

var manager = new Manager("Developer", "Mehrdad", 2, 1500);
manager.PrintDetails();

var carInside = new ProductionMachineInside(2000, "pride");
carInside.Rent();

var carOut = new ProductionMachineOut(2010, "X4");
carOut.Rent();

var student = new Student("mehrdad", 123);
var studentGrade = new StudentGrade(17, 3);
student.ShowStudentPersonality();
studentGrade.StudentAvrage();

List<Category> categories = new List<Category>();
var category = new Category("eghtesadi", 2);

categories.Add(category);


var library = new Library();
library.AddBook("financial", "mohammad", 1);
var library1 = new Library();
library1.AddBook("OOP", "Ali", 1);
var library2 = new Library();
library2.AddBook("OOP", "Ali", 2);

library.ShowDetail();


ToDoList list = new ToDoList();

var task1 = new ExerciseTask("Body Building", "2024-01-15");
list.AddTask(task1);

list.ShowTasks();

var food = new Resturant();
food.AddFood(2, 300, 2);
food.ShowDetail();

var hero = new Hero("shir", 300, 1500, 5);
var enemy = new Enemy("babr", 200, 1500);

enemy.BeAttached(hero.Power);

enemy.BeAttached(hero.Power);
enemy.BeAttached(hero.Power);
enemy.BeAttached(hero.Power);
enemy.BeAttached(hero.Power);
