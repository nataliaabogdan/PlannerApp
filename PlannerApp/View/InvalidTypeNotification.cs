using System;

namespace PlannerApp.Model
{
    public class InvalidTypeNotification
    {
        public InvalidTypeNotification(){}

        public void DisplayWarning()
        {
            Console.WriteLine("Invalid action");
        }

        public void DisplayInvalidPlacement()
        {
            Console.WriteLine("Placement is invalid, try again");
        }

        public void DisplayInvalidCommand()
        {
            Console.WriteLine("Unknown command, try again");
        }
    }
}