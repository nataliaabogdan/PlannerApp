namespace PlannerApp.Model
{
    public class TaskCheckedOff: StateOfTask
    {
        public TaskCheckedOff(){}

        public override void Check()
        {
            this._taskCheckable.TransitionTo(new TaskNotCheckedOff());
        }

        public override string DisplayATask()
        {
            string text = "";
            text+=_taskCheckable.Note+" "+"\x2713";
            return text;
        }
    }
}