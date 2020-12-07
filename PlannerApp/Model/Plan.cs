namespace PlannerApp.Model
{
    public class Plan: Event
    {
        public override string Note { get; set; }
        public Plan()
        {
            Note = "";
        }
        public Plan(string xnote)
        {
            Note = xnote;
        }
    }
}