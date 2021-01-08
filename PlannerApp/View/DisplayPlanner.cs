using System;
using System.Linq;
using PlannerApp.Controller;
using PlannerApp.Model;

namespace PlannerApp.View
{
    public class DisplayPlanner
    {
        static public int tableWidth=100;

        public void Display1Planner(Planner planner)
        {
            Console.Clear();
            PrintSeparationLine();
            PrintFirstRow("Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday");
            int lengthOfLongestDay = planner.getLengthOfLongestDay();
            PrintSeparationLine();
            for (int i = 0; i < lengthOfLongestDay; i++)
            {
                PrintRow(planner,i);
            }
            PrintSeparationLine();
        }
        public static void PrintSeparationLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        static void PrintRow(Planner planner,int rowNumber)
        {
            int width = (tableWidth - planner._PlannerData.week.Length) / planner._PlannerData.week.Length;
            string row = "|";
            for (int i=0;i<7;i++)
            {
                string text="";
                if (planner._PlannerData.week[i].Count >= rowNumber + 1)
                {
                    if (planner._PlannerData.week[i][rowNumber].GetType() == typeof(TaskCheckable))
                    {
                        var x = (TaskCheckable) (planner._PlannerData.week[i][rowNumber]);
                        text = x._stateOfTask.DisplayATask();
                    }
                    else text = Display1Plan((Plan) planner._PlannerData.week[i][rowNumber]);
                }
                row += ProperAlignment(text, width) + "|";
            }
            Console.WriteLine(row);
        }
        public static void PrintFirstRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += ProperAlignment(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        public static string ProperAlignment(string text, int width)
        {
            if (text.Length > width)
            {
                text = text.Substring(0, width - 4) +
                       "..." + text[text.Length - 1];
            }

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
        public static string Display1Plan(Plan plan)
        {
            return plan.Note;
        }
    }
    
}