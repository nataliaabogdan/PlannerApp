using System;

namespace PlannerApp.View
{
    public class Command5Text: CommandText
    {
        public Command5Text(){}
        public void OutputPreWeekChoice()
        {
            Console.WriteLine("From which day should the task be checked off?");
            Console.WriteLine("If you wish to exit, just spell it out!");         
        }

        public void OutputPostWeekChoice()
        {
            Console.WriteLine("Which in line from the top is said task?");
        }
    }
}