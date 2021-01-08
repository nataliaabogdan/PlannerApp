namespace PlannerApp.Model
{
    public abstract class StateOfTask
    {
        protected TaskCheckable _taskCheckable;
        public void SetTaskCheckable(TaskCheckable taskCheckable)
        {
            _taskCheckable = taskCheckable;
        }

        public abstract void Check();
        public abstract string DisplayATask();
    }
}