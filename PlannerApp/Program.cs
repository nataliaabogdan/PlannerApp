using System;
using PlannerApp.Model;

namespace PlannerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Planner p=Planner.GetInstance();
            //p.week[0].Add(new Plan("qwerty"));
            //p.week[3].Add(new TaskCheckable("taskcheckable",true));
            //p.week[3].Add(new Plan("asdfgh"));
            //string s = (string)10003;
            Console.WriteLine( "\x2610"+"\x2713"+ "  ");
        }
    }
}