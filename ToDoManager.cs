
namespace ToDO_Liste
{
    internal class ToDoManager
    {
        public List<ToDoObjekt> ToDoList { get; private set; } = [];
        //private List<TodoObjekt> ObjList = [];

        //static List<string> Names = [];
        //static List<string> Descs = [];
        //static List<string> Dates = [];

        //var test = DateTime.Now.ToString(HH:MM:SS);
        //TodoObjekt toDo = new();
        //ToDoObjekt TodoObjekt = new ToDoObjekt(string, string, string);
        //ToDoObjekt TodoObjekt2 = new(string, string, string);
        //List<ToDoObjekt>;
        //TodoObjekt toDo = new("John Doe", "30", "Something");

        /****************************************************************************/

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("------- Todo Liste -------");
            Console.WriteLine("1. Legg til oppgave.");
            Console.WriteLine("2. Les alle oppgavene.");
            Console.WriteLine("3. Slett oppgave.");
            Console.WriteLine("4. Avslutt program.");
        }

        public void AskUser()
        {
            MainMenu(); //<--
            Console.WriteLine("Legg til et nummer til hva du ønsker å gå inn på.");
            string UserInput = ForceNumber();
            //string UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case"1":
                    AddTask();
                    break;
                case"2":
                    ViewAllTasks();
                    break;
                case"3":
                    DeleteTask();
                    break;
                case"4":
                    Console.WriteLine("Avslutter program...");
                    Thread.Sleep(1400);
                    Environment.Exit(0);
                    break;
                default: 
                    Console.WriteLine("");
                    AskUser();
                    break;
            }
        }

        /****************************************************************************/

        private static string ForceNumber()
        {
            //Console.WriteLine("Skriv inn et tall");

            //bool isNum = int.TryParse(Console.ReadLine(), out int tall);
            //while (!isNum)
            //{
            //    Console.WriteLine("Du skrev ikke et tall, prøv igjen: ");
            //    isNum = int.TryParse(Console.ReadLine(), out tall);
            //}

            int tall;
            while (!int.TryParse(Console.ReadLine(), out tall))
                Console.WriteLine("Du skrev ikke et tall, prøv igjen.");
            
            switch (tall)
            {
                case 1:
                    return tall.ToString();
                case 2:
                    return tall.ToString();
                case 3:
                    return tall.ToString();
                case 4:
                    return tall.ToString();
                default:
                    Console.WriteLine();
                    return ForceNumber();
            }
        }

        public static string ForceInput()
        {
            string UserInput = Console.ReadLine() ?? String.Empty;
            return UserInput switch
            {
                null or "" => ForceNumber(),
                _ => UserInput,
            };
        }

        /****************************************************************************/

        public void AddTask()
        {
            MainMenu();
            string taskName = ForceInput();
            string taskDesc = ForceInput();
            var date = DateTime.Now.ToString("dd/MM HH:mm");
            
            //System.NullReferenceException: 'Object reference not set to an instance of an object.'
            ToDoList.Add(new ToDoObjekt(taskName, taskDesc, date));

            Console.WriteLine($"Added new task! ({taskName})");
            Console.ReadKey();
            AskUser();

            //string TaskDate = CreateDate();

            //string taskDate = DatoMetode
            //return this;
            //return new TodoObjekt(TaskName, TaskDesc);
            //Names.ToArray(TaskName);
            //Names.Add(TaskName);
        }

        public void ViewAllTasks()
        {
            MainMenu();
            foreach (var task in ToDoList)
            {
                task.ShowInfo();
            }
        }

        public void DeleteTask()
        {
            MainMenu();
            Console.WriteLine("Please specify what task you want to remove (by name).");
            var taskToRemove = ForceInput();
            int i = ToDoList.FindIndex(delegate (ToDoObjekt theName)
            {
                return theName.Name.Equals(taskToRemove, StringComparison.Ordinal);
            });
            ToDoList.RemoveAt(i);

            //ToDoList.Find(taskToRemove);
            //int i = ToDoList.FindIndex(a => a.Contains(taskToRemove));
            //int i = ToDoList.FindIndex();
            //ToDoList.Remove(taskToRemove);

            /*
             string taskToRemove = ForceInput();

            int index = ToDoList.FindIndex(t => t.TaskName == taskToRemove);
                if (index != -1)
                    {
                        ToDoList.RemoveAt(index);
                    }
                else
                    {
                        Console.WriteLine("No task found with the name: " + taskToRemove);
                    }
             */
        }
    }
}
