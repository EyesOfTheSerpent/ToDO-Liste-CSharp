
namespace ToDO_Liste
{
    internal class ToDoObjekt(string name, string desc, string date)
    {
        public string Name { get; private set; } = name;
        public string Desc { get; private set; } = desc;
        public string Date { get; private set; } = date;

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
