namespace PlannerApp.Model
{
    public abstract class CreatorAdd
    {
        public abstract Add FactoryMethod(PlannerData plannerData);

        public void Addition(PlannerData plannerData, int day, string note)
        {
            Add a = FactoryMethod(plannerData);
            a.AddTaskOrPlan(day, note);
        }
    }
}