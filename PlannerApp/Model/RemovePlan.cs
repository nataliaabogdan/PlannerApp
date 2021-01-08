namespace PlannerApp.Model
{
    public class RemovePlan: Remove
    {
        private PlannerData _plannerData;

        public RemovePlan(PlannerData plannerData)
        {
            _plannerData = plannerData;
        }
        public override void Removal(int day, int placement)
        {
            _plannerData.week[day].Remove(_plannerData.week[day][placement]);
        }
    }
}