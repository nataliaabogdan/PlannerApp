namespace PlannerApp.Model
{
    public class TaskCheckable: Event
    {
        private bool _isChecked;
        public override string Note { get; set; }
        public bool IsChecked { get; set; }

        public TaskCheckable()
        {
            Note = "";
            IsChecked = false;
        }
        public TaskCheckable(string xnote)
        {
            Note = xnote;
            IsChecked = false;
        }
        public TaskCheckable(string xnote, bool xischecked)
        {
            Note = xnote;
            IsChecked = xischecked;
        }
    }
}