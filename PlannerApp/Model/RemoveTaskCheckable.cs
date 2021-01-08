namespace PlannerApp.Model
{
    public class RemoveTaskCheckable: Remove
    {
        private PlannerData _plannerData;

        public RemoveTaskCheckable(PlannerData plannerData)
        {
            _plannerData = plannerData;
        }
        public override void Removal(int day, int placement)
        {
            _plannerData.week[day].Remove(_plannerData.week[day][placement]);

        }
    }
}