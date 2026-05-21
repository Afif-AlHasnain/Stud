
class TaskItem
{
    public string Title{get;set;}
    public bool IsCompleted{get;set;}

    public TaskItem(string title)
    {
        Title=title;
        IsCompleted=true;
    }
}
class Program
{
    static List<TaskItem> tasks = new List<TaskItem>();
    
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Choose option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;

                case "2":
                    ViewTasks();
                    break;
                    case "3":
                        CompleteTask();
                        break;

                case "4":
                    return;

                default:
                Console.WriteLine("Invalid Option");
                break;
                    

            }
        }
    }

    static void AddTask()
    {
        Console.WriteLine("Enter task title: ");
        string title = Console.ReadLine();
        tasks.Add(new TaskItem(title));
        Console.WriteLine("Task added successfully");

    }
    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No Tasks available");
            return;
        }

        Console.WriteLine("\n Tasks: ");
        for(int i= 0; i < tasks.Count; i++){
            string status = tasks[i].IsCompleted ? "[completed]":"Pending";
            Console.WriteLine($"{i+1}. {tasks[i].Title} {status}");
        }
    }
    
    static void CompleteTask()
    {
        ViewTasks();

        if(tasks.Count==0)return;

        Console.WriteLine("Enter task number to complete: ");

        int number = int.Parse(Console.ReadLine());

        if(number>=1 && number <= tasks.Count)
        {
            tasks[number-1].IsCompleted=true;
            Console.WriteLine("Tasks is completed");
        }
        else
        {
            Console.WriteLine("Invalid task number");
        }
    }
}