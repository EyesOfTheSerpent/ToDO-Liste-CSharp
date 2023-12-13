
namespace ToDO_Liste
{
    internal class ToDoManager
    {
        public List<ToDoObjekt> ToDoList { get; private set; } = [];
        private static readonly string NL = Environment.NewLine;

        /****************************************************************************/

        private static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("------- Todo Liste -------");
            Console.WriteLine("1. Legg til oppgave.");
            Console.WriteLine("2. Les alle oppgavene.");
            Console.WriteLine("3. Slett oppgave.");
            Console.WriteLine($"4. Avslutt program.{NL}");
        }

        private static void ErrorMenu()
        {
            MainMenu();
            Console.WriteLine("Du skrev ikke et tall, prøv igjen.");
        }

        public void AskUser()
        {
            MainMenu();
            Console.WriteLine("Legg til et nummer til hva du ønsker å gå inn på.");
            string UserInput = ForceNumber();
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
            int tall;
            while (!int.TryParse(Console.ReadLine(), out tall))
                ErrorMenu();

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
            Console.WriteLine("Vennligst legg til et navn.");
            string taskName = ForceInput();
            Console.WriteLine("Vennligst legg til en beskrivelse.");
            string taskDesc = ForceInput();
            var date = DateTime.Now.ToString("dd/MM HH:mm");
            
            ToDoList.Add(new ToDoObjekt(taskName, taskDesc, date));

            Console.WriteLine($"Lagt til ny task! ({taskName})");
            Console.WriteLine("Trykk på uansett knapp for å fortsette...");
            Console.ReadKey();
            AskUser();
        }

        public void ViewAllTasks()
        {
            MainMenu();
            //!myList.Any()
            if (ToDoList.Count == 0)
            {
                Console.WriteLine($"Ingen tasks å vise!{NL}");
            }
            else
            {
                Console.WriteLine($"Viser frem tasks:{NL}");
                foreach (var task in ToDoList)
                {
                    task.ShowInfo();
                }
            }
            Console.WriteLine("Trykk på uansett knapp for å fortsette...");
            Console.ReadKey();
            AskUser();
        }

        public void DeleteTask()
        {
            MainMenu();
            if (ToDoList.Count == 0)
            {
                Console.WriteLine($"Ingen tasks å slette!{NL}");
            }
            else
            {
                Console.WriteLine("Vennligst si hvilken task (ved hjelp av navn) du ønsker å fjerne.");
                var taskToRemove = ForceInput();
                var LocateName = ToDoList.Find(delegate (ToDoObjekt ObjName)
                {
                    return ObjName.Name.Equals(taskToRemove, StringComparison.Ordinal);
                });

                if (LocateName != null)
                {
                    ToDoList.Remove(LocateName);
                    Console.WriteLine("Task har blitt slettet!");
                }
                else
                {
                    Console.WriteLine("Fant ikke task du så etter.");
                }
            }
            Console.WriteLine("Trykk på uansett knapp for å fortsette...");
            Console.ReadKey();
            AskUser();
        }
    }
}
