using System;
using PlannerApp.Controller;

namespace PlannerApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Planner p = Planner.GetInstance();
            p.Run();
        }
    }
}