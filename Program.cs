﻿using System.Text;

namespace ToDO_Liste
{
    internal class Program
    {
        private static void Main()
        {
            StyleConsole();
            var toDo = new ToDoManager();
            toDo.AskUser();
        }

        private static void StyleConsole() 
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        /*
        Konsollbasert ToDo liste
        Lag en todo app! Du skal kunne legge til oppgaver, 
        slette dem og gå inn på en task for å se beskrivelse eller flere detaljer
        */

    }
}
