namespace PlannerApp.Model
{
    public class CreatorAddPlan: CreatorAdd
    {
        public override Add FactoryMethod(PlannerData plannerData)
        {
            return new AddPlan(plannerData);
        }
    }
}