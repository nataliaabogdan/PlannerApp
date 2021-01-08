using System.Collections;

namespace PlannerApp.Model
{
    public abstract class IteratorAggregate
    {
        public abstract IEnumerator GetEnumerator();
    }
}