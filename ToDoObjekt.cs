
namespace ToDO_Liste
{
    internal class ToDoObjekt
    {
        public string Name { get; private set; }
        public string Desc { get; private set; }
        public string Date { get; private set; }

        public ToDoObjekt(string name, string desc, string date)
        {
            Name = name;
            Desc = desc;
            Date = date;
        }

        public void ShowInfo()
        {
            Console.WriteLine("/******************/");
            Console.WriteLine(Name);
            Console.WriteLine(Desc);
            Console.WriteLine(Date);
            Console.WriteLine($"/******************/{Environment.NewLine}");
        }
    }
}
