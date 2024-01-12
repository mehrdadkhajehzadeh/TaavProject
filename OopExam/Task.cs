
abstract class Task : TaskFunction
{
    protected string TaskName;
    protected string TaskDate;
    public Task(string taskName, string taskDate)
    {
        TaskName = taskName;
        TaskDate = taskDate;
    }
    public string GetTaskName()
    {
        return TaskName;
    }
    public string GetTaskDate()
    {
        return TaskDate;
    }
    public abstract void PrintDetails();
}
