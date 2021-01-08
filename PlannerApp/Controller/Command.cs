using System;

namespace PlannerApp.Model
{
    public abstract class Command
    {
        public DayAndNote TemplateMethod()
        {
            this.PreWeekChoice();
            var x=this.WeekChoice();
            return this.PostWeekChoice(x);
        }

        public virtual void PreWeekChoice()
        {
        }

        public virtual DayAndNote PostWeekChoice(int day)
        {
            return new DayAndNote(day,"");
            
        }

        public int WeekChoice()
        {
            int day1 = -1;
            while (day1 == -1)
            {
                string dayofweek = Console.ReadLine();
                switch (dayofweek)
                {
                    case "MONDAY":
                    case "monday":
                    case "Monday":
                        day1 = 0;
                        break;
                    case "TUESDAY":
                    case "Tuesday":
                    case "tuesday":
                        day1 = 1;
                        break;
                    case "WEDNESDAY":
                    case "Wednesday":
                    case "wednesday":
                        day1 = 2;
                        break;
                    case "THURSDAY":
                    case "Thursday":
                    case "thursday":
                        day1 = 3;
                        break;
                    case "FRIDAY":
                    case "Friday":
                    case "friday":
                        day1 = 4;
                        break;
                    case "SATURDAY":
                    case "Saturday":
                    case "saturday":
                        day1 = 5;
                        break;
                    case "SUNDAY":
                    case "Sunday":
                    case "sunday":
                        day1 = 6;
                        break;
                    case "EXIT":
                    case "Exit":
                    case "exit":
                        day1 = 7;
                        break;
                    default:
                        Console.WriteLine("There is no such day, try again");
                        System.Threading.Thread.Sleep(3000);
                        break;
                }
                if (day1 == 7) return day1;
            }
            return day1;
        }
    }
}