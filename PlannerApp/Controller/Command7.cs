using System;
using PlannerApp.View;

namespace PlannerApp.Model
{
    public class Command7:Command
    {
        private Command7Text _command7Text;

        public Command7()
        {
            _command7Text=new Command7Text();
        }
        public override void PreWeekChoice()
        {
            _command7Text.OutputPreWeekChoice();
        }

        public override DayAndNote PostWeekChoice(int day)
        {
            return new DayAndNote(day,"");
        }
    }
}