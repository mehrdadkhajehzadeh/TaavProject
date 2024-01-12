class ToDoList
{
    private List<Task> tasks;
    public ToDoList()
    {
        tasks = new List<Task>();
    }
    public void AddTask(Task task)
    {
        tasks.Add(task);
    }
    public void RemoveTask(string name)
    {
        foreach (Task task in tasks)
        {
            if (task.GetTaskName().Equals(name))
            {
                tasks.Remove(task);
            }
        }
    }
    public void ShowTasks()
    {
        foreach (Task task in tasks)
        {
            task.PrintDetails();
            Console.WriteLine();
        }

    }
}