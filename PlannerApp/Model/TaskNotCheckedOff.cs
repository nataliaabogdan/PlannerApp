namespace PlannerApp.Model
{
    public class TaskNotCheckedOff: StateOfTask
    {
        public TaskNotCheckedOff(){}
        public override void Check()
        {
            this._taskCheckable.TransitionTo(new TaskCheckedOff());
        }
        public override string DisplayATask()
        {
            string text = "";
            text+=_taskCheckable.Note+" "+"\x2610";
            return text;
        }
    }
}