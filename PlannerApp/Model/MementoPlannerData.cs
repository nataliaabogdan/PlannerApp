using System;
using System.Collections.Generic;

namespace PlannerApp.Model
{
    public class MementoPlannerData: IMemento
    {
        private List<Event>[] _week=new List<Event>[7];

        public MementoPlannerData(List<Event>[] week)
        {
            for (int i = 0; i < 7; i++)
            {
                _week[i]=new List<Event>();
                int j = 0;
                while (j < week[i].Count && week[i].Count!=0)
                {
                    var x = week[i][j];
                    _week[i].Add(x);
                    j++;
                }
            }
        }
        public List<Event>[] GetWeek()
        {
            return _week;
        }
    }
}