namespace PlannerApp.Model
{
    public class TaskCheckable: Event
    {
        public StateOfTask _stateOfTask;

        public TaskCheckable()
        {
            Note = "";
            _stateOfTask=new TaskNotCheckedOff();
        }
        public TaskCheckable(string xnote, StateOfTask stateOfTask)
        {
            Note = xnote;
            TransitionTo(stateOfTask);
        }
        public void TransitionTo(StateOfTask stateOfTask)
        {
            this._stateOfTask = stateOfTask;
            this._stateOfTask.SetTaskCheckable(this);
        }

        public override string Note { get; set; }
    }
}