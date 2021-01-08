using System;
using PlannerApp.View;

namespace PlannerApp.Model
{
    public class Command5: Command
    {
        private Command5Text _command5Text;

        public Command5()
        {
            _command5Text=new Command5Text();
        }
        public override void PreWeekChoice()
        {
                   _command5Text.OutputPreWeekChoice();
        }

        public override DayAndNote PostWeekChoice(int day)
        {
            _command5Text.OutputPostWeekChoice();
            string placement = Console.ReadLine();
            return new DayAndNote(day,placement);        
        }
    }
}