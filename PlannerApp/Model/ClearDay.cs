namespace PlannerApp.Model
{
    public class ClearDay
    {
        public void Clear(PlannerData plannerData, int day)
        {
            plannerData.week[day].Clear();
        }
    }
}