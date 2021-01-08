using System;

namespace PlannerApp.View
{
    public class Command1And2Text: CommandText
    {
        public Command1And2Text() {}

        public void OutputPreWeekChoice()
        {
            Console.WriteLine("To which day should your task be added?");
            Console.WriteLine("If you wish to exit, just spell it out!");
        }

        public void OutputPostWeekChoice()
        {
            Console.WriteLine("Enter a note tag for your task: ");
        }
    }
}