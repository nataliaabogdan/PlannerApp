using System;
using PlannerApp.View;

namespace PlannerApp.Model
{
    public class Command3And4: Command
    {
        private Command3And4Text _command3And4Text;

        public Command3And4()
        {
            _command3And4Text=new Command3And4Text();
        }
        public override void PreWeekChoice()
        {
            _command3And4Text.OutputPreWeekChoice();
        }

        public override DayAndNote PostWeekChoice(int day)
        {
            if (day == 7) return new DayAndNote(day,"");
            _command3And4Text.OutputPostWeekChoice();
            string placement = Console.ReadLine();
            return new DayAndNote(day,placement);
        }
    }
}