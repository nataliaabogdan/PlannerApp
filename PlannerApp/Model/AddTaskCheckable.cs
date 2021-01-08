namespace PlannerApp.Model
{
    public class AddTaskCheckable: Add
    {
        private PlannerData _plannerData;

        public AddTaskCheckable(PlannerData plannerData)
        {
            _plannerData = plannerData;
        }
        public override void AddTaskOrPlan(int day, string note)
        {
            _plannerData.week[day].Add(new TaskCheckable(note,new TaskNotCheckedOff()));
        }
    }
}