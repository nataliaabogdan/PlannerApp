using System;

namespace PlannerApp.Model
{
    public class ClearAll
    {
        public ClearAll(){}
        public void ClearWholePlanner(PlannerData plannerData)
        {
            for (int i = 0; i < 7; i++)
            {
                plannerData.week[i].Clear();
            }
        }
    }
}