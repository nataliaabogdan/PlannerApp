using System;
using PlannerApp.View;

namespace PlannerApp.Model
{
    public class Command1And2: Command
    {
        private Command1And2Text _command1And2Text;

        public Command1And2()
        {
            _command1And2Text=new Command1And2Text();
        }
        public override void PreWeekChoice()
        {
            _command1And2Text.OutputPreWeekChoice();
        }

        public override DayAndNote PostWeekChoice(int day)
        {
            if (day == 7) return new DayAndNote(day,"");
            _command1And2Text.OutputPostWeekChoice();
            string note = Console.ReadLine();
            return new DayAndNote(day,note);
        }
    }
}