using PlannerApp.Controller;

namespace PlannerApp.Model
{
    public class AddPlan: Add
    {
        private PlannerData _plannerData;
        
        public AddPlan(PlannerData plannerData)
        {
            _plannerData = plannerData;
        }
        public override void AddTaskOrPlan(int day, string note)
        {
            _plannerData.week[day].Add(new Plan(note));
        }
    }
}