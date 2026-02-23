namespace TaskManager
{
    class Manager
    {
        public List<Task> tasks { get; set; }

        public Manager()
        {
            tasks = new List<Task>();
        }

        public void addTask()
        {
            Console.WriteLine("Enter task title: ");
            string input = Console.ReadLine() ?? "";

            var t = new Task(input);
            tasks.Add(t);
        }

        public void viewTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.title} Completed: {task.isComplete}");
            }
        }

        public void setComplete()
        {
            Console.WriteLine("Enter task title: ");
            string title = Console.ReadLine() ?? "";

            Task? task = getTask(title);
            if (task == null) return;

            if (task.isComplete)
            {
                Console.WriteLine($"Task '{title}' is already completed.");
            }
            else
            {
                task.isComplete = true;
                Console.WriteLine($"Task '{title}' completed.");
            }
        }

        public void removeTask()
        {
            Console.WriteLine("Enter task title to remove: ");
            string title = Console.ReadLine() ?? "";

            Task? task = getTask(title);
            if (task == null) return;

            tasks.Remove(task);
            Console.WriteLine($"Task '{title}' removed.");
        }

        Task? getTask(string title)
        {
            Task? found = tasks.Find(t => t.title == title);
            if (found != null)
            {
                return found;
            }
            else
            {
                Console.WriteLine($"Task '{title}' not found.");
                return null;
            }
        }
    }

    class Task
    {
        public string title { get; set; }
        public bool isComplete { get; set; }

        public Task(string title)
        {
            this.title = title;
            isComplete = false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            var taskManager = new Manager();

            while (running)
            {
                showMenu();

                string input = Console.ReadLine() ?? "";

                switch (input)
                {
                    case "1":
                        taskManager.addTask();
                        break;
                    case "2":
                        taskManager.viewTasks();
                        break;
                    case "3":
                        taskManager.setComplete();
                        break;
                    case "4":
                        taskManager.removeTask();
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        static void showMenu()
        {
            string divider = new string('=', 25);

            Console.WriteLine($"{divider}\n1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task Complete");
            Console.WriteLine("4. Remove Task");
            Console.WriteLine("5. Exit");
            Console.WriteLine($"{divider}\n Select an option: ");
        }
    }
}