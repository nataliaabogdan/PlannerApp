using System;

namespace PlannerApp.View
{
    public class Command3And4Text: CommandText
    {
        public Command3And4Text(){}
        public void OutputPreWeekChoice()
        {
            Console.WriteLine("From which day should it be removed?");
            Console.WriteLine("If you wish to exit, just spell it out!");
        }

        public void OutputPostWeekChoice()
        {
            Console.WriteLine("Which in line from the top is this event?");
        }
    }
}