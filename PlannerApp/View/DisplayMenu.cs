using System;

namespace PlannerApp.View
{
    public class DisplayMenu
    {
        public void Display()
        {
            Console.WriteLine("Choose one of the following commands: ");
            Console.WriteLine("1 - Add a new Checkable Task");
            Console.WriteLine("2 - Add a new Plan");
            Console.WriteLine("3 - Remove a Checkable Task");
            Console.WriteLine("4 - Remove a Plan");
            Console.WriteLine("5 - Check off a task");
            Console.WriteLine("6 - Reverse most recent addition/removal operation");
            Console.WriteLine("7 - Clear one day");
            Console.WriteLine("8 - Clear whole planner");
            Console.WriteLine("9 - Exit");
        }
    }
}