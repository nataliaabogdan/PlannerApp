namespace PlannerApp.Model
{
    public abstract class Event
    {
        private string _note;
        public abstract string Note { get; set; }
    }
}