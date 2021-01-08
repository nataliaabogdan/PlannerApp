using System;
using System.Collections.Generic;

namespace PlannerApp.Model
{
    public class PlannerData
    {
        public List<Event>[] week=new List<Event>[7];

        public PlannerData()
        {
            for (int i = 0; i < 7; i++)
            {
                week[i]=new List<Event>();
            }
        }

        public PlannerData(List<Event>[] _week)
        {
            this.week = _week;
        }
        public IMemento Save()
        {
            return new MementoPlannerData(week);
        }
        public void Restore(IMemento memento)
        {
            week= memento.GetWeek();
        }

        public bool IsPlacementValid(int day, int placement)
        {
            if (week[day].Count >= placement && week[day].Count>0) return true;
            return false;
        }
    }
}