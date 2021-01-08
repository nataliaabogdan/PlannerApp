using System.Collections.Generic;

namespace PlannerApp.Model
{
    public interface IMemento
    {
        List<Event>[] GetWeek();
    }
}