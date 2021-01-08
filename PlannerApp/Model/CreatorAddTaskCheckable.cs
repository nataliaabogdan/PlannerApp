namespace PlannerApp.Model
{
    public class CreatorAddTaskCheckable: CreatorAdd
    {
        public override Add FactoryMethod(PlannerData plannerData)
        {
            return new AddTaskCheckable(plannerData);
        }
    }
}