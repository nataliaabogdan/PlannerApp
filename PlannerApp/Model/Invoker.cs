namespace PlannerApp.Model
{
    public class Invoker
    {
        private Remove _remove;

        public Invoker() {}
        public void SetRemove(Remove remove)
        {
            _remove = remove;
        }
        public void InvokeRemove(int day,int placement)
        {
            _remove.Removal(day,placement);
        }
    }
}