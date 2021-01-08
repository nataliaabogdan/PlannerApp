namespace PlannerApp.Model
{
    public class DayAndNote
    {
        private int _day;
        private string _note;

        public int Day
        {
            get => _day;
            set => _day = value;
        }

        public string Note
        {
            get => _note;
            set => _note = value;
        }
        public DayAndNote(){}

        public DayAndNote(int day, string note)
        {
            Day = day;
            Note = note;
        }
    }
}