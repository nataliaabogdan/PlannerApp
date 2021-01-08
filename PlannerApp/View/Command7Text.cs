using System;

namespace PlannerApp.View
{
    public class Command7Text: CommandText
    {
        public Command7Text(){}
        public void OutputPreWeekChoice()
        {
            Console.WriteLine("Which day should be cleared?");
            Console.WriteLine("If you wish to exit, just spell it out!");
        }

        public void OutputPostWeekChoice()
        {
        }
    }
}